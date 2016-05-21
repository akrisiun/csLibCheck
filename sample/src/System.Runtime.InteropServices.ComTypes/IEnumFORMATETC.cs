
// Source:  D:/webstack/WPF/LibCheck/dnx/System.Runtime.InteropServices.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{  

   [Guid("00000103-0000-0000-c000-000000000046")]
   public interface IEnumFORMATETC
   {
       int Next(int celt, OutAttribute FORMATETC[] rgelt, OutAttribute int[] pceltFetched);
       int Skip(int celt);
       int Reset();
       void Clone(out IEnumFORMATETC newEnum);
   }
}
