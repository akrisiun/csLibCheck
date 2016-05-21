using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibCheck;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_SystemData()
        {
            var vars = Environment.GetEnvironmentVariables();

            var dll = Environment.GetEnvironmentVariable("windir") + @"\Microsoft.NET\Framework\v4.0.30319\System.Data.dll";

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var newDir = Path.GetFullPath(dir + @"\..\..\..\..\bin");
            Directory.SetCurrentDirectory(newDir);

            Assert.IsTrue(Directory.Exists("RefFiles"));
            if (!LibChk.IsPrepared)
                LibChk.Prepare();

            LibChk.outputLoc = newDir; 

            // file:///C:/WINDOWS/Microsoft.Net/assembly/GAC_32/System.Data/v4.0_4.0.0.0__b77a5c561934e089/System.Data.dll
            LibChk.OneAssembly(dll);

            var a = Assembly.LoadFrom(dll);

            Type[] ta = LibChk.GetTypes(a);

            IEnumerable<ClassInfo> list = LibChk.EnumClassInfo(a, ta, null, false);
            var first = list.Where(i => i.Name.StartsWith("System.Data.IDbConnection", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

            ClassInfo.Reset();
            first.OutputClass(dll, first.Name, "");

            // LibChk.CreateMemberList(ref Hashtable typememberList, Assembly a,
            //out int errorCount, out int memberCount, int winformsFile)


            }
    }
}
