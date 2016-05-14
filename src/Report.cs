using SigHelper;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;

namespace LibCheck
{
    public partial class LibChk
    {

        // Create unified and split reports. Also, calculate breaking changes.
        public static void Report(Hashtable oldList, Hashtable newList, string assembly,
            out int added, out int removed, out int typesAdded, out int typesRemoved, out int total,
            out int breaking, ref bool itemsAdded)
        {
            // initialize counters
            added = removed = typesAdded = typesRemoved = total = breaking = 0;

            // collect all unique types from both lists and calculate total members in most recent list.
            ArrayList alltypes = new ArrayList();

            foreach (string type in oldList.Keys)
            {

                alltypes.Add(type.Trim());

                // check if this is in the new list, if not it has been removed
                if (!newList.ContainsKey(type))
                {
                    typesRemoved++;
                }

                if (newList == null || newList.Count <= 0)
                    total += ((ArrayList)oldList[type]).Count;
            }

            foreach (string type in newList.Keys)
            {
                total += ((ArrayList)newList[type]).Count;

                // check if this type is in the old list, if not it was added
                if (!oldList.ContainsKey(type))
                {
                    typesAdded++;
                }


                if (!alltypes.Contains(type.Trim()))
                    alltypes.Add(type.Trim());
            }

            alltypes.Sort();

            // report all changes
            foreach (string type in alltypes)
            {

                //MAKE THE TOTAL REPORT


                if (type == null || type == "")
                {
#if DOREPORTS
                    errorWriter.WriteLine(" Blank or null type key found (and skipped).");
#endif
                    continue;
                }

                // pick up the new and old member arraylists for this type
                ArrayList oldmembers = (oldList.ContainsKey(type)) ? (ArrayList)oldList[type] : new ArrayList(0);
                ArrayList newmembers = (newList.ContainsKey(type)) ? (ArrayList)newList[type] : new ArrayList(0);

                //initialize the member counts for this type for each particular assembly
                int asm1Members, asm2Members;
                asm1Members = asm2Members = 0;

                // Count the original number of members
                if (oldmembers != null)
                {
                    asm1Members = oldmembers.Count;
                }

                if (newmembers != null)
                {
                    asm2Members = newmembers.Count;
                }


#if DOREPORTS
                errorWriter.WriteLine("Type: '{0,-48}' - old members: {1,3}, new members: {2,3}",
                      type, oldmembers.Count, newmembers.Count);
#endif

                //if (oldmembers.Count + newmembers.Count == 0)
                //	continue;

                // generate reports and count new and removed members and breaking changes
                breaking += ReportMembers(oldmembers, newmembers, ref added,
                    ref removed, ref itemsAdded, asm1Members, asm2Members);
            }
        }

        public static void DoXmlReport(SortedList changes, int asm1Members, int asm2Members)
        {
            string typeName = "";
            int added, removed;
            added = 0;
            removed = 0;
            foreach (DictionaryEntry e in changes)
            {

                object[] values = (object[])e.Value;

                CompareResults res = ((CompareResults)values[2]);

                if (res == CompareResults.Breaking ||
                    res == CompareResults.Different ||
                    res == CompareResults.NonBreaking)
                {
                    if (values[0] != null)
                    { //Removed breakers
                        TypeMember otm = (TypeMember)values[0];
                        removed++;

                        if (typeName != otm.TypeName)
                        {
                            //xmlReport.EndTypeSection(oldVersion, newVersion);
                            //xmlReport.StartTypeSection(otm, oldVersion, newVersion);
                            typeName = otm.TypeName;
                        }
                        //xmlReport.MemberRemoved(otm);
                    }

                    if (values[1] != null)
                    { //Added Breakers
                        TypeMember ntm = (TypeMember)values[1];
                        added++;

                        if (typeName != ntm.TypeName)
                        {
                            //xmlReport.EndTypeSection(oldVersion, newVersion);
                            //xmlReport.StartTypeSection(ntm, oldVersion, newVersion);
                            typeName = ntm.TypeName;
                        }
                        //xmlReport.MemberAdded(ntm);
                    }
                }

            }

            //only report if something has changed.
            if ((added + removed) > 0)
            {
                int changed = added + removed;
                //		System.Type type;
                //robvi			type = System.Reflection.

                //xmlReport.WriteTypeSummary(added.ToString(), removed.ToString(), asm1Members.ToString(), asm2Members.ToString());
            }
            //xmlReport.EndTypeSection(oldVersion, newVersion);
        }

