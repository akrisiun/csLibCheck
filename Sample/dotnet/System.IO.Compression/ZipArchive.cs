
// Source:  \/Program Files (x86)/dotnet/bin/System.IO.Compression.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO.Compression
{  

   [Guid("44009137-8b7a-3151-ae3e-3c19973c1659")]
   public class ZipArchive : System.IDisposable
   {
       public ZipArchiveEntry CreateEntry(string entryName) { throw new NotImplementedException(); }
       public ZipArchiveEntry CreateEntry(string entryName, CompressionLevel compressionLevel) { throw new NotImplementedException(); }
       protected virtual void Dispose(bool disposing) {}
       public virtual void Dispose() {}
       public ZipArchiveEntry GetEntry(string entryName) { throw new NotImplementedException(); }
      //ctor: 
      public ZipArchive (System.IO.Stream stream) {}
      //ctor: 
      public ZipArchive (System.IO.Stream stream, ZipArchiveMode mode) {}
      //ctor: 
      public ZipArchive (System.IO.Stream stream, ZipArchiveMode mode, bool leaveOpen) {}
      //ctor: 
      public ZipArchive (System.IO.Stream stream, ZipArchiveMode mode, bool leaveOpen, System.Text.Encoding entryNameEncoding) {}
      public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry> Entries { get { throw new NotImplementedException(); } }
      public ZipArchiveMode Mode { get { throw new NotImplementedException(); } }
   }
}
