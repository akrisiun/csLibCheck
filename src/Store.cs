using ChurnReports;
using ComComparer;
using SigHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibCheck
{
    public partial class LibChk
    {
        public const string Store = ".store";
        public const string extReport = ".Report";
        public const string StoreErr = ".Store.Err";

        // Create store file: LibCheck -Store (<assembly> | All]) <buildNumber>
        public static void MakeStoreFiles(string fileName = "all")
        {
            _assembly = fileName;

            ArrayList ignoreFiles = OpenFileList("reffiles\\ignorefiles.txt");

            DateTime startTime = DateTime.Now;

            bool everything = (_assembly.ToLower() == "all");

#if DOREPORTS
            string reportFile = "";
            reportFile = outputLoc + ((everything) ? "DllList" : _assembly) + "." + vers + extReport;
            reportFile = reportFile.Replace("/", "");
            reportWriter = new StreamWriter(reportFile, true);
            reportWriter.WriteLine("\r\nReport for build " + vers);
            reportWriter.WriteLine("--------------------------------------------------");
            reportWriter.WriteLine("   on {0:00}/{1:00}/{2}, {3,-2}:{4:00}:{5:00}\r\n",
                  new object[] { startTime.Month, startTime.Day, startTime.Year, 
				startTime.Hour, startTime.Minute, startTime.Second});
            reportWriter.Flush();

            string errorFile = _buildNumber + Path.DirectorySeparatorChar + ((everything) ?
              (storeSoap ? "soap" : "binary") : _assembly) + StoreErr;

            errorWriter = new StreamWriter(errorFile, false);

            errorWriter.WriteLine("{0}: created for build {1}", errorFile, vers);
            errorWriter.WriteLine("   on {0:00}/{1:00}/{2}, {3,-2}:{4:00}:{5:00}", new object[] {
				startTime.Month, startTime.Day, startTime.Year, startTime.Hour, 				startTime.Minute, startTime.Second});

            if (_dbug != 0) errorWriter.WriteLine("_dbug = " + _dbug);
#endif

            if (everything)
            {
                #region dll list

                // process all dll's in the ComPlus directory.
                ArrayList files = new ArrayList();
                string dllFullName = null;
                string storeFile = null;
                StringCollection splitStoreFiles = new StringCollection();

                foreach (string f in Directory.GetFiles(_codebase, "*.dll"))
                {
                    FileInfo fi = new FileInfo(f);
                    String file = fi.Name.ToLower();

                    if (!(ignoreFiles.Contains(file)))
                        files.Add(file);
                }

                files.Sort(Comparer.Default);

                foreach (string dllName in files)
                {
                    if (!suppress)
                        Console.WriteLine();

                    #region dlls
                    bool fileIsSplit = false;

                    foreach (String s in alSplitF)
                    {
                        if (dllName.ToLower().IndexOf(s.ToLower()) >= 0)
                        {
                            fileIsSplit = true;
                            break;
                        }
                    }

                    dllFullName = _codebase + Path.DirectorySeparatorChar + dllName;

                    bool goodToGo = GoodDllName(dllFullName);
#if DOREPORTS
                    errorWriter.WriteLine("\r\nGoodDllName({0}) = {1}", dllFullName, goodToGo);
#endif

                    if (GoodDllName(dllFullName))
                    {
                        Console.WriteLine(String.Format("// {0}) = {1}", dllFullName, goodToGo));

                        //new, for comcompat...
                        //copy the file to the output dir...
                        File.Copy(dllFullName, _buildNumber + Path.DirectorySeparatorChar + dllName, true);

                        // here is where we retrieve all the files to be 
                        // split from the input file...
                        if (fileIsSplit != true)
                        {
                            storeFile = _buildNumber + Path.DirectorySeparatorChar +
                                Path.GetFileName(dllName) +
                                (storeSoap ? ".soap" : ".binary") + Store;
                        }
                        else
                        {

                            splitStoreFiles.Clear();

                            for (int i = 1; i <= numSplits; i++)
                            {
                                splitStoreFiles.Add(_buildNumber +
                                    Path.DirectorySeparatorChar +
                                    Path.GetFileName(dllName) + "." +
                                    String.Format("{0:00}", i) +
                                    (storeSoap ? ".soap" : ".binary") + Store);
                            }
                        }

                        if (!suppress)
                            Console.WriteLine("Creating Store {0} from file {1}...", storeFile, dllName);
#if DOREPORTS
                        errorWriter.WriteLine("Creating Store {0}...", storeFile);
#endif

                        try
                        {
                            if (fileIsSplit != true)
                            {
                                CreateStore(dllFullName, storeFile, 0);
                            }
                            else
                            {
                                for (int i = 1; i <= numSplits; i++)
                                {
                                    htNamespaces = new Hashtable();
                                    CreateStore(dllFullName, splitStoreFiles[i - 1], i);
                                }
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());

#if DOREPORTS
                            errorWriter.WriteLine("\r\nException in: " + dllFullName);
                            errorWriter.WriteLine(e.ToString());
                            errorWriter.Flush();
#endif
                            continue;
                        }
                    }
#if DOREPORTS
                    errorWriter.Flush();
#endif

                    //NEW ADDITION
                    htNamespaces = new Hashtable();
                    #endregion
                }

                #endregion
            }
            else
            {
                // Process just this one assembly
                if (!suppress)
                    Console.WriteLine();

                OneAssembly(fileDir + @"\" + _assembly, fullSpec);

            }

            TimeSpan delta = DateTime.Now - startTime;
#if DOREPORTS
            errorWriter.WriteLine(String.Format("Store files created, elapsed time: {0:00}:{1:00}:{2:00}.",
          delta.Hours, delta.Minutes, delta.Seconds));
            errorWriter.Flush();
            errorWriter.Close();

            reportWriter.Flush();
            reportWriter.Close();
#endif
        } //end makestorefiles

        public static void OneAssembly(string _assembly, bool fullSpec = true)
        {
            string dllFullName = Path.GetFullPath(_assembly);
            string fileDir = Path.GetDirectoryName(dllFullName);
            string storeFile = null;
            StringCollection splitStoreFiles = new StringCollection();

            _assembly = dllFullName;
            if (!GoodAssemblyName(_assembly))
                return;
            _assembly = Path.GetFileName(dllFullName);

            Module[] ma = new Module[0];
            try
            {
                if (fullSpec)
                {
                    if (GACload && htGACdlls.ContainsKey(_assembly.ToLower()))
                    {
                        ma = Assembly.Load(htGACdlls[_assembly.ToLower()].ToString()).GetModules();
                    }
                    else
                    {
                        ma = Assembly.LoadFrom(fileDir + "\\" + _assembly).GetModules();
                    }
                    dllFullName = fileDir + "\\" + _assembly;
                }
                else
                {
                    if (GACload && htGACdlls.ContainsKey(_assembly.ToLower()))
                    {
                        ma = Assembly.Load(htGACdlls[_assembly.ToLower()].ToString()).GetModules();
                    }
                    else
                    {
                        ma = Assembly.Load(_assembly).GetModules();
                    }
                    dllFullName = "";
                }

                foreach (Module m in ma)
                {
                    string dllName = m.Name.ToLower();

                    #region Modue parse

                    //if (ignoreFiles.Contains(dllName))
                    //    continue;
                    if (!suppress)
                        Console.WriteLine();

                    bool fileIsSplit = false;

                    foreach (String s in alSplitF)
                    {
                        if (dllName.ToLower().IndexOf(s.ToLower()) >= 0)
                        {
                            fileIsSplit = true;
                            break;
                        }
                    }


                    if (dllFullName == "")
                    {

                        dllFullName = _codebase + Path.DirectorySeparatorChar + dllName;
                    }

                    //  THIS IS WHERE WE CHECK TO SEE FOR SPLIT
                    if (fileIsSplit != true)
                    {

                        storeFile = _buildNumber +
                            Path.DirectorySeparatorChar +
                            Path.GetFileName(dllName) +
                            (storeSoap ? ".soap" : ".binary") + Store;
                    }
                    else
                    {

                        splitStoreFiles.Clear();

                        for (int i = 1; i <= numSplits; i++)
                        {
                            splitStoreFiles.Add(_buildNumber +
                                Path.DirectorySeparatorChar +
                                Path.GetFileName(dllName) +
                                "." + String.Format("{0:00}", i) + (storeSoap ? ".soap" : ".binary") + Store);
                        }
                    }
                    #endregion

                    // if (!suppress)
                    // Console.WriteLine("Directory:" + m.FullyQualifiedName);
                    //Console.WriteLine("Creating Store {0} from file {1}...",
                    //    storeFile, dllName);

                    try
                    {
                        if (fileIsSplit != true || splitStoreFiles.Count == 0)
                            CreateStore(dllFullName, storeFile, 0);
                        else
                        {
                            for (int i = 1; i <= numSplits; i++)
                            {
                                htNamespaces = new Hashtable();

                                CreateStore(dllFullName, splitStoreFiles[i - 1], i);
                            }
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.ToString());
#if DOREPORTS
                                errorWriter.WriteLine("\r\nException in: " + dllFullName);
                                errorWriter.WriteLine(e.ToString());
#endif
                        continue;
                    }
                }
            }
            catch (Exception eo)
            {
                Console.WriteLine(eo.ToString());
            }

        }

        #region other methods

        // Create store file: LibCheck -Store (<assembly> | All]) <buildNumber>
        static void MakeCurrentStoreFiles(int num)
        {

            ArrayList ignoreFiles = OpenFileList("reffiles\\ignorefiles.txt");
            DateTime startTime = DateTime.Now;

#if DOREPORTS
            string reportFile = "";

            //		  reportFile = outputLoc + ((everything) ? "DllList" : _assembly) + "." + vers + ".Report";
            reportFile = outputLoc + _assembly + "." + vers + extReport;

            reportWriter = new StreamWriter(reportFile, true);
            reportWriter.WriteLine("\r\nReport for build " + vers);
            reportWriter.WriteLine("--------------------------------------------------");
            reportWriter.WriteLine("   on {0:00}/{1:00}/{2}, {3,-2}:{4:00}:{5:00}\r\n",
                  new object[] { startTime.Month, startTime.Day, startTime.Year,
				startTime.Hour, startTime.Minute, startTime.Second});
            reportWriter.Flush();

            string errorFile = _buildNumber + Path.DirectorySeparatorChar + _assembly + ".Store.Err";

            if (num < 0)
                errorWriter = new StreamWriter(errorFile, false);

            errorWriter.WriteLine("{0}: created for build {1}", errorFile, vers);
            errorWriter.WriteLine("   on {0:00}/{1:00}/{2}, {3,-2}:{4:00}:{5:00}", new object[] {
					startTime.Month, startTime.Day, startTime.Year, startTime.Hour, startTime.Minute, startTime.Second});
            if (_dbug != 0) errorWriter.WriteLine("_dbug = " + _dbug);
#endif

            string dllFullName = null;
            string storeFile = null;
            //Console.WriteLine("p1");
            //Console.ReadLine();
            if (!suppress)
                Console.WriteLine();

            if (GoodAssemblyName(_assembly))
            {
                Module[] ma = new Module[0];
                try
                {
                    if (fullSpec)
                    {
                        ma = Assembly.LoadFrom(fileDir + "\\" +
                            _assembly).GetModules();
                        dllFullName = fileDir + "\\" + _assembly;
                    }
                    else
                    {
                        ma = Assembly.Load(_assembly).GetModules();
                        dllFullName = "";
                    }

                    foreach (Module m in ma)
                    {
                        string dllName = m.Name.ToLower();

                        if (ignoreFiles.Contains(dllName))
                            continue;

                        if (!suppress)
                            Console.WriteLine();

                        if (dllFullName == "")
                        {
                            dllFullName = _codebase +
                                Path.DirectorySeparatorChar +
                                dllName;
                        }

                        if (num < 0)
                            storeFile = _buildNumber +
                                Path.DirectorySeparatorChar +
                                Path.GetFileName(dllName) +
                                (storeSoap ? ".soap" : ".binary") +
                                Store;
                        else
                            storeFile = _buildNumber +
                                Path.DirectorySeparatorChar +
                                Path.GetFileName(dllName) +
                                "." + String.Format("{0:00}", num) + ".Binary.Store";

                        if (!suppress)
                            Console.WriteLine("using {0}...", dllName);

                        try
                        {
                            if (num < 0)
                                CreateStore(dllFullName, storeFile, 0);
                            else
                                CreateStore(dllFullName, storeFile, num);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.ToString());

#if DOREPORTS
                            errorWriter.WriteLine("\r\nException in: " + dllFullName);
                            errorWriter.WriteLine(e.ToString());
#endif
                            continue;
                        }
                    }
                }
                catch (Exception eo)
                {
                    Console.WriteLine(eo.ToString());
                }
            }

#if DOREPORTS
            errorWriter.WriteLine(String.Format("Store files created"));
            errorWriter.Flush();

            reportWriter.Flush();
            reportWriter.Close();
#endif

        } //end makecurrentstorefiles

        // Test to see if reflection is going to work against the file name
        static bool GoodDllName(string dllName)
        {
            try
            {
                Assembly a = null;
                string assemblyname = dllName.Substring(dllName.LastIndexOf("\\") + 1);
                if (GACload && htGACdlls.ContainsKey(assemblyname.ToLower()))
                {
                    a = Assembly.Load(htGACdlls[assemblyname.ToLower()].ToString());
                }
                else
                {
                    a = Assembly.LoadFrom(dllName);
                }
                if (a == null)
                {
                    if (!suppress)
                    {
                        Console.WriteLine("\r\nAssembly.LoadFrom('{0}') returned null", dllName);
                    }
                    return false;
                }
                a.GetTypes();
            }
            catch (BadImageFormatException)
            {
                Console.WriteLine("\r\n{0} is not a managed assembly", dllName);

#if DOREPORTS
                errorWriter.WriteLine("GoodDllName: BadImageFormatException - (not a managed assembly)");
#endif

                return false;
            }
            catch (ReflectionTypeLoadException)
            {
                Console.WriteLine("\r\nCould not retrieve some types from {0}", dllName);
#if DOREPORTS
                errorWriter.WriteLine("GoodDllName: ReflectionTypeLoadException - (some types 'broken')");
#endif
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("\r\nException encountered reading {0}", dllName);
                Console.WriteLine("\r\n{0}", e.ToString());
#if DOREPORTS
                errorWriter.WriteLine("GoodDllName: unexpected exception!");
                errorWriter.WriteLine(e.ToString());
#endif
                return false;
            }
            return true;
        }

        // Test to see if reflection is going to work against the assembly name
        static bool GoodAssemblyName(string assembly)
        {

            try
            {
                Assembly a = null;
                if (fullSpec)
                {
                    if (GACload && htGACdlls.ContainsKey(assembly.ToLower()))
                    {
                        a = Assembly.Load(htGACdlls[assembly.ToLower()].ToString());
                    }
                    else
                    {
                        var dll = assembly;
                        if (assembly[1] != ':')
                            dll = (fileDir.Length == 0 ? "" : fileDir + "\\") + assembly;
                        a = Assembly.LoadFrom(dll);
                    }
                }
                else
                {
                    if (GACload && htGACdlls.ContainsKey(assembly.ToLower()))
                    {
                        a = Assembly.Load(htGACdlls[assembly.ToLower()].ToString());
                    }
                    else
                    {
                        a = Assembly.Load(assembly);
                    }
                }
                if (a == null)
                {
                    if (!suppress)
                    {
                        Console.WriteLine("\r\nAssembly.Load('{0}') returned null", assembly);
                    }
                    return false;
                }

                a.GetTypes();
            }
            catch (BadImageFormatException)
            {
                Console.WriteLine("\r\n{0} is not a managed assembly", assembly);
#if DOREPORTS
                errorWriter.WriteLine("GoodAssemblyName: BadImageFormatException - (not a managed assembly)");
#endif
                return false;
            }
            catch (ReflectionTypeLoadException e)
            {
                Console.WriteLine("\r\nCould not retrieve some types from {0}", assembly);
                foreach (Exception er in e.LoaderExceptions)
                {
                    Console.WriteLine(er.ToString() + "\n");
                }
#if DOREPORTS
                errorWriter.WriteLine("GoodAssemblyName: ReflectionTypeLoadException - (some types 'broken')");
#endif
                return true;
            }
            catch (Exception e)
            {
                if (e.ToString().IndexOf("was not found") >= 0)
                {
                    //assume that this is OK...
                    return false;
                }

                Console.WriteLine("\r\nException encountered reading {0}", assembly);
                Console.WriteLine("\r\n{0}", e.ToString());
#if DOREPORTS
                errorWriter.WriteLine("GoodAssemblyName: unexpected exception!");
                errorWriter.WriteLine(e.ToString());
#endif
                return false;
            }
            return true;
        }


        public static void CreateStore(string inFile, string storeName, int winformsFileNum)
        {
            //if (inFile.IndexOf("custommarshalers.dll") != -1) return;

            Assembly a = null;

            //robvi
            //12/11/2003 Breaking Change: mscorlib.dll, System.XML and possibly other future files
            //can only be loaded from the GAC in Whidbey.  The list of files that must obtained from
            //the GAC is under reffiles\gacload.txt.
            String assemblyname = inFile.Substring(inFile.LastIndexOf("\\") + 1);
            if (GACload && htGACdlls.ContainsKey(assemblyname.ToLower()))
            {
                a = Assembly.Load(htGACdlls[assemblyname.ToLower()].ToString());
            }
            else
            {
                a = Assembly.LoadFrom(inFile);
            }

            Hashtable typememberList = new Hashtable(64);   // hashtable of all members found, by full type name

            // gather members from list of modules
            if (!suppress)
            {
                Console.Write(" Assembly {0,-44} - ", inFile);
#if DOREPORTS
                errorWriter.Write(" Assembly {0,-44} - ", inFile);
#endif
            }

            int members = 0;
            int errorCount = 0;

            try
            {
                if (byDll)
                    CreateMemberListByDll(ref typememberList, a, out errorCount,
                        out members, winformsFileNum);
                else
                    CreateMemberList(ref typememberList, a, out errorCount,
                        out members, winformsFileNum);
            }
#if DOREPORTS
            catch (Exception e)
            {
                Console.WriteLine("could not load members.");
                Console.WriteLine(e.ToString());
                errorWriter.Write("could not load members of assembly ");
                try { errorWriter.WriteLine(a.GetName().Name); }
                catch { errorWriter.WriteLine("loaded from file " + inFile); }
                errorWriter.WriteLine(e.ToString());
#else
            catch (Exception e)
            {
                Console.WriteLine("could not load members.");
                Console.WriteLine(e.ToString());
#endif
                // return;
            }

            if (errorCount == 0)
            {
                if (!suppress)
                {
                    Console.WriteLine("{0,5} members", members);
#if DOREPORTS
                    errorWriter.WriteLine("{0,5} members", members);
                    reportWriter.WriteLine("{0,-70}- {1,4} types retrieved", inFile, typememberList.Count);
#endif
                }
            }
            else
            {
                if (!suppress)
                {
                    Console.WriteLine("{0,5} members, {1,2} exceptions encountered", members, errorCount);
#if DOREPORTS
                    errorWriter.WriteLine("{0,5} members, {1,2} exceptions encountered", members, errorCount);
                    reportWriter.WriteLine("{0,-70}- {1,4} types retrieved, {2,3} exceptions caught", inFile, typememberList.Count, errorCount);
#endif
                }
            }

            //write out the split files! COMPLETELY TEMPORARY, COMMENT OUT IF STILL HERE
            //ok, we want one file for each namespace, and the file contains the names of the dlls that have
            //files stored in it!
            //LEAVE THIS CODE IN HERE THOUGH
            //foreach (string sName in htNamespaces.Keys) {
            //    foreach (string sKey in ((Hashtable)htNamespaces[sName.ToLower()]).Keys) {

            //NEW STUFF...
            //no need to write out the store if I was simply populating it...
            if (_runCurrentCompare > CurrentCompare.Specific)
                return;

            #region htNamespaces

            // write the hashtable of members out to the store file
            foreach (string sName in htNamespaces.Keys)
            {

                //ok, if the attached hashtable is EMPTY, then don't persist it...
                if (((Hashtable)htNamespaces[sName.ToLower()]).Count <= 0)
                {
                    continue;
                }

                Hashtable htTemp = new Hashtable();
                string sFile = _buildNumber + "\\" +
                    sName + (storeSoap ? ".soap" : ".binary") + Store;

                /*
                            if (storeDB) {
                                htTemp = LoadList(ref sFile, "");
                            }
                            else if (File.Exists(sFile)) {
                                htTemp = LoadList(ref sFile, "");
                            }
                */
                //			if (storeDB == false && File.Exists(sFile)) {
                //				htTemp = LoadList(ref sFile, "", false); //LAST FALSE IS ARBITRARY, P1
                //			}

                //if (storeDB == false && File.Exists(sFile))
                //{
                //    //delete the file!
                //    try
                //    {
                //        File.Delete(sFile);
                //    }
                //    catch (Exception) { }
                //    //				htTemp = LoadList(ref sFile, "", false); //LAST FALSE IS ARBITRARY, P1
                //}

                foreach (string sKey in ((Hashtable)htNamespaces[sName.ToLower()]).Keys)
                {

                    try
                    {
                        htTemp.Add(sKey, ((Hashtable)htNamespaces[sName.ToLower()])[sKey]);
                    }
                    catch (Exception)
                    {
                        //DO NOTHING
                    }

                }

                //if (storeDB)
                //{
                //    rf.InsertKitType(htTemp, sFile, sName, _buildNumber);
                //}
                //else 
                //if (storeAsFile)
                //{
                //    //StoreToFile(htTemp, sFile, sName, _buildNumber);
                //}
                //else
                //                {
                //                    FileStream s = null;

                //                    try
                //                    {
                //                        s = new FileStream(sFile, FileMode.Create);

                //                        Console.Write("Serializing namespace '{0}'" +
                //                            " with the {1} formatter ... ", sName,
                //                            (storeSoap ? "soap" : "binary"));

                //                        //if (storeSoap)
                //                        //{
                //                        //    SoapFormatter sFormatter = new SoapFormatter();
                //                        //    sFormatter.Serialize(s, htTemp);
                //                        //}
                //                        //else
                //                        {
                //                            BinaryFormatter bFormatter = new BinaryFormatter();
                //                            bFormatter.Serialize(new BufferedStream(s), htTemp);
                //                        }
                //                    }
                //#if DOREPORTS
                //                    catch (Exception e)
                //                    {
                //                        Console.WriteLine(" *** serialization of memberList failed ***");
                //                        errorWriter.WriteLine("serialization to " + sName + " failed.");
                //                        errorWriter.WriteLine(e.ToString());
                //#else
                //                    catch (Exception)
                //                    {
                //                        Console.WriteLine(" *** serialization of memberList failed ***");
                //#endif
                //                    }

                //                    s.Close();
                //                }
            }

            #endregion

            if (!suppress)
                Console.WriteLine("Complete.\r\n");
        }


        // Create list of members for the store. Weed out non-public information.
        public static void CreateMemberList(ref Hashtable typememberList, Assembly a,
            out int errorCount, out int memberCount, int _winformsFile)
        {
            Hashtable problems = new Hashtable(1);  // List of problem members by full type name
                                                    //problems.Add("System.Runtime.Remoting.Channels.SMTP.ISMTPMessage", new ArrayList());
                                                    //((ArrayList)problems["System.Runtime.Remoting.Channels.SMTP.ISMTPMessage"]).AddRange(new string[] { "EnvelopeFields", "Fields", });
            errorCount = 0;
            memberCount = 0;

            string assemblyname = null;
            try { assemblyname = a.GetName().Name; }
            catch { assemblyname = "UnknownAssemblyName"; }

            Type[] ta = GetTypes(a);
            splitRanges = GetCorrectSplit(a);
            winformsFile = _winformsFile;

            IEnumerable<ClassInfo> list = EnumClassInfo(a, ta, problems, byDll);

            ClassInfo.Reset();

            foreach (ClassInfo typeData in list)
            {
                try
                {

                    typeData.OutputClass(_assembly, a.CodeBase, outputLoc);
                }
                catch (Exception ex) { Console.WriteLine("Error at " + typeData.ToString(), ex); }

#if DOREPORTS
                errorWriter.Flush();
#endif

                var t = typeData.Type;
                var memberList = typeData.Members;
                if (memberList.Count > 0)
                {   // Add member to hashtable by type.
                    memberCount += memberList.Count;
                    typememberList.Add(t.Namespace + " " + t.Name, memberList);
                }

                //PART OF THE MOD
                //we want to ADD these changes if the hashtable already existed...
                Hashtable htTemp = new Hashtable();
                if (namespaceExists)
                    htTemp = (Hashtable)htNamespaces[nameComp];

                htTemp.Add(t.Namespace + " " + t.Name, memberList);
                htNamespaces[nameComp] = htTemp;

            }

        } // end CreateMemberList

        public static Type[] GetTypes(Assembly a)
        {
            var assemblyname = a.CodeBase;
            Type[] ta = null;

            try { ta = a.GetTypes(); }  // Retrieve all types within this assembly
            catch (ReflectionTypeLoadException e)
            {
                Exception[] ea = e.LoaderExceptions;

#if DOREPORTS
                errorWriter.Write("Exceptions in Assembly.GetTypes() for " + assemblyname);

                for (int i = 0; i < ea.Length; i++)
                    errorWriter.WriteLine(String.Format(" - {0:00}: {1}", i, ea[i].ToString()));
#endif
                ta = e.Types;
            }
            catch (Exception e)
            {
                string message = "Assembly.GetTypes() failed on " + assemblyname;
                throw new ApplicationException(message, e);
            }
            return ta;
        }

        static int errorCount = 0;
        static bool namespaceExists = false;
        static string nameComp = null;
        static int winformsFile = 0;

        public static IEnumerable<ClassInfo> EnumClassInfo(Assembly a, Type[] ta, Hashtable problems = null, bool byDll = false)
        {
            // reset
            nameComp = null;
            errorCount = 0;
            namespaceExists = false;
            nameComp = null;
            if (problems == null)
                problems = new Hashtable(1);

            foreach (Type t in ta)
            {   // types loop

                // static
                namespaceExists = false;

                #region Class Data

                #region Types cycle

                bool isEnum = t.IsEnum;

                bool spaceIsSplit = false;
                int outputNumber = 0;
                nameComp = t.Namespace == null ? "generic" : t.Namespace.ToLower();

                //figure out if we need to change the name, in order to be split
                if (byDll)
                {
                    foreach (string s in alSplitF)
                    {
                        if (nameComp == s.ToLower())
                        {
                            spaceIsSplit = true;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (string s in alSplitNamespaces)
                    {
                        if (nameComp == s.ToLower())
                        {
                            spaceIsSplit = true;
                            break;
                        }
                    }
                }

                //if this is a split file, figure out which split file this type belongs to...
                if (spaceIsSplit)
                {

                    for (int i = 0; i < splitRanges.Count; i++)
                    {//(string tempString in splitRanges){

                        string tempString = splitRanges[i];
                        string startPoint = "";
                        string endPoint = "";

                        if (tempString.IndexOf(",") > 0)
                        {
                            startPoint = (tempString.Substring(0, tempString.IndexOf(",")).Trim());

                            endPoint = (tempString.Substring(tempString.IndexOf(",") + 1).Trim());
                        }
                        else
                        {
                            startPoint = tempString;
                        }

                        int compareStart = t.Name.Length < startPoint.Length ?
                            t.Name.Length : startPoint.Length;
                        int compareEnd = t.Name.Length < endPoint.Length ?
                            t.Name.Length : endPoint.Length;

                        //these are the different comparisons for the different ranges...
                        if (String.Compare(t.Name.ToLower().Substring(0,
                            compareStart), startPoint) >= 0 &&
                            String.Compare(t.Name.ToLower().Substring(0,
                            compareEnd), endPoint) <= 0 &&
                            (i != 0 && i != (numSplits - 1)))
                        {
                            outputNumber = i;
                            break;
                        }
                        else if (String.Compare(t.Name.ToLower().Substring(0,
                            compareStart), startPoint) <= 0 && i == 0)
                        {
                            outputNumber = i;
                            break;
                        }
                        else if (String.Compare(t.Name.ToLower().Substring(0,
                            compareStart), startPoint) >= 0 &&
                            i == (numSplits - 1))
                        {
                            outputNumber = i;
                            break;
                        }
                    }

                    nameComp = nameComp + "." + String.Format("{0:00}", outputNumber + 1);
                }

                foreach (string s in htNamespaces.Keys)
                {
                    if (s.ToLower() == nameComp)
                    {
                        namespaceExists = true;
                        break;
                    }
                }

                if (!namespaceExists)
                    htNamespaces.Add(nameComp, new Hashtable());

                // P1: works well, have a good set of namespaces at this point...
                //now, have to make a separate hashtable for EACH ONE, in the process below.
                //this is where we need to modify our arraylist to, instead, a hashtable, storing a namespacename, and the hashtable value!
                //for each NEW entry, add the new element to our hashtable, and ensure we instantiate the hashtable entry for it. The key //is the namespace of course!

                // this if statement, and the switch inside it, ensures that only 
                // types in certain alphabetical
                //ranges are included in a windforms output file...
                //this is done because the file is otherwise, WAY too huge!
                if (winformsFile > 0)
                {

                    //retrieve the entry from the splitRanges collection
                    //which corresponds to the winformsFIle specified
                    string tempString = splitRanges[winformsFile - 1];

                    string startPoint = "";
                    string endPoint = "";

                    if (tempString.IndexOf(",") > 0)
                    {
                        startPoint = (tempString.Substring(0, tempString.IndexOf(",")).Trim());

                        endPoint = (tempString.Substring(tempString.IndexOf(",") + 1).Trim());
                    }
                    else
                    {
                        startPoint = tempString;
                    }

                    int compareStart = t.Name.Length < startPoint.Length ?
                        t.Name.Length : startPoint.Length;
                    int compareEnd = t.Name.Length < endPoint.Length ?
                        t.Name.Length : endPoint.Length;

                    //these are the different comparisons for the different ranges...
                    if (winformsFile == 1)
                    {
                        if (String.Compare(t.Name.ToLower().Substring(0,
                            compareStart), startPoint) > 0)
                            continue;
                    }
                    else if (winformsFile == numSplits)
                    {
                        if (String.Compare(t.Name.ToLower().Substring(0,
                            compareStart), startPoint) < 0)
                            continue;
                    }
                    else
                    {
                        if (String.Compare(t.Name.ToLower().Substring(0,
                            compareStart), startPoint) < 0 ||
                            String.Compare(t.Name.ToLower().Substring(0,
                            compareEnd), endPoint) > 0)
                            continue;
                    }

                }

                if (t == null)
                {
#if DOREPORTS
                    errorWriter.WriteLine("Null type encountered in " + assemblyname);
#endif
                    errorCount++;
                    continue;
                }

                try { if (!t.IsPublic) continue; }
#if DOREPORTS
                catch (Exception e)
                {
                    errorWriter.Write("Type.IsPublic failed on type ");
                    errorWriter.WriteLine(t.FullName);
                    errorWriter.WriteLine(e.ToString());
#else
                catch (Exception)
                {
#endif
                    errorCount++;
                    continue;
                }

                MemberInfo[] ma = null;
                var name = t.FullName;

                // FileNotFoundException members black list
                if (name == "Microsoft.DotNet.Tools.Restore.RestoreCommand"
                    || name.StartsWith("Microsoft.DotNet.Tools.Restore.")
                    || name.StartsWith("Microsoft.DotNet.Tools.Publish.") // PublishCommand
                    || name.StartsWith("Microsoft.DotNet.Tools.Compiler.PackageGenerator")
                    || name.StartsWith("Microsoft.DotNet.ProjectModel.Resolution.PackageDependencyProvider")
                   )
                {
                    continue;
                }

                // Retrieve all members of each "class"
                try { ma = t.GetMembers(allBindingsLookup | System.Reflection.BindingFlags.FlattenHierarchy); }
#if DOREPORTS
                catch (System.IO.FileNotFoundException e) { errorWriter.WriteLine(e.ToString()); }
                catch (Exception e)
                {
                    errorWriter.Write("Type.GetMembers() failed on type ");
                    errorWriter.WriteLine(t.FullName);
                    errorWriter.WriteLine(e.ToString());
#else
                catch (Exception)
                {
#endif
                    errorCount++;
                    continue;
                }

#if DOREPORTS
                if (_dbug > 0) errorWriter.WriteLine("  - Type: {0,-48} - {1:000} members", t.FullName, ma.Length);
#endif
                #endregion

                ArrayList memberList = new ArrayList(ma.Length);

                foreach (MemberInfo mi in ma)
                {   // members loop

                    if (problems.ContainsKey(t.FullName) && ((ArrayList)problems[t.FullName]).Contains(mi.Name))
                    {
#if DOREPORTS
                        if (_dbug > 0) errorWriter.WriteLine("    -- Skipping member " + mi.Name);
#endif
                        continue;
                    }
#if DOREPORTS
                    if (_dbug > 0) errorWriter.WriteLine("    -- Member: {0}", mi.Name);
#endif

                    try
                    {
                        #region Parse Member

                        // Ignore non-public, non-family methods and constructors. Also ignore property accessors, event methods and cctor's.
                        if (mi is MethodBase)
                        {
                            if (!((MethodBase)mi).IsPublic && !((MethodBase)mi).IsFamily)
                                continue;
                            if (((MethodBase)mi).IsSpecialName && (
                                mi.Name.StartsWith("get_")
                                || mi.Name.StartsWith("set_")
                                || mi.Name.StartsWith("add_")
                                || mi.Name.StartsWith("remove_")
                                || mi.Name.StartsWith("op_")    // TODO: Add operators back in once GenMemberInfo can compare operators.
                                ))
                                continue;
                            if ((mi is ConstructorInfo) && (mi.Name == ".cctor"))
                                continue;
                        }

                        // Ignore non-public, non-family fields
                        if (mi is FieldInfo && !(((FieldInfo)mi).IsPublic || ((FieldInfo)mi).IsFamily))
                            continue;

                        // Ignore non-public, non-family events (add/remove method is non-public, non-family)
                        if (mi is EventInfo && !(((EventInfo)mi).GetAddMethod(true).IsPublic || ((EventInfo)mi).GetAddMethod(true).IsFamily))
                            continue;

                        // Ignore non-public, non-family properties (both getter and setter are non-public, non-family)
                        if (mi is PropertyInfo && !(
                            (((PropertyInfo)mi).GetGetMethod(true) != null &&
                            (((PropertyInfo)mi).GetGetMethod(true).IsPublic || ((PropertyInfo)mi).GetGetMethod(true).IsFamily)) ||
                            (((PropertyInfo)mi).GetSetMethod(true) != null &&
                            (((PropertyInfo)mi).GetSetMethod(true).IsPublic || ((PropertyInfo)mi).GetSetMethod(true).IsFamily))
                            ))
                            continue;

                        // Ignore non-public, non-family nested types
                        if (mi is Type && !(((Type)mi).IsNestedPublic || ((Type)mi).IsNestedFamily))
                            continue;

                        // For inherited members, only report ones that are not otherwise hidden
                        if (mi.DeclaringType != mi.ReflectedType)
                        {
                            #region othersMembers

                            MemberInfo[] others = t.GetMember(mi.Name, mi.MemberType,
                                allBindingsLookup);

                            if (others.Length == 0)
                            {
                                //                                Console.WriteLine("Reflection error on {0} {1}.", t.FullName, mi.Name);
                                //#if DOREPORTS
                                //                                errorWriter.WriteLine("Type.GetMember({0}, {1}, BindingFlags.LookupAll) returned an empty list for {2}",
                                //                                mi.Name, mi.MemberType, t.FullName);
                                //#endif
                            }
                            else if (others.Length == 1 && others[0] != mi)
                            {
                                //                                Console.WriteLine("Reflection error on {0} {1}.", t.FullName, mi.Name);
                                //#if DOREPORTS
                                //                                errorWriter.WriteLine("Type.GetMember({0}, {1}, BindingFlags.LookupAll) returned a single, non-matching member for {2}",
                                //                                    mi.Name, mi.MemberType, t.FullName);
                                //#endif
                            }
                            else
                            {
                                bool good = true;
                                foreach (MemberInfo other in others)
                                {
                                    // Filter loop
                                    if (mi.DeclaringType.IsAssignableFrom(other.DeclaringType) && other != mi)
                                    {
                                        switch (mi.MemberType)
                                        {
                                            case MemberTypes.Constructor:
                                            case MemberTypes.Method:
                                                if (GenParameterInfo.PSig((MethodBase)mi) == GenParameterInfo.PSig((MethodBase)other))
                                                    good = false;
                                                break;
                                            case MemberTypes.Property:
                                                if (GenParameterInfo.PSig(((PropertyInfo)mi).GetIndexParameters())
                                                    == GenParameterInfo.PSig(((PropertyInfo)mi).GetIndexParameters()))
                                                    good = false;
                                                break;
                                            case MemberTypes.Event:
                                            case MemberTypes.Field:
                                            case MemberTypes.NestedType:
                                                good = false;
                                                break;
                                            default:
                                                //#if DOREPORTS
                                                //                                                errorWriter.WriteLine("Error MemberInfo.MemberType = '{0}' for {1}.{2}",
                                                //                                                           ((Enum)mi.MemberType).ToString(), t.FullName, mi.Name);
                                                //#endif

                                                break;
                                        }
                                        if (!good) break;                   // if member unwanted, exit Filter loop
                                    }
                                }

                                // ignore "hidden" members, skip to next member info.
                                if (!good) continue;
                            }

                            #endregion
                        }

                        // ignore the value__ field on Enum's
                        if (mi.Name == "value__" && (t.Equals(Type.GetType("System.Enum")) ||
                            t.IsSubclassOf(Type.GetType("System.Enum"))))
                            continue;

                        #endregion
                    }
#if DOREPORTS
                    catch (Exception eA)
                    {
                        errorWriter.Write("Exception encounterd while working on member ");
                        errorWriter.Write(t.FullName + " ");
                        errorWriter.WriteLine(mi.ToString());
                        errorWriter.WriteLine(eA.ToString());
#else
                    catch (Exception)
                    {
#endif
                        errorCount++;
                        continue;
                    }

                    // convert memberinfos to typemembers
                    TypeMember tm = null;
                    Exception lastError = null;

                    try
                    {
#if DOREPORTS
                        if (mi == null) errorWriter.WriteLine("mi == null");
#endif

                        // Generate new TypeMember
                        tm = new TypeMember(mi, t, addSer, isEnum, addStruct, addStructMethod, obsoletewriter);

                    }
#if DOREPORTS
                    catch (Exception e)
                    {
                        errorWriter.Write("TypeMember construction failed on member ");
                        errorWriter.Write(t.FullName + " ");
                        try { errorWriter.WriteLine(mi.ToString()); }
                        catch { errorWriter.WriteLine("UnknownMember"); }
                        errorWriter.WriteLine(e.ToString());
                        lastError = e;
#else
                    catch (Exception)
                    {
#endif
                        errorCount++;
                    }

                    if (lastError != null)
                        continue;

                    // Add member to list for this type
                    memberList.Add(tm);

                    //P12 Added
                    //if this is an enum, then we only add ONE entry
                    if (isEnum)
                        break;


                } // end members loop

                memberList.TrimToSize();

                #endregion

                var typeData = new ClassInfo
                {
                    Name = t.Namespace + "." + t.Name,
                    Type = t,
                    Members = memberList,
                    TypeMemberList = null
                };

                yield return typeData;

            } // end types loop
        }

        // Create list of members for the store. Weed out non-public information.
        public static void CreateMemberListByDll(ref Hashtable typememberList, Assembly a,
            out int errorCount, out int memberCount, int winformsFile)
        {

            Hashtable problems = new Hashtable(1);  // List of problem members by full type name
            problems.Add("System.Runtime.Remoting.Channels.SMTP.ISMTPMessage", new ArrayList());
            ((ArrayList)problems["System.Runtime.Remoting.Channels.SMTP.ISMTPMessage"]).AddRange(new string[] { "EnvelopeFields", "Fields", });

            string asmFile = a.CodeBase;

            #region Init

            errorCount = 0;
            memberCount = 0;
            Type[] ta = null;

            string assemblyname = null;
            try { assemblyname = a.GetName().Name; }
            catch { assemblyname = "UnknownAssemblyName"; }

            try { ta = a.GetTypes(); }  // Retrieve all types within this assembly
            catch (ReflectionTypeLoadException e)
            {
                Exception[] ea = e.LoaderExceptions;
#if DOREPORTS
                errorWriter.Write("Exceptions in Assembly.GetTypes() for " + assemblyname);
                for (int i = 0; i < ea.Length; i++)
                    errorWriter.WriteLine(String.Format(" - {0:00}: {1}", i, ea[i].ToString()));
#endif
                ta = e.Types;
            }
            catch (Exception e)
            {
                string message = "Assembly.GetTypes() failed on " + assemblyname;
                throw new ApplicationException(message, e);
            }

            splitRanges = GetCorrectSplit(a);
            #endregion

            ClassInfo.Reset();

            foreach (Type t in ta)
            {   // types loop

                #region Types loop

                if (!ht.Contains(t.FullName))
                {
                    ht.Add(t.FullName, null);

                }


                if (t != null)
                {
                    //P12, based on this info, set a bool
                    //Console.WriteLine("p1");
                    //			if (t.IsEnum)
                    //Console.WriteLine(t.FullName);
                    bool isEnum = t.IsEnum;


                    //ranges are included in a windforms output file...
                    //this is done because the file is otherwise, WAY too huge!
                    if (winformsFile > 0)
                    {

                        //retrieve the entry from the splitRanges collection
                        //which corresponds to the winformsFIle specified

                        string tempString = splitRanges[winformsFile - 1];

                        string startPoint = "";
                        string endPoint = "";

                        if (tempString.IndexOf(",") > 0)
                        {
                            startPoint = (tempString.Substring(0, tempString.IndexOf(",")).Trim());

                            endPoint = (tempString.Substring(tempString.IndexOf(",") + 1).Trim());
                        }
                        else
                        {
                            startPoint = tempString;
                        }

                        int compareStart = t.Name.Length < startPoint.Length ?
                            t.Name.Length : startPoint.Length;
                        int compareEnd = t.Name.Length < endPoint.Length ?
                            t.Name.Length : endPoint.Length;

                        //these are the different comparisons for the different ranges...
                        if (winformsFile == 1)
                        {
                            if (String.Compare(t.Name.ToLower().Substring(0,
                                compareStart), startPoint) > 0)
                                continue;
                        }
                        else if (winformsFile == numSplits)
                        {
                            if (String.Compare(t.Name.ToLower().Substring(0,
                                compareStart), startPoint) < 0)
                                continue;
                        }
                        else
                        {
                            if (String.Compare(t.Name.ToLower().Substring(0,
                                compareStart), startPoint) < 0 ||
                                String.Compare(t.Name.ToLower().Substring(0,
                                compareEnd), endPoint) > 0)
                                continue;
                        }

                    }

                    if (t == null)
                    {
#if DOREPORTS
                        errorWriter.WriteLine("Null type encountered in " + assemblyname);
#endif
                        errorCount++;
                        continue;
                    }

                    try
                    {
                        //if we're doing serialization check we add everything regardless of visibility
                        if (addSer == false)
                        {
                            if (!t.IsPublic) continue;
                        }
                    }
#if DOREPORTS
                    catch (Exception e)
                    {
                        errorWriter.Write("Type.IsPublic failed on type ");
                        errorWriter.WriteLine(t.FullName);
                        errorWriter.WriteLine(e.ToString());
#else
                    catch (Exception)
                    {
#endif
                        errorCount++;
                        continue;
                    }

                    //				if(t.IsEnum && t.IsPublic)
                    //				{
                    //					Console.WriteLine("\n" + "ENUM:" + t.FullName);
                    //					totalEnumCount++;
                    //				}

                    MemberInfo[] ma = null;

                    //P12
                    // based on whether you decided it was an enum, make a very specific typemember, JUST for enum!


                    // Retrieve all members of each "class"
                    try { ma = t.GetMembers(allBindingsLookup); }
#if DOREPORTS
                    catch (Exception e)
                    {
                        errorWriter.Write("Type.GetMembers() failed on type ");
                        errorWriter.WriteLine(t.FullName);
                        errorWriter.WriteLine(e.ToString());
#else
                    catch (Exception)
                    {
#endif
                        errorCount++;
                        continue;
                    }

                    #endregion


                    // Header
                    string header = "";
                    CsTypeInfo cs = null;
                    try
                    {
                        cs = new CsTypeInfo((Type)t);
                        header = cs.ToString(TypeFormats.IncludeBaseClass | TypeFormats.IncludeInheritFlag)
                            + " \n{";
                    }
                    catch { }
                    if (header != null)
                        Console.WriteLine(header);

                    ArrayList memberList = new ArrayList(ma.Length);

                    foreach (MemberInfo mi in ma)
                    {
                        #region Members loop

                        if (problems.ContainsKey(t.FullName) && ((ArrayList)problems[t.FullName]).Contains(mi.Name))
                        {
#if DOREPORTS
                            if (_dbug > 0) errorWriter.WriteLine("    -- Skipping member " + mi.Name);
#endif
                            continue;
                        }
#if DOREPORTS
                        if (_dbug > 0) errorWriter.WriteLine("    -- Member: {0}", mi.Name);
#endif

                        try
                        {
                            #region Member info parse

                            // Ignore non-public, non-family methods and constructors. Also ignore property accessors, event methods and cctor's.
                            if (mi is MethodBase)
                            {
                                //robvi we want to grab protected internal methods too
                                //if ( !((MethodBase)mi).IsPublic && !((MethodBase)mi).IsFamily )
                                if (!((MethodBase)mi).IsPublic && !((MethodBase)mi).IsFamily && !((MethodBase)mi).IsFamilyOrAssembly)
                                {
                                    continue;
                                }
                                if (((MethodBase)mi).IsSpecialName && (
                                    mi.Name.StartsWith("get_")
                                    || mi.Name.StartsWith("set_")
                                    || mi.Name.StartsWith("add_")
                                    || mi.Name.StartsWith("remove_")
                                    || mi.Name.StartsWith("op_")    // TODO: Add operators back in once GenMemberInfo can compare operators.
                                    ))
                                    continue;

                                if ((mi is ConstructorInfo) && (mi.Name == ".cctor"))
                                {
                                    continue;
                                }

                            }

                            // Ignore non-public, non-family fields
                            // Robvi:  we only ignore these fields if the layout is not explicit or sequential

                            //if (mi is FieldInfo && !( ((FieldInfo) mi).IsPublic || ((FieldInfo) mi).IsFamily ) && !t.IsLayoutSequential && !t.IsExplicitLayout)
                            if (mi is FieldInfo && !(((FieldInfo)mi).IsPublic || ((FieldInfo)mi).IsFamily))
                                continue;

                            // Ignore non-public, non-family events (add/remove method is non-public, non-family)
                            if (mi is EventInfo && !(((EventInfo)mi).GetAddMethod(true).IsPublic || ((EventInfo)mi).GetAddMethod(true).IsFamily))
                                continue;

                            // robvi FamilyOrAssembly is considered family
                            // Ignore non-public, non-family properties (both getter and setter are non-public, non-family)
                            //	if ((mi is PropertyInfo) && mi.Name.Equals("RenderRightToLeft"))
                            //	{Console.WriteLine("foo" + "\n");}

                            if (mi is PropertyInfo && !(
                                (
                                ((PropertyInfo)mi).GetGetMethod(true) != null &&
                                (((PropertyInfo)mi).GetGetMethod(true).IsPublic || ((PropertyInfo)mi).GetGetMethod(true).IsFamily || ((PropertyInfo)mi).GetGetMethod(true).IsFamilyOrAssembly)
                                )
                                ||
                                (
                                ((PropertyInfo)mi).GetSetMethod(true) != null &&
                                (((PropertyInfo)mi).GetSetMethod(true).IsPublic || ((PropertyInfo)mi).GetSetMethod(true).IsFamily || ((PropertyInfo)mi).GetSetMethod(true).IsFamilyOrAssembly)
                                ))
                                )
                                continue;

                            // Ignore non-public, non-family nested types
                            if (mi is Type && !(((Type)mi).IsNestedPublic || ((Type)mi).IsNestedFamily))
                                continue;

                            // For inherited members, only report ones that are not otherwise hidden
                            if (mi.DeclaringType != mi.ReflectedType)
                            {

                                MemberInfo[] others = t.GetMember(mi.Name, mi.MemberType,
                                    allBindingsLookup);

                                if (others.Length == 0)
                                {
                                    Console.WriteLine("Reflection error on {0} {1}.", t.FullName, mi.Name);
#if DOREPORTS
                                    errorWriter.WriteLine("Type.GetMember({0}, {1}, BindingFlags.LookupAll) returned an empty list for {2}",
                                      mi.Name, mi.MemberType, t.FullName);
#endif
                                }
                                else if (others.Length == 1 && others[0] != mi)
                                {
                                    Console.WriteLine("Reflection error on {0} {1}.", t.FullName, mi.Name);
#if DOREPORTS
                                    errorWriter.WriteLine("Type.GetMember({0}, {1}, BindingFlags.LookupAll) returned a single, non-matching member for {2}",
                                      mi.Name, mi.MemberType, t.FullName);
#endif
                                }
                                else
                                {
                                    bool good = true;
                                    foreach (MemberInfo other in others)
                                    {       // Filter loop
                                        if (mi.DeclaringType.IsAssignableFrom(other.DeclaringType) && other != mi)
                                        {
                                            switch (mi.MemberType)
                                            {
                                                case MemberTypes.Constructor:
                                                case MemberTypes.Method:
                                                    if (GenParameterInfo.PSig((MethodBase)mi) == GenParameterInfo.PSig((MethodBase)other))
                                                        good = false;
                                                    break;
                                                case MemberTypes.Property:
                                                    if (GenParameterInfo.PSig(((PropertyInfo)mi).GetIndexParameters()) == GenParameterInfo.PSig(((PropertyInfo)mi).GetIndexParameters()))
                                                        good = false;
                                                    break;
                                                case MemberTypes.Event:
                                                case MemberTypes.Field:
                                                case MemberTypes.NestedType:
                                                    good = false;
                                                    break;
                                                default:
#if DOREPORTS
                                                    errorWriter.WriteLine("Error MemberInfo.MemberType = '{0}' for {1}.{2}",
                                                                ((Enum)mi.MemberType).ToString(), t.FullName, mi.Name);
#endif

                                                    break;
                                            }
                                            if (!good) break;                   // if member unwanted, exit Filter loop
                                        }
                                    }

                                    // ignore "hidden" members, skip to next member info.
                                    if (!good) continue;
                                }
                            }

                            #endregion

                            // ignore the value__ field on Enum's
                            if (mi.Name == "value__" && (t.Equals(Type.GetType("System.Enum")) ||
                                t.IsSubclassOf(Type.GetType("System.Enum"))))
                                continue;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        // convert memberinfos to typemembers

                        TypeMember tm = null;
                        Exception lastError = null;
                        try
                        {
#if DOREPORTS
                            if (mi == null) errorWriter.WriteLine("mi == null");
#endif
                            // Generate new TypeMember

                            tm = new TypeMember(mi, t, addSer, isEnum, addStruct, addStructMethod, obsoletewriter);

                            //robvi:check if we have one a single private constructor with no parameters
                            //add this to the shortkey, the reason for doing this here is that this is the
                            //only time we parse through the private types
                            ConstructorInfo[] constructors = t.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                            if (constructors.Length == 1)
                            {
                                ConstructorInfo singlector = constructors[0];
                                if (singlector.IsPrivate && singlector.GetParameters().Length == 0)
                                {
                                    tm.TypeKey += ":SingleCtor=T";
                                }
                            }
                            else
                                tm.TypeKey += ":SingleCtor=F";

                            MemberInfo[] mems = t.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                            string stat = ":AllStatic=F";
                            if (mems.Length == 1)
                            {
                                if (mems[0].Name == ".ctor")
                                {
                                    stat = ":AllStatic=T";
                                }
                            }
                            tm.TypeKey += stat;

                        }
                        catch (Exception e)
                        {
#if DOREPORTS
                            errorWriter.Write("TypeMember construction failed on member ");
                            errorWriter.Write(t.FullName + " ");
                            try { errorWriter.WriteLine(mi.ToString()); }
                            catch { errorWriter.WriteLine("UnknownMember"); }
                            errorWriter.WriteLine(e.ToString());
#endif
                            Console.WriteLine(e.Message);
                            errorCount++;
                            lastError = e;
                        }
                        #endregion

                        if (lastError != null || tm == null)
                            continue;

                        // Add member to list for this type
                        memberList.Add(tm);

                        // P12 Added
                        // if this is an enum, then we only add ONE entry
                        if (isEnum)
                            break;

                    } // end members loop

                    memberList.TrimToSize();

                    var typeData = new ClassInfo
                    {
                        Name = t.Namespace + "." + t.Name,
                        Type = t,
                        Members = memberList,
                        TypeMemberList = typememberList
                    };

                    typeData.OutputClass(_assembly, asmFile, outputLoc);

                    if (memberList.Count > 0)
                    {   // Add member to hashtable by type.
                        memberCount += memberList.Count;
                        //robvi try catch
                        try
                        {
                            typememberList.Add(t.Namespace + " " + t.Name, memberList);
                        }
                        catch (Exception) { }
                    }
#if DOREPORTS
                    errorWriter.Flush();
#endif

                } // end types loop


                // header end
                Console.WriteLine("}");

                //copy them across...
                string output = "";
                output += Path.GetFileNameWithoutExtension(a.CodeBase).ToLower();
                if (winformsFile > 0)
                    output += "." + String.Format("{0:00}", winformsFile);
                //			output += "." + winformsFile;

                htNamespaces = new Hashtable();
                htNamespaces.Add(output, typememberList);
                //PART OF THE MOD
                //we want to ADD these changes if the hashtable already existed... 

            } //end if (t!=null)

        } // end CreateMemberListByDll

        // Create difference reports: LibCheck -Compare <oldNumber> <newNumber>
        static void MakeReports()
        {

            int totAdds = 0;
            int totBreaks = 0;
            int totRemoves = 0;
            int totTotal = 0;
            //int totTypeAdds = 0;
            //int totTypeRemoves = 0;
            //int totSerTypeBreaks = 0;


            //A DUMMY VARIABLE AT THE MOMENT
            bool itemsAdded = false;

            //first thing is to define the compare file output location...
            //only set it to this default value if the user has not specified a location...
            if (outputLoc == "")
                outputLoc = _oldBuild + "to" + _newBuild + "/";

            try
            {
                //attempt to create the specified directory.
                Directory.CreateDirectory(outputLoc);

                //also, create the 'api_change' directory, as a subdir

                Directory.CreateDirectory(outputLoc + "api_change");

                //create the compat, and non_compat directories...
                Directory.CreateDirectory(outputLoc + "Compat");
                Directory.CreateDirectory(outputLoc + "NonCompat");
            }
            catch { }

            //POINT2
            if (addsOnly)
            {


                AddsFile = new StreamWriter(outputLoc + "Results." + (useHTM ? "htm" : "html"));

                AddsFile.WriteLine("<html><Head></head>\r\n<body>\r\n");
                AddsFile.WriteLine("<center><h1>Summary Change Report, Adds Only</h1></center><hr>");
            }

            //            xmlReport = new XmlReport(outputLoc);

            //#if DOREPORTS
            //            xmlReport = new XmlReport(outputLoc);
            //#endif

            string oldDir = _oldBuild + Path.DirectorySeparatorChar;
            string newDir = _newBuild + Path.DirectorySeparatorChar;

            // initialize the error report
            DateTime startTime = DateTime.Now;
            string errFile = String.Format(outputLoc +
                "LibCheck.{0:00}{1:00}.{2:00}{3:00}.error",
                new object[] { startTime.Month, startTime.Day, startTime.Hour, startTime.Minute });
#if DOREPORTS
            errorWriter = new StreamWriter(errFile);
            if (_dbug != 0) errorWriter.WriteLine("_dbug = " + _dbug);
#endif

            // create and initialize the summary html report.
            //		summary = new ChurnReport(_oldBuild, _newBuild);
            if (addSer)
            {
                summary = new ChurnReport(_oldBuild, _newBuild, outputLoc, false,
                    incHeader, sumColor, allDetails, noLink, useHTM, makeComReport, true);
            }
            else if (addStruct || addStructMethod)
            {
                summary = new ChurnReport(_oldBuild, _newBuild, outputLoc, false,
                    incHeader, sumColor, allDetails, noLink, useHTM, makeComReport, true, true);
            }
            else
            {
                summary = new ChurnReport(_oldBuild, _newBuild, outputLoc, showChurn,
                    incHeader, sumColor, allDetails, noLink, useHTM, makeComReport);
            }

            // Get a list of all store files (old and new). Capitalization may be different
            ArrayList files = null;

            //if (storeDB)
            //{
            //    files = rf.GetDistinctFiles(_oldBuild);

            //    ArrayList tempAl = rf.GetDistinctFiles(_newBuild);

            //    foreach (string s in tempAl)
            //        if (!files.Contains(s))
            //            files.Add(s);
            //}
            //else
            {
                files = new ArrayList();

                foreach (string f in Directory.GetFiles(oldDir, "*.store"))
                {
                    files.Add(Path.GetFileName(f.ToLower()));
                }

                foreach (string f in Directory.GetFiles(newDir, "*.store"))
                {
                    if (!files.Contains(Path.GetFileName(f.ToLower())))
                    {

                        files.Add(Path.GetFileName(f.ToLower()));
                    }
                }
            }

            files.Sort(Comparer.Default);

            //here is where we begin the process of creating the output from the store FILES

            bool fileIsSplit = false;
            bool fileAlreadyBegun = false;
            ArrayList alreadyProcessed = new ArrayList();

            // Load and compare Store files
            foreach (string f in files)
            {

                bool exitLoop = false;

                foreach (string s in alreadyProcessed)
                {
                    if (s.ToLower() == f.ToLower())
                    {
                        exitLoop = true;
                        break;
                    }
                }

                if (exitLoop)
                    continue;

                bool lastFile = false;

                if (fileIsSplit == false)
                {
                    totAdds = 0;
                    totTotal = 0;
                    totRemoves = 0;
                    totBreaks = 0;
                    //totTypeAdds = 0;
                    //totTypeRemoves = 0;
                    //totSerTypeBreaks = 0;


                    //fileIsSplit = DetSplit(f);
                }


                if (fileIsSplit)
                {
                    bool getNext = false;
                    bool doneLoop = false;

                    //look at the NEXT file, and determine
                    foreach (string s in files)
                    {

                        doneLoop = false;

                        if (getNext)
                        {
                            // fileFound is the name of the last file being processed, short
                            // splitFound is the number of the split file found
                            string sPart = s.Substring(
                                s.ToLower().IndexOf(fileFound.ToLower()) +
                                fileFound.Length + 1, 2);

                            if (Char.IsDigit(sPart, 0) && Char.IsDigit(sPart, 1))
                            {
                                if (Convert.ToInt32(sPart) <= splitFound)
                                    lastFile = true;
                            }
                            else
                                lastFile = true;

                            break;
                        }

                        if (f == s)
                        {
                            getNext = true;
                            doneLoop = true;
                        }
                    }

                    //indicates that the file IS split, and there is no 'next' item
                    if (doneLoop)
                        lastFile = true;
                }

                string origVal = Path.GetFileName(f);

                string newName = newDir + origVal;
                string oldName = oldDir + origVal;

                try
                {
                    //if this is a split file, change the name of the assembly!
                    string assembly = null;

                    //this works because getfilename simply works with strings!
                    //if (storeDB)
                    //{
                    //    assembly = Path.GetFileName(f);
                    //    if (assembly.IndexOf(".binary.store") >= 0)
                    //        assembly =
                    //            assembly.Substring(0, assembly.IndexOf(".binary.store"));
                    //    if (assembly.IndexOf(".soap.store") >= 0)
                    //        assembly =
                    //            assembly.Substring(0, assembly.IndexOf(".soap.store"));
                    //}
                    //else
                    {
                        assembly = Trim(f);
                    }

                    string assembly2 = assembly;

                    if (fileIsSplit)
                    {
                        //the four is determined from the fact that the end of the name will
                        //be '.XX', where xx is the filenum.
                        assembly2 = assembly.Substring(0, assembly.Length - 3);
                    }

                    //only do this if this is either the first time for a split file,
                    //OR the file is not split...
                    //                    if (fileIsSplit == false || fileAlreadyBegun == false)
                    //                    {
                    //                        xmlReport.WriteStartAssembly(Path.GetFileName(assembly),
                    //                            _oldBuild, _newBuild);


                    //#if DOREPORTS
                    //                        xmlReport.WriteStartAssembly(Path.GetFileName(assembly),
                    //                          _oldBuild, _newBuild);
                    //#endif
                    //                    }

                    Hashtable oldList = new Hashtable();

                    if (!suppress)
                    {
                        Console.Write("\r\nLoading Store {0} via the {1} formatter ...",
                            oldName, (storeSoap ? "soap" : "binary"));
                    }


                    oldList = LoadList(ref oldName, oldDir, false);

                    if (oldList != null)
                    {
                        if (!suppress)
                            Console.WriteLine(" {0} types.", oldList.Count);
                    }

                    if (oldList.Count == 0)
                    {
                        if (lastFile == false)
                        {
                            if (!suppress)
                            {
                                Console.WriteLine(
                                    "The oldstore had zero entries, all entries will be marked as added...");
                            }
                        }
                    }

                    Hashtable newList = null;

                    // Get the typemember hashtable from the new store file, which may not exist.
                    if (!suppress)
                    {
                        Console.Write("Loading Store {0} via the {1} formatter ...",
                            newName, (storeSoap ? "soap" : "binary"));
                    }

                    newList = LoadList(ref newName, newDir, true);

                    if (newList != null)
                    {
                        if (!suppress)
                        {
                            Console.WriteLine(" {0} types.", newList.Count);
                        }
                    }

                    if (newList.Count == 0 && lastFile == false)
                    {
                        if (!suppress)
                        {
                            Console.WriteLine(
                                "The newstore had zero entries, all entries will be marked as removed...");
                        }
                    }

                    if (oldList == null || newList == null)
                        throw new Exception("Error loading Store files, usage:" + usage);
#if DOREPORTS
                    errorWriter.WriteLine(String.Format(
                          "\r\nStore '{0}', {1} types.\r\nStore '{2}', {3} types.",
                          new object[] { oldName, oldList.Count, newName, newList.Count }));
#endif

                    if (oldList.Count + newList.Count == 0 && lastFile == false)
                        continue;

                    if (fileIsSplit == false)
                    {
                        if (allDetails)
                        {
                            if (unified == null)
                                unified = new UnifiedReport(_oldBuild,
                                    _newBuild, assembly,
                                    outputLoc + "\\api_change\\",
                                    oldVersion, newVersion,
                                    allDetails, useHTM);
                        }
                        else
                        {
                            unified = new UnifiedReport(_oldBuild,
                                _newBuild, assembly,
                                outputLoc + "\\api_change\\",
                                oldVersion, newVersion,
                                allDetails, useHTM);
                        }
                    }
                    else if (fileAlreadyBegun == false)
                    {
                        //figure out what the output file name IS
                        if (allDetails)
                        {
                            if (unified == null)
                                unified = new UnifiedReport(_oldBuild,
                                    _newBuild, assembly2,
                                    outputLoc + "\\api_change\\",
                                    oldVersion, newVersion,
                                    allDetails, useHTM);
                        }
                        else
                        {
                            unified = new UnifiedReport(_oldBuild,
                                _newBuild, assembly2,
                                outputLoc + "\\api_change\\",
                                oldVersion, newVersion,
                                allDetails, useHTM);
                        }
                    }

                    // calculate total members and breaking changes and write 
                    // detail reports for this assembly.
                    // note that only ONE line should be written for split reports, so keep
                    // a running tally for these...
                    //int added, removed,typesAdded, typesRemoved, total, breaking, serialBreaking;

                    //int added, removed, typesAdded, typesRemoved, total, breaking;
                    //Report(oldList, newList, assembly2, out added, out removed, out typesAdded, out typesRemoved,
                    //    out total, out breaking, ref itemsAdded);

                    //totAdds += added;
                    //totRemoves += removed;
                    //totTotal += total;
                    //totBreaks += breaking;
                    //totTypeAdds += typesAdded;
                    //totTypeRemoves += typesRemoved;

                    //robvi for serialization we only care if there are breaking changes
                    if (addSer || addStruct || addStructMethod)
                    {
                        totAdds = 0;
                        totRemoves = 0;
                    }

                    //DELETE the report, if there are no changes
                    if ((fileIsSplit == false) || lastFile)
                    {
                        if ((totAdds + totRemoves + totBreaks) <= 0)
                        {
                            try
                            {
                                //delete the file
                                if (allDetails == false)
                                {
                                    if (unified != null)
                                        unified.Close(useHTM);

                                    File.Delete(outputLoc + "api_change\\"
                                        + assembly2 + ".Unified." +
                                        (useHTM ? "htm" : "html"));
                                    unified = null;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("An error occurred deleting the file:");
                                Console.WriteLine(outputLoc + "\\api_change\\"
                                    + assembly2 + ".Unified." +
                                    (useHTM ? "htm" : "html"));
                                Console.WriteLine(e.ToString());
                            }
                        }
                    }

#if DOREPORTS
                    xmlReport.AssemblyCompat(breaking == 0, _newBuild);
#endif

                    //if (fileIsSplit == false || fileAlreadyBegun == false)
                    //{
                    //    xmlReport.AssemblyCompat(breaking == 0, _newBuild);
                    //    if (breaking == 0)
                    //    {
                    //        File.Create(outputLoc + "\\Compat\\" + assembly2 + ".compat");
                    //    }
                    //    else
                    //    {
                    //        File.Create(outputLoc + "\\NonCompat\\" + assembly2 + ".noncompat");
                    //    }
                    //}

                    // write summary line out to summary report, echo summary to console.
                    bool aAdded = oldName.EndsWith("NotFound");
                    bool aRemoved = newName.EndsWith("NotFound");

                    if ((fileIsSplit == false) || lastFile)
                    {

                        //robvi if/else
                        if (!addSer && !addStruct && !addStructMethod)
                        {
                            if (!suppress)
                            {

                                Console.WriteLine(summary.WriteRow(assembly2,
                                    aAdded, aRemoved,
                                    totAdds, totRemoves, totTotal,
                                    totBreaks, allDetails,
                                    sumAll, useHTM));

                            }
                            else
                            {

                                summary.WriteRow(assembly2, aAdded, aRemoved,
                                    totAdds, totRemoves, totTotal,
                                    totBreaks, allDetails, sumAll, useHTM);

                            }
                        }
                        else
                        {
                            if (totBreaks != 0)
                            {
                                summary.WriteRow(assembly2, aAdded, aRemoved,
                                    totAdds, totRemoves, totTotal,
                                    totBreaks, allDetails, sumAll, useHTM);
                            }
                        }
                        int change = totAdds + totRemoves;
                        int asm1Count = oldList.Count;
                        int asm2Count = newList.Count;
                        //	xmlReport.WriteAssemblySummary(totTypeAdds.ToString(), totTypeRemoves.ToString(),asm1Count.ToString(), asm2Count.ToString());
                    }
                }
#if DOREPORTS
                catch (Exception e)
                {
                    Console.WriteLine("Error comparing files: {0}, {1}", oldName, newName);
                    errorWriter.WriteLine("Error comparing files: {0}, {1}", oldName, newName);
                    errorWriter.WriteLine(e.ToString());
#else
                catch (Exception e)
                {

                    Console.WriteLine("Error comparing files: {0}, {1}", oldName, newName);
                    Console.WriteLine(e.ToString());
#endif
                }
                finally
                {
                    if ((fileIsSplit == false) || lastFile)
                    {

                        //                        xmlReport.WriteEndAssembly(oldVersion, newVersion);
                        //#if DOREPORTS
                        //                        xmlReport.WriteEndAssembly(oldVersion, newVersion);
                        //#endif

                        if (unified != null)
                        {
                            if (allDetails == false)
                                unified.Close(useHTM);
                        }

                        fileAlreadyBegun = false;
                        fileIsSplit = false;
                    }
                    else
                    {
                        fileAlreadyBegun = true;
                    }
                }
            }

            TimeSpan delta = DateTime.Now - startTime;
#if DOREPORTS
            errorWriter.WriteLine(String.Format("Report completed, total elapsed time: {0:00}:{1:00}:{2:00}.",
            delta.Hours, delta.Minutes, delta.Seconds));

            errorWriter.Flush();
            errorWriter.Close();
#endif

            //xmlReport.Dispose();
#if DOREPORTS
            xmlReport.Dispose();
#endif

            summary.Close(allDetails, noLink, showChurn, useHTM);

            //POINT3
            if (addsOnly)
            {
                if (itemsAdded == false)
                {
                    AddsFile.WriteLine("<br><center><h2><font color=\"blue\">" +
                        "Nothing to Report</h2></center><hr>");
                }

                AddsFile.WriteLine("</body></html>");
                AddsFile.Flush();
                AddsFile.Close();
            }

        } //end makereports


        //ALWAYS ASSUMES THAT THE COMPARISON IS CURRENT TO BUILD "X"
        static void MakeCurrentReport()
        {
            int totAdds = 0;
            int totBreaks = 0;
            int totRemoves = 0;
            int totTotal = 0;

            bool itemsAdded = false;

            //first thing is to define the compare file output location...
            //only set it to this default value if the user has not specified a location...
            if (outputLoc == "")
            {
                if ((_runCurrentCompare & CurrentCompare.Old) == CurrentCompare.Old)
                    outputLoc = "currentto";
                else
                    outputLoc = _oldBuild + "to";

                if ((_runCurrentCompare & CurrentCompare.New) == CurrentCompare.New)
                    outputLoc += "current" + "/";
                else
                    outputLoc += _newBuild + "/";
            }

            try
            {
                //attempt to create the specified directory.
                Directory.CreateDirectory(outputLoc);


                //also, create the 'api_change' directory, as a subdir

                Directory.CreateDirectory(outputLoc + "api_change");

                //create the compat, and non_compat directories...
                Directory.CreateDirectory(outputLoc + "\\Compat");
                Directory.CreateDirectory(outputLoc + "\\NonCompat");
            }
            catch { }

            //POINT2
            if (addsOnly)
            {

                AddsFile = new StreamWriter(outputLoc + "Results." + (useHTM ? "htm" : "html"));

                AddsFile.WriteLine("<html><Head></head>\r\n<body>\r\n");
                AddsFile.WriteLine("<center><h1>Summary Change Report, Adds Only</h1></center><hr>");
            }

            //            xmlReport = new XmlReport(outputLoc);
            //#if DOREPORTS
            //            xmlReport = new XmlReport(outputLoc);
            //#endif

            string newDir = _newBuild + Path.DirectorySeparatorChar;
            string oldDir = _oldBuild + Path.DirectorySeparatorChar;

            // initialize the error report
            DateTime startTime = DateTime.Now;
            string errFile = String.Format(outputLoc +
                "LibCheck.{0:00}{1:00}.{2:00}{3:00}.error",
                new object[] { startTime.Month, startTime.Day, startTime.Hour,
                                 startTime.Minute });
#if DOREPORTS
            errorWriter = new StreamWriter(errFile);
            if (_dbug != 0) errorWriter.WriteLine("_dbug = " + _dbug);
#endif

            // create and initialize the summary html report.
            summary = new ChurnReport(_oldBuild, _newBuild, outputLoc,
                showChurn, incHeader, sumColor, allDetails, noLink, useHTM, makeComReport);

            // Get a list of all store files (old and new). Capitalization may be different
            ArrayList files = new ArrayList();
            //NO LONGER VALID, NEED TO RETRIEVE APPROP FILES AS YOU GO!
            //	    foreach (string f in Directory.GetFiles(oldDir, "*.Store"))
            //		files.Add(Path.GetFileName (f.ToLower()));

            //ONLY DO IF NOT USING DB!
            if (storeDB == false)
            {
                if ((_runCurrentCompare & CurrentCompare.Old) == CurrentCompare.Old)
                {
                    foreach (string f in Directory.GetFiles(newDir, "*.store"))
                    {
                        if (!files.Contains(Path.GetFileName(f.ToLower())))
                            files.Add(Path.GetFileName(f.ToLower()));
                    }
                }
                else
                {
                    foreach (string f in Directory.GetFiles(oldDir, "*.store"))
                    {
                        if (!files.Contains(Path.GetFileName(f.ToLower())))
                            files.Add(Path.GetFileName(f.ToLower()));
                    }
                }
            }
            else
            {
                //get the filenames from the DB...
                //ArrayList al = null;
                //if ((_runCurrentCompare & CurrentCompare.Old) == CurrentCompare.Old)
                //    al = rf.GetDistinctFiles(_newBuild);
                //else
                //    al = rf.GetDistinctFiles(_oldBuild);

                //foreach (string f in al)
                //{
                //    if (!files.Contains(Path.GetFileName(f.ToLower())))
                //        files.Add(Path.GetFileName(f.ToLower()));
                //}
            }

            files.Sort(Comparer.Default);

            bool fileIsSplit = false;
            bool fileAlreadyBegun = false;
            ArrayList alreadyProcessed = new ArrayList();
            bool ignoreItems = false;

            // Load and compare Store files
            foreach (string f in files)
            {

                bool exitLoop = false;

                foreach (string s in alreadyProcessed)
                {
                    if (s.ToLower() == f.ToLower())
                    {
                        exitLoop = true;
                        break;
                    }
                }

                if (exitLoop)
                    continue;

                bool lastFile = false;

                if (fileIsSplit == false)
                {
                    totAdds = 0;
                    totTotal = 0;
                    totRemoves = 0;
                    totBreaks = 0;

                    //fileIsSplit = DetSplit(f);
                }


                //TEMP: Never say a file is split if doing a current compare...
                //if (_runCurrentCompare > CurrentCompare.Specific)
                //	fileIsSplit = false;
                //END TEMP, only applies to that one line. For the mean time, this means files will never be consolidated
                //FROM THIS CHANGE, code may be commented out at the moment...

                //WAS /*

                if (fileIsSplit)
                {
                    bool getNext = false;
                    bool doneLoop = false;

                    //look at the NEXT file, and determine
                    foreach (string s in files)
                    {

                        doneLoop = false;

                        if (getNext)
                        {
                            // fileFound is the name of the last file being processed
                            // splitFound is the number of the split file found
                            string sPart = s.Substring(
                                s.ToLower().IndexOf(fileFound.ToLower()) +
                                fileFound.Length + 1, 2);

                            if (Char.IsDigit(sPart, 0) && Char.IsDigit(sPart, 1))
                            {
                                if (Convert.ToInt32(sPart) <= splitFound)
                                    lastFile = true;
                            }
                            else
                                lastFile = true;

                            break;
                        }

                        if (f == s)
                        {
                            getNext = true;
                            doneLoop = true;
                        }
                    }

                    //indicates that the file IS split, and there is no 'next' item
                    if (doneLoop)
                        lastFile = true;
                }

                //WAS */

                string origVal = Path.GetFileName(f);

                string newName = newDir + origVal;
                string oldName = oldDir + origVal;

                try
                {
                    //if this is a split file, change the name of the assembly!
                    string assembly = Trim(f);
                    string assembly2 = assembly;

                    //the four is determined from the fact that the end of the name will
                    //be '.XX', where xx is the filenum.
                    if (fileIsSplit)
                        assembly2 = assembly.Substring(0, assembly.Length - 3);

                    //only do this if this is either the first time for a split file,
                    //OR the file is not split...
                    //                    if (fileIsSplit == false || fileAlreadyBegun == false)
                    //                    {
                    //                        xmlReport.WriteStartAssembly(Path.GetFileName(assembly),
                    //                            _oldBuild, _newBuild);
                    //#if DOREPORTS
                    //                        xmlReport.WriteStartAssembly(Path.GetFileName(assembly),
                    //                          _oldBuild, _newBuild);
                    //#endif
                    //                    }

                    Hashtable oldList = new Hashtable();

                    if (!suppress)
                        Console.Write("\r\nLoading Current Items ...");

                    //THIS IS WHERE YOU NEED TO LOAD THE CURRENT LIST!
                    //To do this, use the current system, and pass in the namespace you want to retrieve...
                    //have a file which has the dlls that have entries from that namespace in it!
                    //			oldList = LoadList(ref oldName, oldDir, false);

                    string namespaceName = f.Substring(0,
                        f.ToLower().IndexOf((storeSoap ? ".soap" : ".binary") + Store));

                    //figure out now if it has a number on the end, in which case it's split...
                    int lastPos = namespaceName.LastIndexOf(".");
                    int num = -1;

                    if (lastPos >= 0 && lastPos != (namespaceName.Length - 1))
                    {
                        string possNum = namespaceName.Substring(lastPos + 1);

                        try
                        {
                            num = Convert.ToInt32(possNum);
                        }
                        catch { }

                        if (num >= 0)
                            namespaceName = namespaceName.Substring(0, lastPos);
                    }

                    // based on the namespace name, load the approp split file to determine dll to load
                    //			ArrayList dlls = LoadNameSpaces(namespaceName);

                    //IT WILL HAVE TO KNOW WHERE THESE COME FROM!!! SO IT WILL HAVE A LOCATION, HARDCODED AT THIS POINT
                    //assume the currently running location...
                    if ((_runCurrentCompare & CurrentCompare.Old) == CurrentCompare.Old)
                    {
                        //Console.WriteLine("p1");
                        //Console.ReadLine();
                        oldList = LoadSpecificList(_codebase, namespaceName, num);
                        //if (oldList == null)
                        //	Console.WriteLine("yup!");
                        //Console.WriteLine("p2");
                        //Console.ReadLine();
                    }
                    else
                    {
                        oldList = LoadList(ref oldName, oldDir, false);
                    }

                    if (oldList != null)
                    {
                        if (!suppress)
                        {
                            Console.WriteLine(" {0} types.", oldList.Count);
                        }
                    }
                    else
                    {
                        //ASSUME this means zero entries...
                        oldList = new Hashtable();
                    }

                    if (oldList.Count == 0)
                    {

                        if (lastFile == false)
                        {
                            if (!suppress)
                            {
                                Console.WriteLine(
                                    "The current items had zero entries, " +
                                    "all entries will be marked as added...");
                            }
                        }
                    }

                    Hashtable newList = null;

                    // Get the typemember hashtable from the new store file, which may not exist.
                    if (!suppress)
                        Console.Write("Loading Store {0}  ...", newName);

                    if ((_runCurrentCompare & CurrentCompare.New) == CurrentCompare.New)
                        newList = LoadSpecificList(_codebase, namespaceName, num);
                    else
                        newList = LoadList(ref newName, newDir, true);

                    if (newList != null)
                    {
                        if (!suppress)
                        {
                            Console.WriteLine(" {0} types.", newList.Count);
                        }
                    }

                    if (newList.Count == 0 && lastFile == false)
                    {
                        if (!suppress)
                        {
                            Console.WriteLine(
                                "The newstore had zero entries, " +
                                "all entries will be marked as removed...");
                        }
                    }

                    if (oldList == null || newList == null)
                        throw new Exception("Error loading Store files, usage:" + usage);

                    if (oldList.Count + newList.Count == 0 && lastFile == false)
                        continue;

                    if (fileIsSplit == false)
                    {

                        if (allDetails)
                        {
                            if (unified == null)
                                unified = new UnifiedReport(_oldBuild, _newBuild, assembly,
                                    outputLoc + "\\api_change\\", oldVersion, newVersion,
                                    allDetails, useHTM);
                        }
                        else
                        {
                            unified = new UnifiedReport(_oldBuild, _newBuild, assembly,
                                outputLoc + "api_change\\", oldVersion, newVersion,
                                allDetails, useHTM);
                        }
                    }
                    else if (fileAlreadyBegun == false)
                    {
                        //figure out what the output file name IS
                        if (allDetails)
                        {
                            if (unified == null)
                                unified = new UnifiedReport(_oldBuild, _newBuild, assembly2,
                                    outputLoc + "\\api_change\\", oldVersion, newVersion,
                                    allDetails, useHTM);
                        }
                        else
                        {
                            unified = new UnifiedReport(_oldBuild, _newBuild, assembly2,
                                outputLoc + "\\api_change\\", oldVersion, newVersion,
                                allDetails, useHTM);
                        }
                    }

                    //int added, removed, total, breaking, typesAdded, typesRemoved;
                    //POINT1
                    //Report(oldList, newList, assembly2, out added, out removed, out typesAdded, out typesRemoved,
                    //    out total, out breaking, ref itemsAdded);

                    //totAdds += added;
                    //totRemoves += removed;
                    //totTotal += total;
                    //totBreaks += breaking;

                    //DELETE the report, if there are no changes
                    if ((fileIsSplit == false) || lastFile)
                    {
                        if ((totAdds + totRemoves + totBreaks) <= 0)
                        {
                            try
                            {
                                //delete the file
                                if (allDetails == false)
                                {
                                    if (unified != null)
                                        unified.Close(useHTM);

                                    File.Delete(outputLoc + "api_change\\"
                                        + assembly2 + ".Unified." +
                                        (useHTM ? "htm" : "html"));
                                    unified = null;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Error occurred deleting the file:");
                                Console.WriteLine(outputLoc + "\\api_change\\"
                                    + assembly2 + ".Unified." +
                                    (useHTM ? "htm" : "html"));
                                Console.WriteLine(e.ToString());
                            }
                        }
                    }

#if DOREPORTS
                    xmlReport.AssemblyCompat(breaking == 0, _newBuild);
#endif

                    //if (fileIsSplit == false || fileAlreadyBegun == false)
                    //{
                    //    xmlReport.AssemblyCompat(breaking == 0, _newBuild);

                    //    if (breaking == 0)
                    //        File.Create(outputLoc + "\\Compat\\" + assembly2 + ".compat");
                    //    else
                    //        File.Create(outputLoc + "\\NonCompat\\" + assembly2 + ".noncompat");
                    //}

                    // write summary line out to summary report, echo summary to console.
                    bool aRemoved = newName.EndsWith("NotFound");

                    if ((fileIsSplit == false) || lastFile)
                    {
                        //robvi 
                        if (!addSer && !addStruct && !addStructMethod)
                        {
                            if (!suppress)
                            {
                                Console.WriteLine(summary.WriteRow(assembly2, false,
                                    aRemoved, totAdds, totRemoves,
                                    totTotal, totBreaks, allDetails,
                                    sumAll, useHTM));
                            }
                            else
                            {
                                summary.WriteRow(assembly2, false, aRemoved,
                                    totAdds, totRemoves, totTotal, totBreaks,
                                    allDetails, sumAll, useHTM);

                            }
                        }
                        //robvi when it's a serial report we just report type breaks per assembly
                        else
                        {
                            if (totBreaks != 0)
                            {
                                summary.WriteRow(assembly2, false, aRemoved,
                                    totAdds, totRemoves, totTotal, totBreaks,
                                    allDetails, sumAll, useHTM);
                            }

                        }



                    }
                }
#if DOREPORTS
                catch (Exception e)
                {
                    errorWriter.WriteLine(e.ToString());
#else
                catch (Exception)
                {
#endif
                }
                finally
                {
                    //this is the boolean that gets set because multiple beta1
                    // classes are being amalgamated into one beta2 class
                    if (ignoreItems)
                        ignoreItems = false;

                    if ((fileIsSplit == false) || lastFile)
                    {

                        //                        xmlReport.WriteEndAssembly(oldVersion, newVersion);
                        //#if DOREPORTS
                        //                        xmlReport.WriteEndAssembly(oldVersion, newVersion);
                        //#endif

                        if (unified != null)
                            if (allDetails == false)
                                unified.Close(useHTM);

                        fileAlreadyBegun = false;
                        fileIsSplit = false;
                    }
                    else
                    {
                        fileAlreadyBegun = true;
                    }
                }
            }

            //POINT3
            if (addsOnly)
            {
                if (itemsAdded == false)
                {
                    AddsFile.WriteLine("<br><center><h2><font color=\"blue\">" +
                        "Nothing to Report</h2></center><hr>");
                }

                AddsFile.WriteLine("</body></html>");
                AddsFile.Flush();
                AddsFile.Close();
            }
        } //end makecurrentreport

        // load a store given a file name (predictive, can request one that doesn't exist)
        public static Hashtable LoadSpecificList(string location, string space, int num)
        {

            bool prevSpec = fullSpec;

            fullSpec = true;
            fileDir = location;
            //need to set the name of the _assembly object to the approp dll...

            _assembly = space + ".dll";

            MakeCurrentStoreFiles(num);
            //Console.WriteLine("p2");
            //Console.ReadLine();
            fullSpec = prevSpec;

            //if doing this, there will only ever be ONE ENTRY...
            //return that entry since it is itself a hashtable
            if (num < 0)
                return (Hashtable)(htNamespaces[space.ToLower()]);
            else
                return (Hashtable)(htNamespaces[(space + "." +
                    String.Format("{0:00}", num)).ToLower()]);

            //	return (Hashtable)(htNamespaces[(space + "." + num).ToLower()]);
        }

        // load a store given a file name (predictive, can request one that doesn't exist)
        public static Hashtable LoadList(ref string name, string dir, bool newVers)
        {

            //if (storeDB)
            //{
            //    return rf.GetKitType(name);
            //}
            //else if (storeAsFile)
            //{
            //    return GetFromFile(name, newVers);
            //}
            //else
            {
                try
                {

                    FileStream s2 = new FileStream(name, FileMode.Open, FileAccess.Read, FileShare.Read);
                    DateTime t = DateTime.Now;

                    if (!suppress)
                    {
                        Console.WriteLine("Starting Deserialize: {0}", t);
                    }

                    Hashtable result;

                    //if (storeSoap)
                    //{
                    //    SoapFormatter sFormatter = new SoapFormatter();
                    //    result = (Hashtable)sFormatter.Deserialize(s2);
                    //}
                    //else
                    {
                        BinaryFormatter bFormatter = new BinaryFormatter();
                        result = (Hashtable)bFormatter.Deserialize(s2);
                    }

                    if (!suppress)
                        Console.WriteLine("Finished Deserialize: {0}", DateTime.Now - t);

                    s2.Close();

                    return result;
                }
#if DOREPORTS
                catch (FileNotFoundException e)
                {
                    errorWriter.WriteLine("Could not find store file, " + name);
                    errorWriter.WriteLine(e.ToString());
#else
                catch (FileNotFoundException)
                {
#endif
                    name = dir + "NotFound";
                    return new Hashtable(0);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Could not load store file, " + name);
                    Console.WriteLine(e.ToString());
#if DOREPORTS
                    errorWriter.WriteLine("Could not load store file, " + name);
                    errorWriter.WriteLine(e.ToString());
#endif
                    return null;
                }
            }
        }

        // returns the assembly given a file name of a certain format.
        static string Trim(string s)
        {
            int index = s.LastIndexOf(".");
            s = s.Remove(index, s.Length - index);
            index = s.LastIndexOf(".");
            s = s.Remove(index, s.Length - index);

            return s;
        }

        #endregion

    }

}