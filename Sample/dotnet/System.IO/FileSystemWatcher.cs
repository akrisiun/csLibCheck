
// Source:  \/Program Files (x86)/dotnet/bin/System.IO.FileSystem.Watcher.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO
{  

   [Guid("729dba1e-02d7-388c-802d-aa0423628726")]
   public class FileSystemWatcher : System.IDisposable
   {
       protected override void Finalize() {}
       public virtual void Dispose() {}
       protected virtual void Dispose(bool disposing) {}
       protected void OnChanged(System.IO.FileSystemEventArgs e) {}
       protected void OnCreated(System.IO.FileSystemEventArgs e) {}
       protected void OnDeleted(System.IO.FileSystemEventArgs e) {}
       protected void OnError(System.IO.ErrorEventArgs e) {}
       protected void OnRenamed(System.IO.RenamedEventArgs e) {}
      //ctor: 
      public FileSystemWatcher () {}
      //ctor: 
      public FileSystemWatcher (string path) {}
      //ctor: 
      public FileSystemWatcher (string path, string filter) {}
      public NotifyFilters NotifyFilter { get; set; }
      public bool EnableRaisingEvents { get; set; }
      public string Filter { get; set; }
      public bool IncludeSubdirectories { get; set; }
      public int InternalBufferSize { get; set; }
      public string Path { get; set; }
      // Event: 
   // public event FileSystemEventHandler Changed;
      // Event: 
   // public event FileSystemEventHandler Created;
      // Event: 
   // public event FileSystemEventHandler Deleted;
      // Event: 
   // public event ErrorEventHandler Error;
      // Event: 
   // public event RenamedEventHandler Renamed;
   }
}
