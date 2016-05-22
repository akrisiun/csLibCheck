
// Source:  \/Program Files (x86)/dotnet/bin/System.IO.Compression.ZipFile.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO.Compression
{  

   [Guid("9f77bb1c-472a-3340-a168-b6c2c6b54967")]
   public static class ZipFileExtensions
   {
       public static ZipArchiveEntry CreateEntryFromFile(this ZipArchive destination, string sourceFileName, string entryName) { throw new NotImplementedException(); }
       public static ZipArchiveEntry CreateEntryFromFile(this ZipArchive destination, string sourceFileName, string entryName, CompressionLevel compressionLevel) { throw new NotImplementedException(); }
       public static void ExtractToDirectory(this ZipArchive source, string destinationDirectoryName) {}
       public static void ExtractToFile(this ZipArchiveEntry source, string destinationFileName) {}
       public static void ExtractToFile(this ZipArchiveEntry source, string destinationFileName, bool overwrite) {}
   }
}