        //THIS IS WHERE BREAKING CHANGES ARE CALCULATED...
        // handle reporting for each type.
        public static int ReportMembers(ArrayList oldlist, ArrayList newlist,
            ref int added, ref int removed, ref bool itemsAdded, int asm1Members, int asm2Members)
        {
            //Console.WriteLine("p0");
            int breaking = 0;
            bool itemsRemoved = false;

            TypeMember oldtm = (oldlist.Count > 0) ? (TypeMember)oldlist[0] : null;
            TypeMember newtm = (newlist.Count > 0) ? (TypeMember)newlist[0] : null;


            if (oldtm == null && newtm == null)
            {
#if DOREPORTS
                errorWriter.WriteLine("bad member lists passed to ReportMembers.");
#endif
                return 0;
            }

            // Determine the level of change between types.
            string okey = (oldtm != null) ? oldtm.TypeKey : "";
            string nkey = (newtm != null) ? newtm.TypeKey : "";
            CompareResults typediff;
            bool typeAdded = false;

            try
            {

                //HERE IS WHERE WE COMPARE TYPE CHANGES!!!
                typediff = TypeMember.EvalTypeChange(oldtm, newtm,
                    alIntfcAdds, addSer, out typeAdded, addStruct, addStructMethod);

                if (typediff == CompareResults.Breaking)
                {
                    breaking++;
                }

                //Console.WriteLine("Could not compare Containing Types"); 
            }
            catch (Exception)
            {
                typediff = CompareResults.Same;
                //Console.WriteLine(e.Message);
                return 0; //???
            }

            SortedList changes = new SortedList();

            if ((oldtm != null && oldtm.IsEnum) || (newtm != null && newtm.IsEnum))
            {
                Console.WriteLine("p7: " + (oldtm == null).ToString() + (newtm == null).ToString());
                //DON'T DO THIS
            }
            else
            {
                changes = GetChanges(oldlist, newlist, ref added, ref removed,
                    ref itemsRemoved, typeAdded);
                //Console.WriteLine("p4");
                //P12 TEMPORARY, to have this inside the if, move it out once fixed...

                DoXmlReport(changes, asm1Members, asm2Members);
#if DOREPORTS
                //DoXmlReport (changes);
#endif
                //robvi
                if (!addSer && !addStruct && !addStructMethod)
                {
                    if (changes.Count == 0)
                        return 0;
                }
            }
            int tempAdded = added;
            int tempRemoved = removed;
            int preTotal = added + removed;
            bool noRows = false;
            bool goodToGo = true;
            string tempName = "";

            foreach (DictionaryEntry entry in changes)
            {

                object[] value = (object[])entry.Value;

                if (value[0] != null)
                {
                    tempName = "<b>" + ((TypeMember)value[0]).Namespace + "." +
                        ((TypeMember)value[0]).TypeName + "</b>";
                    //			    if (addsOnly == false) {
                    if (unified.RemovedMember(((TypeMember)value[0]).MemberToHtml("black"),
                        true, ref tempRemoved, true) ||
                        (CompareResults)value[2] == CompareResults.Breaking)
                    {
                        noRows = true;

                        //NOTE: this becomes an unnecessary check if you include the outer check
                        //					if (addsOnly == false)
                        break;
                    }
                    //			    }
                }

                if (value[1] != null)
                {
                    tempName = "<b>" + ((TypeMember)value[1]).Namespace + "." +
                        ((TypeMember)value[1]).TypeName + "</b>";

                    if (unified.AddedMember(((TypeMember)value[1]).MemberToHtml("black"),
                        true, ref tempAdded, true) ||
                        (CompareResults)value[2] == CompareResults.Breaking)
                    {
                        noRows = true;

                        if (addsOnly)
                        {
                            foreach (DictionaryEntry de in changes)
                            {
                                if (((object[])de.Value)[0] != null)
                                {
                                    goodToGo = true;
                                    break;
                                }
                                goodToGo = false;
                            }
                        }

                        if (goodToGo == false && itemsRemoved == false)
                        {

                            //WRITE THIS TO THE SHORT SUMMARY FILE...
                            AddsFile.WriteLine("<br>\r\n<b><font color=\"red\">" +
                                "Type Added:</font> " +
                                ((TypeMember)value[1]).Namespace + "." +
                                ((TypeMember)value[1]).TypeName + "</b>\r\n<p><hr>");
                            itemsAdded = true;
                        }

                        if (itemsRemoved)
                            goodToGo = true;

                        break;
                    }
                }
            }

            //if (oldtm.IsEnum)
            //Console.WriteLine("p1: " + noRows);
            //P12 Modified
            //Console.WriteLine("p1: {0}, {1}", oldtm==null, newtm==null);
            if (noRows || (((oldtm != null && oldtm.IsEnum) ||
                (newtm != null && newtm.IsEnum)) &&
                (typediff == CompareResults.Breaking ||
                typediff == CompareResults.NonBreaking)))
            {
                // What???
                //PASS THROUGH A BOOLEAN, indicating whether to check for the misc value on this type
                //ONLY do this for the first dictionaryentry checked, if the first doesn't have it, NONE will
                //Console.WriteLine("p2");
                // write type to the split and unified reports
                ReportType(oldtm, newtm, typediff, changes);
                //Console.WriteLine("p3");
                //if it is the second condition, that is, it is an enum, then
                //figure out if it is breaking. If not, remove one from the breaking total
                //			if (noRows == false) {
                //				breaking--;
                //			}
                //if one of these is an enum, we ened to remove the entry...

            }

            //robvi
            else if ((addSer || addStruct || addStructMethod) && typediff == CompareResults.Breaking)
            {
                ReportType(oldtm, newtm, typediff, changes);
            }
            else
            {
                added = tempAdded;
                removed = tempRemoved;
                return 0;
            }

            string membertext = null;
            string color;

            foreach (DictionaryEntry entry in changes)
            {

                object[] value = (object[])entry.Value;

                CompareResults memberdiff = (CompareResults)value[2];	// third element is change level
                color = "black";

                if (memberdiff == CompareResults.Breaking)
                {	// calculate breaking changes
                    if (noColor == false)
                        color = "B0000"; //red
                    else
                        color = "black";
                    if (!addSer && !addStruct && !addStructMethod)
                        breaking++;
                }

                //if (addsOnly == false) {
                if (value[0] != null)
                {
                    /*
                    if (((TypeMember)value[0]).TypeName == "CallType") {
                        Console.WriteLine("yup: OLD, " + ((TypeMember)value[0]).TypeName);
                        Console.ReadLine();
                    }
                    */
                    // SHOULDN'T THIS BE HERE???
                    // color = "red";
                    bool wasBlack = false;

                    if (color == "black")
                    {
                        wasBlack = true;
                    }

                    //				color = "B0000"; //red

                    TypeMember otm = (TypeMember)value[0];

                    membertext = otm.MemberToHtml(color);

                    // changes the output format of enum members...
                    membertext = DetermineIfEnum(membertext);


                    //where the hell does 18 come from???
                    if (otm.Misc != null && otm.Misc.IndexOf("obsoleteattribute-") >= 0 &&
                        ((value[1] != null && ((TypeMember)value[1]).Misc != null &&
                        otm.Misc != ((TypeMember)value[1]).Misc) ||
                        (value[1] != null && ((TypeMember)value[1]).Misc == null) ||
                        value[1] == null))
                    {
                        //						if (noColor)
                        int loc = otm.Misc.IndexOf("obsoleteattribute-");
                        string sub = otm.Misc.Substring(loc +
                            "obsoleteattribute-".Length);
                        int end = sub.IndexOf(";") >= 0 ?
                            sub.IndexOf(";") : -1;

                        if (end >= 0)
                            sub = sub.Substring(0, end);

                        membertext = "<font color=\"black\">" +
                            "[Obsolete: " + sub +
                            "]" + membertext.Substring(20);
                        //						else
                        //							membertext = "<font color=\"B0000\">" + "[Obsolete] //" +
                        //								membertext.Substring(20);
                    }

                    // compile text for unified report
                    unified.RemovedMember(membertext, wasBlack, ref removed, false);

                    // write member to split report
                    if (wasBlack)
                        color = "black";
                }
                //}

                if (value[1] != null)
                {
                    /*
                    if (((TypeMember)value[1]).TypeName == "CallType") {
                        Console.WriteLine("yup: " + ((TypeMember)value[1]).TypeName);
                        Console.ReadLine();
                    }
                    */
                    // DON'T!!! Some adds are breaking, such as adding an 
                    // abstract member to an abstract type...
                    // ALWAYS MAKE ADDS BLACK!
                    //	color = "black";

                    TypeMember ntm = (TypeMember)value[1];

                    membertext = ntm.MemberToHtml(color);

                    //changes the output format of enum members...
                    membertext = DetermineIfEnum(membertext);


                    if (ntm.Misc != null && ntm.Misc.IndexOf("obsoleteattribute-") >= 0 &&
                        ((value[0] != null && ((TypeMember)value[0]).Misc != null &&
                        ntm.Misc != ((TypeMember)value[0]).Misc) ||
                        (value[0] != null && ((TypeMember)value[0]).Misc == null) ||
                        value[0] == null))
                    {

                        int loc = ntm.Misc.IndexOf("obsoleteattribute-");
                        string sub = ntm.Misc.Substring(loc +
                            "obsoleteattribute-".Length);
                        int end = sub.IndexOf(";") >= 0 ?
                            sub.IndexOf(";") : -1;

                        if (end >= 0)
                            sub = sub.Substring(0, end);

                        membertext = "<font color=\"black\">" +
                            "[Obsolete: " + sub +
                            "]" + membertext.Substring(20);

                        //						membertext = "<font color=\"black\">" + "[Obsolete] " +
                        //							membertext.Substring(20);
                    }

                    // compile text for unified report
                    unified.AddedMember(membertext, (color == "black"), ref added, false);
                }

            }

            //WEIRD LOGIC, a workaround at this point...
            if ((added + removed) > 0 || preTotal == 0)
            {
                if (goodToGo)
                {
                    if (addsOnly && (added > 0) && unified.GetAddedMember().Trim() != "")
                    {
                        //write this to the short summary file!
                        AddsFile.WriteLine("<br>\r\n<b><font color=\"blue\">" +
                            "Type Name ==></font></b> " +
                            tempName + "\r\n<br><b><font color=\"red\">" +
                            "Members Added:</font></b> " +
                            unified.GetAddedMember() + "\r\n<p><hr>");

                        itemsAdded = true;
                    }
                }
                //this was MOVED, since we want to write it out, regardless of good to go!
                if (!addSer && !addStruct && !addStructMethod)
                    unified.WriteMemberRow();	// write member info to unified report
            }

            return breaking;
        }


