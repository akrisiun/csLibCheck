using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibCheck;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitDnx1
    {
        [TestMethod]
        public void Test_Dotnet1_IO()
        {
            UnitTest1.Prepare();
            var args = new[] 
             { // "-debug", 
                "-file",
              (@"c:\Program Files (x86)\dotnet\bin\") + "System.IO.*.dll",
                "-out", @"..\sample\src\dotnet\" 
             };

            LibChk.Main(args);

            var lastError = LibChk.LastError;
            var list = LibChk.ClassList;
            var listAsm = LibChk.AsmList;
        }

        // ..\dnx\
        [TestMethod]
        public void Test_Dnx()
        {
            UnitTest1.Prepare();
            var args = new[] 
             { // "-debug", 
                "-file",
                Path.GetFullPath(@"..\dnx\") + "System.*",
                "-out", @"sample\src\System\" 
             };

            //args[1] = "C:" + Environment.GetEnvironmentVariable("HOMEPATH") + @"\"
            // .nuget\packages\System.Runtime\4.1.0-rc2-24103\lib\net462\System.Runtime.dll

            LibChk.Main(args);

            var lastError = LibChk.LastError;
            var list = LibChk.ClassList;
            var listAsm = LibChk.AsmList;

            var args1 = "C:" + Environment.GetEnvironmentVariable("HOMEPATH") + @"\"
                + @".nuget\packages\System.Runtime\4.1.0-rc2-24008\ref\netstandard1.3\System.Runtime.dll";
            Assembly a = null;
            try { a = Assembly.LoadFrom(args1); }
            catch { }
            var t1 = a.GetTypes();
            var t2 = a.GetExportedTypes();
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFile_SystemData()
        {
            Prepare();
            var args = new[] { // "libcheck.exe", "-debug", 
                    "-file",
                    @"c:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Data.dll",
                    "-out", "Data1" };

            LibChk.Main(args);
        }


        public string dllData
        {
            [DebuggerStepThrough]
            get
            {
                var vars = Environment.GetEnvironmentVariables();
                var dll = Environment.GetEnvironmentVariable("windir") + @"\Microsoft.NET\Framework\v4.0.30319\System.Data.dll";
                return dll;
            }
        }

        public static void Prepare()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var newDir = Path.GetFullPath(dir + @"\..\..\..\..\bin");
            Directory.SetCurrentDirectory(newDir);
            Assert.IsTrue(Directory.Exists("RefFiles"));
            if (!LibChk.IsPrepared)
                LibChk.Prepare();

            LibChk.outputLoc = newDir;
        }

        [TestMethod]
        public void Test_SystemData()
        {
            Prepare();
            // file:///C:/WINDOWS/Microsoft.Net/assembly/GAC_32/System.Data/v4.0_4.0.0.0__b77a5c561934e089/System.Data.dll
            var dll = this.dllData;
            LibChk.OneAssembly(dll);
        }

        [TestMethod]
        public void Test_SystemData_IDb()
        {
            Prepare();
            var a = Assembly.LoadFrom(dllData);

            Type[] ta = LibChk.GetTypes(a);

            IEnumerable<ClassInfo> list = LibChk.EnumClassInfo(a, ta, null, false);
            var first = list.Where(i => i.Name.StartsWith("System.Data.IDbConnection", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

            LibChk.ClassList.Add(first);
            ClassInfo.Reset();

            first.OutputClass(dllData, first.Name, @"\");
            ClassInfo.Reset();

        }

        [TestMethod]
        public void Test_SystemData_IDb2()
        {
            Prepare();
            var dll = dllData;
            var a = Assembly.LoadFrom(dllData);

            Type[] ta = LibChk.GetTypes(a);
            Type type = ta.Where(t => t.FullName.StartsWith("System.Data.IDbConnection", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

            ClassInfo? info = null;
            try
            {
                info = LibChk.ClassInfoType(a, type);

                ClassInfo.Reset();
                info.Value.OutputClass(dll, info.Value.Name, Environment.CurrentDirectory);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            ClassInfo.Reset();

            Type typeStatic = ta.Where(t => t.FullName.StartsWith("System.Data.Common.DbProviderFactories", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
            try
            {
                info = LibChk.ClassInfoType(a, typeStatic);

                ClassInfo.Reset();
                info.Value.OutputClass(dll, info.Value.Name, Environment.CurrentDirectory);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            ClassInfo.Reset();

            //var refIDb = new System.CodeDom.CodeTypeReference(type);
            //var provider = new Microsoft.CSharp.CSharpCodeProvider();
            //var outPut = provider.GetTypeOutput(refIDb);
        }
    }
}
