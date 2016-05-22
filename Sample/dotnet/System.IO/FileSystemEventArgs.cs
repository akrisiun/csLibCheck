
// Source:  \/Program Files (x86)/dotnet/bin/System.IO.FileSystem.Watcher.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO
{  

   [Guid("489f546d-dec6-32ae-a567-42d2ef7579bb")]
   public class FileSystemEventArgs : System.EventArgs
   {
      //ctor: 
      public FileSystemEventArgs (System.IO.WatcherChangeTypes changeType, string directory, string name) {}
      public WatcherChangeTypes ChangeType { get { throw new NotImplementedException(); } }
      public string FullPath { get { throw new NotImplementedException(); } }
      public string Name { get { throw new NotImplementedException(); } }
       // Field: 
       public static readonly EventArgs Empty;
   }
}