        // Remove common members from both lists
        // TODO: If type is changed, are all members reported as changed?
        public static SortedList GetChanges(ArrayList olist, ArrayList nlist, ref int added, ref int removed, ref bool itemsRemoved, bool typeAdded)
        {
            // list by MemberShortKey of old TypeMember, new TypeMember pairs, and change level
            // necessary since olist and nlist are by ref, event if they appear not to be.
            ArrayList oldlist = new ArrayList(olist);

            ArrayList newlist = new ArrayList(nlist);

            SortedList results = new SortedList(Comparer.Default, oldlist.Count);

            // remove common members. add any which have changed to the list along with their change level
            int max = newlist.Count;

            CompareResults memberdiff;
            // for each new TypeMember
            for (int i = 0; i < max;)
            {
                //Console.WriteLine (i);

                bool found = false;

                TypeMember ntm = (TypeMember)newlist[i];




                // search for an old TypeMember with the same signature
                for (int j = 0; j < oldlist.Count; j++)
                {

                    // FIRST COMPARISON CHECK IS HERE!
                    TypeMember otm = (TypeMember)oldlist[j];

                    if (otm.MemberShortKey != ntm.MemberShortKey)
                        continue;

                    // OK, So here, you have found a match: type and name...
                    // the TypeMember.EvalMemberChange procedure will 
                    // determine how LARGE the change was...
                    // evaluate the change level when a match is found.
                    memberdiff = TypeMember.EvalMemberChange(otm, ntm, alIntfcAdds, typeAdded);

                    //Console.WriteLine (memberdiff);
                    switch (memberdiff)
                    {

                        // add any changes to the change list
                        case CompareResults.Breaking:

                            //P12 added
                            //Console.WriteLine(ntm.MemberShortKey);
                            //Console.ReadLine();
                            goto case CompareResults.NonBreaking;


                        case CompareResults.NonBreaking:

                            //A MOD BY CHRISKG, 3/7/2001, please verify if required...
                            if (memberdiff == CompareResults.NonBreaking)
                            {
                                added++;
                                removed++;
                            }

                            try
                            {

                                results.Add(ntm.MemberShortKey,
                                    new object[] { otm, ntm, memberdiff });

#if DOREPORTS
                            }
                            catch (Exception e)
                            {
                                errorWriter.WriteLine("Error adding change for: " +
                                  "'{0}', '{1}'.", otm.FullName, ntm.FullName);

                                errorWriter.WriteLine(e.ToString());
#else
                            }
                            catch (Exception)
                            {
#endif
                            }
                            goto case CompareResults.Same;
                        case CompareResults.Same:

                            found = true;
                            newlist.RemoveAt(i);
                            oldlist.RemoveAt(j);
                            max--;
                            itemsRemoved = true;
                            continue;

                        case CompareResults.Different:	// nothing should evaluate as different at this level

                        default:
#if DOREPORTS
                            errorWriter.WriteLine("Error in LibCheck: " +
                                "RemoveRange:\r\n\told short key: " +
                                "'{0}'\r\n\tnew short key: '{1}'\r\n\t" +
                                " - difference level: {2}",
                                otm.MemberShortKey, ntm.MemberShortKey,
                                ((Enum)memberdiff).ToString());
#endif

                            continue;
                    }
                }

                if (!found)
                {

                    // if no matches found, then this is a new member


                    added++;

                    //robvi Added for Ambiguity problem
                    //here we want to check for overloaded methods that differ by reference types
                    //at this point we now ntm is an added member, check if this member is overloading
                    //an existing method
                    //ROBVI adding ambiguity check portion here

                    //IsAmbiguous(ntm, newlist);


                    memberdiff = TypeMember.EvalMemberChange(null, ntm, alIntfcAdds,
                        typeAdded);






                    try
                    {

                        results.Add(ntm.MemberShortKey, new object[] { null, ntm, memberdiff });

#if DOREPORTS
                    }
                    catch (Exception e)
                    {
                        errorWriter.WriteLine("Error adding change for: null, '{0}'.", ntm.FullName);
                        errorWriter.WriteLine(e.ToString());
#else
                    }
                    catch (Exception)
                    {
#endif
                    }

                    i++;
                }
            }

            // for all members left in the old member list then this is a removed member
            foreach (TypeMember otm in oldlist)
            {

                // if there's an entry in the change list, there's something wrong
                if (results.ContainsKey(otm.MemberShortKey))
#if DOREPORTS
                    errorWriter.WriteLine("Error in LibCheck: RemoveRange: {0} was not removed " +
                    "from old list, but shows up in the change list anyway.", otm.FullName);
#endif

                    removed++;
                //			bool typeAdded = false;
                memberdiff = TypeMember.EvalMemberChange(otm, null, alIntfcAdds, typeAdded);

                try
                {

                    results.Add(otm.MemberShortKey, new object[] { otm, null, memberdiff });

#if DOREPORTS
                }
                catch (Exception e)
                {
                    errorWriter.WriteLine("Error adding change for: '{0}', null.", otm.FullName);
                    errorWriter.WriteLine(e.ToString());
#else
                }
                catch (Exception)
                {
#endif
                }
            }

            return results;
        }

