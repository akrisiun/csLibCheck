
// Source:  \/Program Files (x86)/dotnet/bin/System.IO.FileSystem.Watcher.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO
{  

   [Guid("c0d3cff0-a8f4-3e93-b08c-742f65988011")]
   public class ErrorEventArgs : System.EventArgs
   {
       public virtual Exception GetException() { throw new NotImplementedException(); }
      //ctor: 
      public ErrorEventArgs (Exception exception) {}
       // Field: 
       public static readonly EventArgs Empty;
   }
}
