using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using SigHelper;

namespace LibCheck
{
    public struct ClassInfo
    {
        public string Name { [DebuggerStepThrough] get; set; }
        public Type Type { [DebuggerStepThrough] get; set; }
        // TypeMember
        public ArrayList Members { [DebuggerStepThrough] get; set; }
        public Hashtable TypeMemberList { [DebuggerStepThrough] get; set; }

        static StringCollection nsList = new StringCollection();
        static StringCollection typesList = new StringCollection();

        static string lastFile = "";

        public override string ToString()
        {
            return String.Format("{0} members={1}", Name, Members.Count);
        }

        public static void Reset()
        {
            nsList = new StringCollection();
            typesList = new StringCollection();

            if (!String.IsNullOrWhiteSpace(lastFile) && File.Exists(lastFile))
            {
                var wr1 = new StreamWriter(lastFile, append: true);
                wr1.WriteLine("}");
                wr1.Close();
            }
            lastFile = "";
        }

        public void OutputClass(string dll, string asmName, string outputLoc)
        {
            var nsName = this.Type.Namespace;
            dll = dll ?? this.Name;
            if (dll.StartsWith("System.") && nsName.StartsWith("System.")
                && dll.LastIndexOf(".") > 10
                && nsName.StartsWith(dll.Substring(0, 10))
               )
            {
                dll = nsName.Substring(7, nsName.Length - 7);
            }
            string subdir = Path.GetFullPath(
                (outputLoc.Length == 0 ? Directory.GetCurrentDirectory() : outputLoc + @"\")
                + nsName); // .Replace(".dll", ""));

            if (!Directory.Exists(subdir))
                Directory.CreateDirectory(subdir);

            var nameClass = Type.Name;
            var reportFile = Path.GetFullPath(subdir + @"\" + nameClass + ".cs");

            if (lastFile.Length > 0 && lastFile != reportFile)
            {
                try
                {
                    var wr1 = new StreamWriter(lastFile, append: true);
                    wr1.WriteLine("}");
                    wr1.Close();
                }
                catch { }
            }
            lastFile = reportFile;

            var asm = this.Type.Assembly;

            bool isNewFile = true;
            if (!nsList.Contains(dll + @"\" + nsList))
            {
                nsList.Add(dll + @"\" + nsList);
                isNewFile = true;
            }
            else
                isNewFile = !File.Exists(reportFile);

            if (!typesList.Contains(Type.FullName))
                typesList.Add(Type.FullName);

            var wr = new StreamWriter(reportFile, append: false);
            if (isNewFile)
            {
                var attr = asm.GetCustomAttribute<System.Reflection.AssemblyFileVersionAttribute>();
                string file = "\r\n// Source:  " + asmName.Replace("file:///", "") + "  Build " + (attr != null ? attr.Version : "");
                wr.WriteLine(file);

                wr.WriteLine("using System;");
                wr.WriteLine("using System.Runtime.InteropServices;");

                wr.WriteLine("\nnamespace " + nsName + "\n{  \n");
            }
            else
            {
                wr.WriteLine("");
            }

            string[] ignoreStarting = new string[] {
                "public virtual override string ToString()"
                , "public virtual override bool Equals(object obj)"
                , "public static override bool Equals(object objA, object objB)"
                , "public static override bool ReferenceEquals(object objA, object objB)"
                , "public virtual override int GetHashCode()"
                , "public override Type GetType()"
                , "protected virtual override void Finalize()"
                , "protected override object MemberwiseClone()"
                , "public static override bool TryParse(string value, out TEnum result)"
            };

            const string indent = "   ";
            CsTypeInfo info = null;
            var allForm = TypeFormats.IncludeBaseClass | TypeFormats.IncludeInheritFlag;
            Exception LastError = null;

            try
            {
                info = new CsTypeInfo(this.Type);

                string temp = info.ToString(allForm);
                //if (temp.Contains(" : System.Object "))
                //    temp.Replace(" : System.Object ", "");
                if (temp.Contains(" " + nsName + "."))
                    temp = temp.Replace(" " + nsName + ".", " ");
                if (Type.IsEnum)
                {
                    temp = temp.Replace(": System.Enum", "");
                }
                else if (Type.IsAbstract && Type.IsSealed)
                {
                    // static
                }

                wr.WriteLine(indent + "[Guid(\"" + this.Type.GUID.ToString() + "\")]");
                wr.WriteLine(indent + temp);

                Console.WriteLine(temp);

                wr.WriteLine(indent + "{");

                foreach (TypeMember mem in this.Members)
                {
                    if (mem == null || mem.MemberInfo == null)
                        continue;

                    var temp2 = mem.MemberInfo.ToString();
                    if (temp2.Contains(" " + nsName + "."))
                        temp2 = temp2.Replace(" " + nsName + ".", " ");

                    bool isIgnore = false;
                    foreach (string ign in ignoreStarting)
                        if (temp2.StartsWith(ign)) { isIgnore = true; break; }
                    if (isIgnore)
                        continue;

                    if (temp2.Contains("`"))
                        { } // breakpoint

                    wr.WriteLine(indent + temp2);
                }

                wr.WriteLine(indent + "}");
            }
            catch (Exception ex)
            {
                LastError = ex;
            }

            wr.Close();
            GC.Collect();
        }
    }

}