        // report type and include a change row if necessary.
        public static void ReportType(TypeMember otm, TypeMember ntm,
            CompareResults diff, SortedList changes)
        {
            string writeVal = "";
            bool writeToReport = false;


            if (addStructMethod)
            {

                string added = "";
                string removed = "";
                string extraVal;
                int istart;
                int iend;



                if (otm.Misc.ToLower().IndexOf("structmethods") >= 0 ||
                    ntm.Misc.ToLower().IndexOf("structmethods") >= 0)
                {

                    istart = otm.Misc.ToLower().IndexOf("structmethods");
                    iend = otm.Misc.ToLower().IndexOf(";", istart + 1);

                    if (iend < 0)
                        iend = otm.Misc.Length - 1;

                    string otmser;
                    if (istart < 0)
                        otmser = "";
                    else
                        otmser = otm.Misc.Substring(istart, iend - istart);


                    istart = ntm.Misc.ToLower().IndexOf("structmethods");
                    iend = ntm.Misc.ToLower().IndexOf(";", istart + 1);

                    if (iend < 0)
                        iend = ntm.Misc.Length - 1;

                    string ntmser;
                    if (istart < 0)
                        ntmser = "";
                    else
                        ntmser = ntm.Misc.Substring(istart, iend - istart);





                    if (ntmser != otmser)
                    {
                        bool ocomvistype, ocomvisasm;
                        bool ncomvistype, ncomvisasm;

                        string oldcom = otm.Misc.Substring(otm.Misc.LastIndexOf(";") + 1);
                        string newcom = ntm.Misc.Substring(ntm.Misc.LastIndexOf(";") + 1);

                        ocomvistype = oldcom.Substring(0, oldcom.IndexOf(",")) == "comvistype=True" ? true : false;
                        ocomvisasm = oldcom.Substring(oldcom.IndexOf(",") + 1) == "comvisasm=True" ? true : false;

                        ncomvistype = newcom.Substring(0, newcom.IndexOf(",")) == "comvistype=True" ? true : false;
                        ncomvisasm = newcom.Substring(newcom.IndexOf(",") + 1) == "comvisasm=True" ? true : false;


                        writeToReport = true;
                        //robvi added this to write out what's been removed or added:
                        Hashtable oldSerFields = new Hashtable();
                        Hashtable newSerFields = new Hashtable();
                        int start = otmser.IndexOf("=");
                        int sep = 0;
                        string sub;

                        while (start < otmser.Length)
                        {
                            sep = otmser.IndexOf(',', start + 1);
                            if (sep == -1)//end case
                            {
                                sub = otmser.Substring(start + 1);
                                oldSerFields.Add(sub, null);
                                break;
                            }
                            sub = otmser.Substring(start + 1, sep - (start + 1));
                            if (!oldSerFields.ContainsKey(sub))
                                oldSerFields.Add(sub, null);
                            start = sep;
                        }

                        sep = 0;
                        start = ntmser.IndexOf("=");
                        while (start < ntmser.Length)
                        {
                            sep = ntmser.IndexOf(',', start + 1);
                            if (sep == -1)//end case
                            {
                                sub = ntmser.Substring(start + 1);
                                if (!newSerFields.ContainsKey(sub))
                                    newSerFields.Add(sub, null);
                                break;
                            }
                            sub = ntmser.Substring(start + 1, sep - (start + 1));
                            if (!newSerFields.ContainsKey(sub))
                            {
                                newSerFields.Add(sub, null);
                            }
                            start = sep;
                        }

                        //compare the two hashtables to find out what's been added or removed

                        foreach (String fName in oldSerFields.Keys)
                        {
                            if (fName != "")
                            {
                                if (!newSerFields.ContainsKey(fName))
                                {
                                    int eqindex = 0;
                                    string type, name;
                                    eqindex = fName.IndexOf("(");
                                    type = fName.Substring(0, eqindex);
                                    name = fName.Substring(eqindex);
                                    removed += fName + ",<br>";
                                    unified.RemovedSerialMember(type + " " + name);
                                }
                            }
                        }
                        Console.WriteLine("type:" + otm.FullName);
                        foreach (String fName in newSerFields.Keys)
                        {
                            if (fName != "")
                            {
                                if (!oldSerFields.ContainsKey(fName))
                                {
                                    //int temp=0;
                                    int eqindex = 0;
                                    string type, name;
                                    eqindex = fName.IndexOf("(");
                                    type = fName.Substring(0, eqindex);
                                    name = fName.Substring(eqindex);
                                    added += fName + ",<br>";
                                    type = type.Replace("*)", ")");
                                    type = type.Replace("*", ",");
                                    name = name.Replace("*)", ")");
                                    name = name.Replace("*", ",");

                                    //we know this method is not marked with [ComVisible(false)]
                                    //we only add this to the report if the following conditions are met:

                                    if (!ocomvisasm) //the assembly is ComVisible(false) but the type is ComVisible(true)
                                    {
                                        if (ocomvistype)
                                            unified.AddedSerialMember(type + " " + name);
                                        Console.WriteLine("type:m:" + name);
                                    }
                                    //the assembly is ComVisible(true) and the type is ComVisible(true)
                                    //if the assembly is ComVisible(true) but the type is not, we don't mar
                                    else
                                    {
                                        if (ocomvistype)
                                            unified.AddedSerialMember(type + " " + name);
                                        Console.WriteLine("type:m:" + name);
                                    }




                                }
                            }
                        }

                        extraVal = "The structlayout signature for this type has changed. ";

                        extraVal = "<br><font color = red>" + extraVal + "</font>";
                        writeVal = extraVal;
                    }

                }


            }


            //robvi start
            //This section was added to detect structure layout breaking changes for the interop team.
            //If instance fields are added, removed, reordered, or have their offsets changed it is breaking.
            if (addStruct)
            {

                string added = "";
                string removed = "";
                string extraVal;
                int istart;
                int iend;



                if (otm.Misc.ToLower().IndexOf("structfields") >= 0 ||
                    ntm.Misc.ToLower().IndexOf("structfields") >= 0)
                {

                    istart = otm.Misc.ToLower().IndexOf("structfields");
                    iend = otm.Misc.ToLower().IndexOf(";", istart + 1);

                    if (iend < 0)
                        iend = otm.Misc.Length - 1;

                    string otmser;
                    if (istart < 0)
                        otmser = "";
                    else
                        otmser = otm.Misc.Substring(istart, iend - istart);


                    istart = ntm.Misc.ToLower().IndexOf("structfields");
                    iend = ntm.Misc.ToLower().IndexOf(";", istart + 1);

                    if (iend < 0)
                        iend = ntm.Misc.Length - 1;

                    string ntmser;
                    if (istart < 0)
                        ntmser = "";
                    else
                        ntmser = ntm.Misc.Substring(istart, iend - istart);





                    if (ntmser != otmser)
                    {

                        writeToReport = true;
                        //robvi added this to write out what's been removed or added:
                        Hashtable oldSerFields = new Hashtable();
                        Hashtable newSerFields = new Hashtable();
                        int start = otmser.IndexOf("=");
                        int sep = 0;
                        string sub;

                        while (start < otmser.Length)
                        {
                            sep = otmser.IndexOf(',', start + 1);
                            if (sep == -1)//end case
                            {
                                sub = otmser.Substring(start + 1);
                                oldSerFields.Add(sub, null);
                                break;
                            }
                            sub = otmser.Substring(start + 1, sep - (start + 1));
                            if (!oldSerFields.ContainsKey(sub))
                                oldSerFields.Add(sub, null);
                            start = sep;
                        }

                        sep = 0;
                        start = ntmser.IndexOf("=");
                        while (start < ntmser.Length)
                        {
                            sep = ntmser.IndexOf(',', start + 1);
                            if (sep == -1)//end case
                            {
                                sub = ntmser.Substring(start + 1);
                                if (!newSerFields.ContainsKey(sub))
                                    newSerFields.Add(sub, null);
                                break;
                            }
                            sub = ntmser.Substring(start + 1, sep - (start + 1));
                            if (!newSerFields.ContainsKey(sub))
                            {
                                newSerFields.Add(sub, null);
                            }
                            start = sep;
                        }

                        //compare the two hashtables to find out what's been added or removed

                        foreach (String fName in oldSerFields.Keys)
                        {
                            if (fName != "")
                            {
                                if (!newSerFields.ContainsKey(fName))
                                {
                                    int eqindex = 0;
                                    string type, name;
                                    eqindex = fName.IndexOf("=");
                                    type = fName.Substring(0, eqindex);
                                    name = fName.Substring(eqindex + 1);
                                    removed += fName + ",<br>";
                                    unified.RemovedSerialMember(type + " " + name);
                                }
                            }
                        }
                        Console.WriteLine("type:" + otm.FullName);
                        foreach (String fName in newSerFields.Keys)
                        {
                            if (fName != "")
                            {
                                if (!oldSerFields.ContainsKey(fName))
                                {
                                    int eqindex = 0;
                                    string type, name;
                                    eqindex = fName.IndexOf("=");
                                    type = fName.Substring(0, eqindex);
                                    name = fName.Substring(eqindex + 1);
                                    added += fName + ",<br>";
                                    unified.AddedSerialMember(type + " " + name);
                                }
                            }
                        }

                        extraVal = "The structlayout signature for this type has changed. ";
                        extraVal += "\nPlease review the fields for this type.";
                        extraVal = "<br><font color = red>" + extraVal + "</font>";
                        writeVal = extraVal;
                    }

                }


            }


            //Changes added for serialization field comparison 
            //Added by Robvi 09/15/2003
            if (addSer)
            {


                string extraVal;
                int istart;
                int iend;


                //Get the serfields string, comma delimited ended with a semicolon
                if (otm.Misc.ToLower().IndexOf("serfields") >= 0 &&
                    ntm.Misc.ToLower().IndexOf("serfields") >= 0)
                {

                    istart = otm.Misc.ToLower().IndexOf("serfields");
                    iend = otm.Misc.ToLower().IndexOf(";", istart + 1);

                    if (iend < 0)
                        iend = otm.Misc.Length - 1;

                    string otmser = otm.Misc.Substring(istart, iend - istart);

                    istart = ntm.Misc.ToLower().IndexOf("serfields");
                    iend = ntm.Misc.ToLower().IndexOf(";", istart + 1);

                    if (iend < 0)
                        iend = ntm.Misc.Length - 1;

                    string ntmser = ntm.Misc.Substring(istart, iend - istart);

                    string ntmtemp = ntmser.Replace("=F,", ",");
                    ntmtemp = ntmser.Replace("=T,", ",");
                    string otmtemp = otmser.Replace("=F,", ",");
                    otmtemp = otmser.Replace("=T,", ",");



                    //Check if the fields match, if anything has been added or removed it is a break
                    if (otmtemp != ntmtemp)
                    {


                        //Calculate what's been removed or added:
                        Hashtable oldSerFields = new Hashtable();
                        Hashtable newSerFields = new Hashtable();
                        int start = otmser.IndexOf("=");
                        int sep = 0;
                        string sub;

                        while (start < otmser.Length)
                        {
                            string optionalfield = "";
                            sep = otmser.IndexOf(',', start + 1);
                            if (sep == -1)//end case
                            {
                                sub = otmser.Substring(start + 1);
                                optionalfield = sub.Substring(sub.LastIndexOf("=") + 1);
                                sub = sub.Replace("=F", "");
                                sub = sub.Replace("=T", "");

                                oldSerFields.Add(sub, optionalfield);

                                break;
                            }
                            sub = otmser.Substring(start + 1, sep - (start + 1));
                            optionalfield = sub.Substring(sub.LastIndexOf("=") + 1);
                            sub = sub.Replace("=F", "");
                            sub = sub.Replace("=T", "");
                            oldSerFields.Add(sub, optionalfield);

                            start = sep;
                        }

                        sep = 0;
                        start = ntmser.IndexOf("=");
                        while (start < ntmser.Length)
                        {
                            string optionalfield = "";

                            sep = ntmser.IndexOf(',', start + 1);
                            if (sep == -1)//end case
                            {
                                sub = ntmser.Substring(start + 1);
                                optionalfield = sub.Substring(sub.LastIndexOf("=") + 1);
                                sub = sub.Replace("=F", "");
                                sub = sub.Replace("=T", "");
                                newSerFields.Add(sub, optionalfield);

                                break;
                            }
                            sub = ntmser.Substring(start + 1, sep - (start + 1));
                            optionalfield = sub.Substring(sub.LastIndexOf("=") + 1);
                            sub = sub.Replace("=F", "");
                            sub = sub.Replace("=T", "");
                            newSerFields.Add(sub, optionalfield);

                            start = sep;
                        }

                        bool breakingadd = false;
                        bool breakingremove = false;

                        //compare the two hashtables to find out what's been added or removed
                        foreach (String fName in oldSerFields.Keys)
                        {

                            //if the new hashtables doesn't have this type, it's been removed
                            if (!newSerFields.ContainsKey(fName) && fName != "")
                            {
                                string type, name;
                                int eqindex = fName.IndexOf("=");
                                type = fName.Substring(0, eqindex);
                                name = fName.Substring(eqindex + 1);

                                //add this to the unified report
                                breakingremove = true;
                                unified.RemovedSerialMember(type + " " + name);
                            }
                        }
                        foreach (String fName in newSerFields.Keys)
                        {
                            //if the old hashtables doesn't have this type, it's been added
                            if (!oldSerFields.ContainsKey(fName) && fName != "" && newSerFields[fName].ToString() != "T")
                            {
                                int eqindex = 0;
                                string type, name;
                                eqindex = fName.IndexOf("=");
                                type = fName.Substring(0, eqindex);
                                name = fName.Substring(eqindex + 1);

                                //add this to the unified report
                                breakingadd = true;
                                unified.AddedSerialMember(type + " " + name);
                            }
                        }

                        //write the change out to the report
                        if (breakingadd || breakingremove)
                        {
                            writeToReport = true;
                            extraVal = "The serialization signature for this type has changed. " +
                                "Please review the serializable fields of this type.<br>";

                            extraVal = "<br><font color = red>" + extraVal + "</font>";
                            writeVal = extraVal;
                        }
                    }

                }
                //Get the serialization details of the type
                //serializeable=X,sealed=Y,controlledSer=Z;
                //more string parsing first...

                string oserializeable, osealed, ocontrolledSer;
                string nserializeable, nsealed, ncontrolledSer;
                istart = otm.Misc.ToLower().IndexOf("serializeable=");
                iend = otm.Misc.ToLower().IndexOf(";", istart + 1);

                if (iend < 0)
                    iend = otm.Misc.Length - 1;

                string otypeser = otm.Misc.Substring(istart, iend - istart);

                istart = otypeser.IndexOf("serializeable");
                iend = otypeser.IndexOf(",", istart + 1);
                oserializeable = otypeser.Substring(istart, iend - istart);
                istart = otypeser.IndexOf("sealed");
                iend = otypeser.IndexOf(",", istart + 1);
                osealed = otypeser.Substring(istart, iend - istart);
                istart = otypeser.IndexOf("controlledSer");
                ocontrolledSer = otypeser.Substring(istart);

                istart = ntm.Misc.ToLower().IndexOf("serializeable=");
                iend = ntm.Misc.ToLower().IndexOf(";", istart + 1);

                if (iend < 0)
                    iend = ntm.Misc.Length - 1;

                string ntypeser = ntm.Misc.Substring(istart, iend - istart);


                istart = ntypeser.IndexOf("serializeable");
                iend = ntypeser.IndexOf(",", istart + 1);
                nserializeable = ntypeser.Substring(istart, iend - istart);
                istart = ntypeser.IndexOf("sealed");
                iend = ntypeser.IndexOf(",", istart + 1);
                nsealed = ntypeser.Substring(istart, iend - istart);
                istart = ntypeser.IndexOf("controlledSer");
                ncontrolledSer = ntypeser.Substring(istart);



                //This is where the comparison is done 
                //[Serializable] and not ISerializable and not Sealed must stay [Serializable]

                //[Serializable] must stay [Serializeable]
                if ((oserializeable.CompareTo("serializeable=True") == 0) && (nserializeable.CompareTo("serializeable=False") == 0))
                {
                    writeToReport = true;
                    extraVal = "The serialization signature for this type has changed. " +
                        "Serializeable type no long is serializeable.";
                    extraVal = "<br><font color = red>" + extraVal + "</font>";
                    writeVal = extraVal;
                }

                if ((oserializeable.CompareTo("serializeable=True") == 0) && (osealed.CompareTo("sealed=False") == 0) && (ocontrolledSer.CompareTo("controlledSer=False") == 0))
                {
                    if (ncontrolledSer.CompareTo("controlledSer=True") == 0)
                    {
                        writeToReport = true;
                        extraVal = "The serialization signature for this type has changed. " +
                            "Unsealed Serializeable type no longer serializeable";
                        extraVal = "<br><font color = red>" + extraVal + "</font>";
                        writeVal = extraVal;
                    }

                }

                //[Serializable] and ISerializable Must stay ISerializable
                if ((oserializeable.CompareTo("serializeable=True") == 0) && (ocontrolledSer.CompareTo("controlledSer=True") == 0))
                {
                    if (ncontrolledSer.CompareTo("controlledSer=False") == 0)
                    {
                        writeToReport = true;
                        extraVal = "The serialization signature for this type has changed. " +
                            "ISerializeable type no longer implements Iserializeable.";
                        extraVal = "<br><font color = red>" + extraVal + "</font>";
                        writeVal = extraVal;
                    }
                }



                //[Serializeable] and not ISerializeable must have new fields marked with [OptionallySerializeable] to do Whidbey M2.3

            }

            // pick the color based on type change level.
            string color = (diff == CompareResults.Breaking) ? "B0000" : "black";

            //note, ONLY use red if not 'noColor' was set
            if (noColor)
                color = "black";

            TypeMember tm = (ntm != null) ? ntm : otm;		// use the new signature, unless absent.
            string typesig = Colorize(tm.TypeFullName, color);	// "generic" short signature
            string typestring = Colorize(tm.TypeString, color);	// "generic" full signature

            string newtypesig = (ntm != null) ? Colorize(ntm.TypeString, color) : "n/a";	// specific signatures
            string oldtypesig = (otm != null) ? Colorize(otm.TypeString, color) : "n/a";

            //robvi
            if (addSer || addStruct || addStructMethod)
            {

                if (writeToReport)
                {
                    unified.WriteTypeRow(typestring, tm.TypeFullName, writeVal, null, false);
                    unified.WriteSerialMemberRow();
                }
            }
            else
            {
                if (diff == CompareResults.Same)
                {
                    unified.WriteTypeRow(typestring, tm.TypeFullName, writeVal, tm.Owners, showOwners);
                }
                else
                {
                    unified.WriteTypeRow(typesig, tm.TypeFullName, writeVal, tm.Owners, showOwners);
                    unified.WriteTypeSubRow(oldtypesig, newtypesig, alIntfcAdds, noColor);
                }
            }
        }

