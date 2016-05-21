
// Source:  D:/webstack/WPF/LibCheck/dnx/System.Runtime.InteropServices.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{  

   [Guid("0000010f-0000-0000-c000-000000000046")]
   public interface IAdviseSink
   {
       void OnDataChange(System.Runtime.InteropServices.ComTypes.FORMATETC format, STGMEDIUM stgmedium);
       void OnViewChange(int aspect, int index);
       void OnRename(System.Runtime.InteropServices.ComTypes.IMoniker moniker);
       void OnSave();
       void OnClose();
   }
}
