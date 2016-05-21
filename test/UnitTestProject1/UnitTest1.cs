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

        public void Prepare()
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

            ClassInfo.Reset();
            first.OutputClass(dllData, first.Name, "");
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