        // add a font color tag
        private static string Colorize(string str, string color)
        {
            return String.Format("<font color='{0}'>{1}</font>", color, str);
        }

        static String DetermineIfEnum(String textToCheck)
        {


            if (textToCheck != null && textToCheck.Length > 60 &&
                (textToCheck.Trim().ToLower().StartsWith("<font color=\"black\">field: public static const") ||
                textToCheck.Trim().ToLower().StartsWith("<font color=\"red\">field: public static const")))
            {

                String makeColor = "";

                if (textToCheck.Trim().ToLower().StartsWith("<font color=\"black\">field: public static const"))
                    makeColor = "<font color=\"black\">";
                else
                    makeColor = "<font color=\"red\">";

                //carve up the parts

                String initialString = textToCheck.Trim().Substring(60);
                String enumSpace = "";
                String enumName = "";
                String enumNameAndSpace = "";
                String enumValue = "";

                for (int i = 0; i < initialString.Length; i++)
                {
                    if (initialString.Substring(i, 2) == "\">")
                    {
                        enumSpace = initialString.Substring(0, i);
                        initialString = initialString.Substring(i + 2);
                        break;
                    }
                }

                for (int i = 0; i < initialString.Length; i++)
                {
                    if (initialString.Substring(i, 7) == "</span>")
                    {
                        enumName = initialString.Substring(0, i);
                        initialString = initialString.Substring(i + 7);
                        break;
                    }
                }

                enumNameAndSpace = enumSpace + "." + enumName;

                //now, determine if the the type is an Enum

                try
                {
                    Type t = Type.GetType(enumNameAndSpace);

                    if (t.IsEnum)
                    {

                        //parse the member for the name
                        for (int i = 0; i < initialString.Length; i++)
                        {
                            if (initialString.Substring(i, 3) == "<b>")
                            {

                                enumValue = initialString.Substring(i + 3);

                                for (int j = 0; j < enumValue.Length; j++)
                                {
                                    if (initialString.Substring(j, 4) == "</b>")
                                    {
                                        enumValue = enumValue.Substring(0, j - 4);

                                        //rewrite the output line...
                                        return makeColor + "Enum Element: " + "<span title=\"" + enumSpace + "\"</span><b>" + enumValue + "</b></font>";

                                    }
                                }

                                break;
                            }
                        }

                    }

                }
                catch { }
            }

            return textToCheck;
        }

    
        private static void GetIntfcAdds()
        {

            alIntfcAdds = new ArrayList();

            StreamReader sr = new StreamReader("reffiles\\breakIntfcAdds.txt");

            while (sr.Peek() > -1)
            {
                alIntfcAdds.Add(sr.ReadLine().Trim());
            }
        }

