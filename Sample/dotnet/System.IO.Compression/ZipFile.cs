
// Source:  \/Program Files (x86)/dotnet/bin/System.IO.Compression.ZipFile.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO.Compression
{  

   [Guid("ba133e60-d80d-3b33-a9e8-e6402dc66415")]
   public static class ZipFile
   {
       public static ZipArchive OpenRead(string archiveFileName) { throw new NotImplementedException(); }
       public static ZipArchive Open(string archiveFileName, ZipArchiveMode mode) { throw new NotImplementedException(); }
       public static ZipArchive Open(string archiveFileName, ZipArchiveMode mode, System.Text.Encoding entryNameEncoding) { throw new NotImplementedException(); }
       public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName) {}
       public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory) {}
       public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory, System.Text.Encoding entryNameEncoding) {}
       public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName) {}
       public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, System.Text.Encoding entryNameEncoding) {}
   }
}
