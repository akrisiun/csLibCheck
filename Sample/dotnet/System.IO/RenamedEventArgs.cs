
// Source:  \/Program Files (x86)/dotnet/bin/System.IO.FileSystem.Watcher.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO
{  

   [Guid("998f333a-cfcb-35f4-bf98-aa08a6e43cb7")]
   public class RenamedEventArgs : FileSystemEventArgs
   {
      //ctor: 
      public RenamedEventArgs (System.IO.WatcherChangeTypes changeType, string directory, string name, string oldName) {}
      public string OldFullPath { get { throw new NotImplementedException(); } }
      public string OldName { get { throw new NotImplementedException(); } }
      public WatcherChangeTypes ChangeType { get { throw new NotImplementedException(); } }
      public string FullPath { get { throw new NotImplementedException(); } }
      public string Name { get { throw new NotImplementedException(); } }
       // Field: 
       public static readonly EventArgs Empty;
   }
}