        private static bool DetSplit(String searchName)
        {

            if (byDll)
            {
                int i = searchName.ToLower().IndexOf(".binary.store");

                if (i >= 0)
                {
                    string temp = searchName.Substring(0, i);

                    foreach (String s in alSplitF)
                    {
                        //have to ensure that this is indeed a split by checking
                        //the input file for a numeric entry, where expected...
                        if (temp.Length >= 3)
                        {
                            if (temp.Substring(0, temp.Length - 3) ==
                                Path.GetFileNameWithoutExtension(s))
                            {

                                string sPart = temp.Substring(temp.Length - 2, 2);

                                if (Char.IsDigit(sPart, 0) && Char.IsDigit(sPart, 1))
                                {
                                    fileFound = temp.Substring(0, temp.Length - 3);
                                    splitFound = Convert.ToInt32(sPart);
                                    return true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                foreach (String s in alSplitNamespaces)
                {
                    if (searchName.ToLower().IndexOf(s.ToLower()) >= 0)
                    {
                        //have to ensure that this is indeed a split by checking
                        //the input file for a numeric entry, where expected...
                        string sPart = searchName.Substring(
                            searchName.ToLower().IndexOf(s.ToLower()) +
                            s.Length + 1, 2);

                        if (Char.IsDigit(sPart, 0) && Char.IsDigit(sPart, 1))
                        {
                            fileFound = s;
                            splitFound = Convert.ToInt32(sPart);
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static ArrayList LoadNameSpaces(String spaceName)
        {

            ArrayList spaces = new ArrayList();

            foreach (string f in Directory.GetFiles("splits", "*.split.txt"))
            {
                string temp = Path.GetFileName(f);

                if (temp.Substring(0, temp.ToLower().IndexOf(".split.txt")).ToLower() ==
                    spaceName.ToLower())
                {

                    StreamReader sr = new StreamReader(f);

                    while (sr.Peek() > -1)
                        spaces.Add(sr.ReadLine().Trim());

                    return spaces;
                }
            }

            return spaces;
        }

        private static void StoreToFile(Hashtable ht, string file, string section, string buildnum)
        {

            FileStream fs;

            try
            {
                fs = new FileStream(file, FileMode.Create);
            }
            catch
            {
                fs = new FileStream(file, FileMode.Append, FileAccess.Write);
            }

            StreamWriter sw = new StreamWriter(fs);

            try
            {
                foreach (string typememberID in ht.Keys)
                {

                    string tmid = typememberID;
                    bool written = false;

                    foreach (TypeMember tm in (ArrayList)ht[typememberID])
                    {
                        if (written == false)
                        {
                            sw.WriteLine("nt");
                            sw.WriteLine("version=" + tm.Version.ToString());
                            sw.WriteLine("tmid=" + typememberID.Trim());
                            sw.WriteLine("tmisinh=" + tm.IsInherited);
                            sw.WriteLine("tmtypnam=" + tm.TypeName);
                            sw.WriteLine("tmtypkey=" + tm.TypeKey);
                            sw.WriteLine("tmtypstr=" + tm.TypeString);
                            sw.WriteLine("tmtypshtkey=" + tm.TypeShortKey);
                            sw.WriteLine("tmtypknd=" + tm.TypeKind);
                            sw.WriteLine("tmisabstyp=" + tm.IsAbstractType);


                            //P12 Added
                            sw.WriteLine("tmisenum=" + tm.IsEnum);

                            //			    if (tm.IsEnum) {
                            //				sw.WriteLine("tmmisc=" + ((tm.Misc == null) ? "" : tm.Misc));
                            //				sw.Flush();
                            //			    }
                            //Console.WriteLine("P7");

                            //P11 Added
                            //			    sw.WriteLine("tmisenum="+tm.IsEnum);
                            written = true;
                        }

                        //P12 added
                        if (tm.IsEnum)
                        {
                            sw.WriteLine("tmmisc=" + ((tm.Misc == null) ? "" : tm.Misc));
                            sw.Flush();
                        }
                        else
                        {

                            //P11 added this entire if
                            //			if (tm.Misc == null || 
                            //					(tm.Misc != null && tm.Misc.IndexOf("ignorethiselement") < 0)) {


                            sw.WriteLine("nm");
                            sw.WriteLine("tmmemnam=" + tm.MemberName);
                            sw.WriteLine("tmmemkey=" + tm.MemberKey);
                            sw.WriteLine("tmmemshtsig=" + tm.MemberShortSig);
                            sw.WriteLine("tmmemstr=" + tm.MemberString);
                            sw.WriteLine("tmmemknd=" + tm.MemberKind);
                            sw.WriteLine("tmisabsmem=" + tm.IsAbstractMember);
                            sw.WriteLine("tmmisc=" + ((tm.Misc == null) ? "" : tm.Misc));
                            sw.WriteLine("tmnamspc=" + tm.Namespace);
                            sw.Flush();

                        }
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            fs.Close();
        }

        static Hashtable GetFromFile(string file, bool newVers)
        {

            Hashtable htTemp = new Hashtable();
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(file);

                string input = "";
                string outid = "";
                ArrayList al = new ArrayList();
                bool tmisinherit = false;
                string tmtypename = "";
                string tmtypekey = "";
                string tmtypestring = "";
                string tmtypeshortkey = "";
                string tmVersion = "";
                TypeKinds tmtypekind = 0;
                bool tmisabstracttype = false;
                bool tmisenum = false;
                string tmmisc = "";
                //		string tmname = "";
                //		string tmsig = "";

                if (newVers)
                    newVersion = "";
                else
                    oldVersion = "";

                //load each type in turn...
                while (sr.Peek() > -1)
                {
                    if (input == "")
                        input = sr.ReadLine();

                    /*
                                //if the first line begins with 'Environment =', process it!
                                if (input.StartsWith("Environment =")) {
                                    if (newVers)
                                        newVersion = input.Substring("Environment =".Length).Trim());
                                    else
                                        oldVersion = input.Substring("Environment =".Length).Trim());

                                    input = sr.ReadLine();
                                }
                    */

                    string tmid = "";

                    if (input.StartsWith("nt"))
                    {

                        //load the type info...
                        input = sr.ReadLine();
                        //if line is included for compatibility...
                        if (input.StartsWith("version="))
                        {
                            tmVersion = ProcessEntry(ref sr, "version=", "tmid=", "", ref input);
                        }

                        if (newVers)
                            newVersion = tmVersion;
                        else
                            oldVersion = tmVersion;

                        tmid = ProcessEntry(ref sr, "tmid=", "tmisinh=", "", ref input);

                        tmisinherit = Convert.ToBoolean(
                            ProcessEntry(ref sr, "tmisinh=", "tmtypnam=", "", ref input));

                        tmtypename = ProcessEntry(ref sr, "tmtypnam=", "tmtypkey=", "", ref input);
                        tmtypekey = ProcessEntry(ref sr, "tmtypkey=", "tmtypstr=", "", ref input);
                        tmtypestring = ProcessEntry(ref sr, "tmtypstr=", "tmtypshtkey=", "", ref input);
                        tmtypeshortkey = ProcessEntry(ref sr, "tmtypshtkey=", "tmtypknd=", "", ref input);
                        tmtypekind = (TypeKinds)Enum.Parse(typeof(TypeKinds),
                            ProcessEntry(ref sr, "tmtypknd=", "tmisabstyp=", "", ref input));
                        //			    tmisabstracttype = Convert.ToBoolean(
                        //				ProcessEntry(ref sr, "tmisabstyp=", "nm", "", ref input));
                        //P12 Added and Changed
                        tmisabstracttype = Convert.ToBoolean(
                            ProcessEntry(ref sr, "tmisabstyp=", "tmisenum", "", ref input));

                        tmisenum = Convert.ToBoolean(
                            ProcessEntry(ref sr, "tmisenum=", "nm", "tmmisc=", ref input));

                        if (tmisenum)
                        {
                            tmmisc = ProcessEntry(ref sr, "tmmisc=", "nt", "", ref input);
                        }

                        if (outid != tmid)
                        {
                            if (outid != "")
                            {
                                htTemp.Add(outid, al);
                                al = new ArrayList();
                            }

                            outid = tmid;
                        }
                    }

                    //P12 


                    if (tmisenum)
                    {
                        TypeMember tm = new TypeMember();
                        //				input = sr.ReadLine();
                        //				if (tmVersion.Trim() != "")
                        //					tm.Version = new Version(tmVersion);
                        tm.IsInherited = tmisinherit;
                        tm.TypeName = tmtypename;
                        tm.TypeKey = tmtypekey;
                        tm.TypeString = tmtypestring;
                        tm.TypeShortKey = tmtypeshortkey;
                        tm.TypeKind = tmtypekind;
                        tm.IsAbstractType = tmisabstracttype;
                        tm.Misc = tmmisc;
                        //				tm.MemberName = tmname;
                        //				tm.MemberShortSig = tmsig;
                        tm.IsEnum = tmisenum;
                        //				tm.MemberName = tmtypename;
                        //				tm.MemberKey = tmtypekey;
                        //				tm.MemberShortKey = tmtypeshortkey;

                        al.Add(tm);
                        //				input = sr.ReadLine();

                        // P12 stop of add
                    }
                    else if (input.StartsWith("nm"))
                    {
                        TypeMember tm = new TypeMember();

                        input = sr.ReadLine();
                        if (tmVersion.Trim() != "")
                            tm.Version = new Version(tmVersion);
                        tm.IsInherited = tmisinherit;
                        tm.TypeName = tmtypename;
                        tm.TypeKey = tmtypekey;
                        tm.TypeString = tmtypestring;
                        tm.TypeShortKey = tmtypeshortkey;
                        tm.TypeKind = tmtypekind;
                        tm.IsAbstractType = tmisabstracttype;
                        tm.IsEnum = tmisenum;

                        tm.MemberName = ProcessEntry(ref sr, "tmmemnam=", "tmmemkey=", "", ref input);
                        tm.MemberKey = ProcessEntry(ref sr, "tmmemkey=", "tmmemshtsig=", "", ref input);
                        tm.MemberShortSig = ProcessEntry(ref sr, "tmmemshtsig=", "tmmemstr=", "", ref input);
                        tm.MemberString = ProcessEntry(ref sr, "tmmemstr=", "tmmemknd=", "", ref input);
                        tm.MemberKind = (MemberTypes)Enum.Parse(typeof(MemberTypes),
                            ProcessEntry(ref sr, "tmmemknd=", "tmisabsmem=", "", ref input));
                        tm.IsAbstractMember = Convert.ToBoolean(
                            ProcessEntry(ref sr, "tmisabsmem=", "tmmisc=", "", ref input));
                        tm.Misc = ProcessEntry(ref sr, "tmmisc=", "tmnamspc=", "", ref input);
                        tm.Namespace = ProcessEntry(ref sr, "tmnamspc=", "nm", "", ref input);

                        al.Add(tm);
                    }
                }

                //just to ensure this one was added! may be duplicate
                try
                {
                    htTemp.Add(outid, al);
                }
                catch (Exception) { }

                //something's going wrong here!
                //foreach (ArrayList a in htTemp.Values)
                //Console.WriteLine(((TypeMember)(a[0])).TypeName);
                //Console.WriteLine(htTemp.Count);
                sr.Close();
                return htTemp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    if (sr != null)
                        sr.Close();
                }
                catch (Exception) { }

                return htTemp;
            }
        }

        private static string ProcessEntry(ref StreamReader sr, string thisItem, string nextItem,
            string nextItem2,
            ref string initial)
        {

            string output = "";
            string input = initial;

            if (input.StartsWith(thisItem))
            {
                output = input.Substring(thisItem.Length);

                while (true)
                {

                    input = sr.ReadLine();

                    if (input == null || input.StartsWith(nextItem)
                        || (nextItem2 != "" && input.StartsWith(nextItem2))
                        || (thisItem == "tmnamspc=" && (input == "" || input == "nt")))
                    {

                        initial = input;
                        break;
                    }
                    else
                        output += Environment.NewLine + input;
                }
            }

            return output;
        }

        //static void MakeComCompat()
        //{
        //    // we need a summary page!

        //    bool errorsExisted = false;
        //    if (outputLoc == "")
        //    {
        //        outputLoc = _oldBuild + "to" + _newBuild + "/";
        //    }

        //    StreamWriter comCompatErrors = new StreamWriter(outputLoc + "ComCompatErrors.txt");

        //    StreamWriter sw = new StreamWriter(outputLoc +
        //        "\\ComCompat.htm" + (useHTM ? "" : "l"));
        //    bool headerWritten = false;

        //    if (comDlls == null)
        //        return;

        //    foreach (string nextDll in comDlls)
        //    {

        //        ArrayList errors = null;
        //        ArrayList warnings = null;
        //        ArrayList otherDiffs = null;

        //        try
        //        {

        //            int success = ComCompat.RunComCompat(
        //                _oldBuild + Path.DirectorySeparatorChar + nextDll,
        //                _newBuild + Path.DirectorySeparatorChar + nextDll,
        //                out errors, out warnings, out otherDiffs);

        //            string errString = "";
        //            string warnString = "";
        //            string otherString = "";
        //            string totString = "";

        //            // make a new html file...
        //            if (errors != null || warnings != null || otherDiffs != null)
        //            {
        //                if (headerWritten)
        //                {
        //                    totString += "<hr>";
        //                }
        //                totString += "<b><h2>Compatibility Results for " + nextDll + "</h2></b>";
        //                if (errors != null)
        //                {
        //                    foreach (string s in errors)
        //                        errString += Environment.NewLine + "<tr><td>" + s + "</td></tr>";

        //                    if (errString.Length > 0)
        //                    {
        //                        totString += Environment.NewLine +
        //                            "<table border=1 width=800><tr><td bgcolor=\"#FF0000\"><b>Errors</b></td></tr>" +
        //                            errString + "</table><p>";
        //                    }
        //                }

        //                if (warnings != null)
        //                {
        //                    foreach (string s in warnings)
        //                        warnString += Environment.NewLine + "<tr><td>" + s + "</td></tr>";

        //                    if (warnString.Length > 0)
        //                    {
        //                        totString += Environment.NewLine +
        //                            "<table border=1 width=800><tr><td bgcolor=\"#FFFF00\"><b>Warnings</b></td></tr>" +
        //                            warnString + "</table><p>";
        //                    }
        //                }

        //                if (otherDiffs != null)
        //                {
        //                    foreach (string s in otherDiffs)
        //                        otherString += Environment.NewLine + "<tr><td>" + s + "</td></tr>";

        //                    if (otherString.Length > 0)
        //                    {
        //                        totString += Environment.NewLine +
        //                            "<table border=1 width=800><tr><td bgcolor=\"#55FF55\"><b>Other Differences</b></td></tr>" +
        //                            otherString + "</table><p>";
        //                    }
        //                }

        //                totString = "<center>" + totString + "</center>";

        //                if (!headerWritten)
        //                {
        //                    sw.WriteLine("<html><title>Com Compatibility Results</title><body>");
        //                    sw.WriteLine("<center><h1>Com Compatibility Results</h1></center>");
        //                    sw.WriteLine("<hr>");
        //                    sw.WriteLine("<p>");
        //                    sw.WriteLine("The following issues are a summary of the Com Compatability results for this comparison.");
        //                    sw.WriteLine(" If there are no items present, then no issues were found. Issues may be in one of three ");
        //                    sw.WriteLine("categories:");
        //                    sw.WriteLine("<br>");
        //                    sw.WriteLine("<center><table border = 0 width=800><tr><td>");
        //                    sw.WriteLine("<ul>");
        //                    sw.WriteLine("<li><b>Errors:</b> These are actual differences which will lead to Com Incompatibility between your assemblies");
        //                    sw.WriteLine("<li><b>Warnings:</b> These are differences which do not cause Com incompatibilty, but are major differences");
        //                    sw.WriteLine("<li><b>Other Diffs:</b> These differences may be entirely intentional, and are often a reflection of reasonable changes. They are included here for reference purposes");
        //                    sw.WriteLine("</ul>");
        //                    sw.WriteLine("</td></tr></table></center>");
        //                    sw.WriteLine("<hr><p>");
        //                    headerWritten = true;
        //                }

        //                sw.WriteLine(totString);

        //                //			groupReportComCompat.Visible = true;
        //                //			linkReportComCompat.Text = "Report for Com Compatibility Results";
        //                //			linkReportComCompat.Links.Clear();
        //                //			linkReportComCompat.Links.Add( 0,linkReportComCompat.Text.Length,
        //                //				outputLoc + "\\ComCompat.htm" + 
        //                //				(checkUseHTML.Checked ? "l" : ""));
        //                //			if ((linkReportComCompat.Links[0]).LinkData.ToString().Trim() != "")
        //                //			{
        //                //				groupReportComCompat.Visible = true;
        //                //				groupNoResults.Visible = false;
        //                //			}
        //            }
        //        } // the try
        //        catch (Exception e)
        //        {
        //            comCompatErrors.WriteLine("\r\nImport failed for Assembly {0}:, \r\n{1}\r\n",
        //                nextDll, e.ToString());
        //            errorsExisted = true;
        //        }
        //    } //END OF THE LOOP

        //    if (!headerWritten)
        //    {
        //        sw.WriteLine("<html><title>Com Compatibility Results</title><body>");
        //        sw.WriteLine("<center><h1>Com Compatibility Results</h1></center>");
        //        sw.WriteLine("<hr>");
        //        sw.WriteLine("<p>");
        //        sw.WriteLine("There were no COM Compatiblity results to report.");
        //    }

        //    sw.WriteLine("<hr></body></html>");
        //    sw.Close();

        //    if (errorsExisted)
        //    {
        //        Console.WriteLine("\r\nErrors occurred in attempting to perform a Com Compatibility comparison");
        //        Console.WriteLine("of some assemblies. Please see 'ComCompatErrors.txt' for details\r\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\r\nCom Reports Generated successfully\r\n");
        //    }
        //    comCompatErrors.Close();
        //}


        //added for ambiguous problem - we want to check if an existing overloaded method exists
        //already for the member
        private static bool IsAmbiguous(TypeMember member, ArrayList newlist)
        {
            bool isConflict = false;
            if (member.MemberKind.Equals(System.Reflection.MemberTypes.Method))
            {
                foreach (TypeMember existingmember in newlist)
                {
                    if (member.Name == existingmember.Name)
                    {
                        ArrayList oldparams, newparams;
                        oldparams = getParams(existingmember);
                        newparams = getParams(member);
                        if (oldparams.Count == newparams.Count)
                        {
                            for (int i = 0; i < newparams.Count - 1; i++)
                            {

                                if (!isRefType(newparams[i].ToString()))
                                {
                                    //we have a value type
                                    if (!isRefType(oldparams[i].ToString()))
                                    {
                                        if (newparams[i].ToString() == oldparams[i].ToString())
                                        {
                                            //continue
                                        }
                                        else
                                        {
                                            isConflict = false;
                                        }
                                    }
                                    else
                                    {
                                        isConflict = false;
                                    }
                                }
                                else
                                {
                                    //we have reference type
                                    if (newparams[i].ToString() == oldparams[i].ToString())
                                    {
                                        //do nothing
                                    }
                                    else
                                    {
                                        if (isRefType(oldparams[i].ToString()))
                                        {
                                            if (oldparams[i].ToString() == newparams[i].ToString())
                                            {
                                                isConflict = false;
                                            }
                                            else
                                            {
                                                isConflict = true;
                                                Console.WriteLine(member.TypeFullName + " " + member.Name + " " + member.Misc);
                                                Console.WriteLine("		newparams:" + newparams[i].ToString());
                                                Console.WriteLine("		oldparams:" + oldparams[i].ToString());
                                            }
                                        }
                                        else
                                        {
                                            isConflict = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return (isConflict);
        }

        private static bool isRefType(String paramname)
        {
            string assemblyname, typefullname;

            if (paramname.IndexOf(".") > -1)
            {
                //Some of the assembly names have multiple "."  e.g. System.Windows.Forms
                //we have to see if there is repitition since the assembly names and type names
                //are only "." delimited
                string temp;
                temp = paramname.Substring(0, paramname.IndexOf("."));


                if (paramname.IndexOf(temp, temp.Length) > -1)
                {
                    assemblyname = paramname.Substring(0, paramname.IndexOf(temp, temp.Length) - 1);
                    typefullname = paramname.Substring(paramname.IndexOf(temp, temp.Length));
                }
                else
                {
                    assemblyname = (paramname.Substring(0, paramname.IndexOf(".")));
                    typefullname = (paramname.Substring(paramname.IndexOf(".") + 1));
                }

                if (typefullname.IndexOf("&") > -1) //remove "out" and extra modifiers
                {
                    typefullname = typefullname.Substring(0, typefullname.IndexOf("&"));
                }
                if (typefullname.IndexOf("[") > -1) //remove "[]"
                {
                    typefullname = typefullname.Substring(0, typefullname.IndexOf("["));
                }
                if (typefullname.IndexOf(" ") > -1) //remove space
                {
                    typefullname = typefullname.Substring(0, typefullname.IndexOf(" "));
                }
                Assembly a;

                if (GACload && htGACdlls.ContainsKey(assemblyname.ToLower()))
                    a = Assembly.Load(htGACdlls[assemblyname.ToLower()].ToString());
                else
                    a = Assembly.LoadFrom(_codebase + "\\" + assemblyname + ".dll");
                Type t = a.GetType(typefullname);

                if (t.IsValueType)
                    return (false);
                else
                    return (true);
            }
            else
            {
                Console.WriteLine("Error loading assembly");
                return (false);

            }
        }

        //just a helper to get the args in a nice array
        private static ArrayList getParams(TypeMember member)
        {
            if (member.MemberShortKey.IndexOf("Parameters=") > -1)
            {
                ArrayList parameters = new ArrayList();
                String paramstoparse = member.MemberShortKey.Substring(member.MemberShortKey.IndexOf("Parameters=") + 11);
                if (paramstoparse.IndexOf(";") > -1)
                {
                    paramstoparse = paramstoparse.Substring(0, paramstoparse.IndexOf(";"));
                }
                while (paramstoparse.Length > 0)
                {
                    if (paramstoparse.IndexOf(",") > -1)
                    {
                        String remaininglist = paramstoparse.Substring(paramstoparse.IndexOf(",") + 1);
                        parameters.Add(paramstoparse.Substring(0, paramstoparse.IndexOf(",")));
                        paramstoparse = remaininglist;
                    }
                    else
                    {
                        parameters.Add(paramstoparse);
                        paramstoparse = "";
                    }
                }
                return (parameters);
            }
            return (null);
        }



        private static void MakeComList()
        {
            string[] sOrigin = Directory.GetFiles(_oldBuild, "*.dll");
            string[] sChange = Directory.GetFiles(_newBuild, "*.dll");

            bool found = false;
            comDlls = new ArrayList();

            //ONLY allow compat comparisons between dlls in both locations
            for (int i = 0; i < sOrigin.Length; i++)
            {
                for (int j = 0; j < sChange.Length; j++)
                {
                    if (Path.GetFileName(sOrigin[i]).Equals(Path.GetFileName(sChange[j])))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    comDlls.Add(Path.GetFileName(sOrigin[i]));
                }

                found = false;
            }
        }

    }
}
