
// Source:  \/Program Files (x86)/dotnet/bin/System.IO.Compression.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO.Compression
{  

   [Guid("d660f8f3-901a-3f78-b798-3bfa48976daf")]
   public class ZipArchiveEntry
   {
       public void Delete() {}
       public System.IO.Stream Open() { throw new NotImplementedException(); }
       public override string ToString() { throw new NotImplementedException(); }
      public ZipArchive Archive { get { throw new NotImplementedException(); } }
      public long CompressedLength { get { throw new NotImplementedException(); } }
      public string FullName { get { throw new NotImplementedException(); } }
      public DateTimeOffset LastWriteTime { get; set; }
      public long Length { get { throw new NotImplementedException(); } }
      public string Name { get { throw new NotImplementedException(); } }
   }
}
