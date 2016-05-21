
// Source:  D:/webstack/WPF/LibCheck/dnx/System.IO.FileSystem.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO
{  

   [Guid("868a1715-a118-3c6b-9b0f-1e8748a5c880")]
   public static class File
   {
       public static StreamReader OpenText(string path) { throw new NotImplementedException(); }
       public static StreamWriter CreateText(string path) { throw new NotImplementedException(); }
       public static StreamWriter AppendText(string path) { throw new NotImplementedException(); }
       public static void Copy(string sourceFileName, string destFileName) {}
       public static void Copy(string sourceFileName, string destFileName, bool overwrite) {}
       public static FileStream Create(string path) { throw new NotImplementedException(); }
       public static FileStream Create(string path, int bufferSize) { throw new NotImplementedException(); }
       public static FileStream Create(string path, int bufferSize, FileOptions options) { throw new NotImplementedException(); }
       public static void Delete(string path) {}
       public static bool Exists(string path) { throw new NotImplementedException(); }
       public static void SetCreationTime(string path, DateTime creationTimeUtc) {}
       public static void SetCreationTimeUtc(string path, DateTime creationTime) {}
       public static DateTime GetCreationTime(string path) { throw new NotImplementedException(); }
       public static DateTime GetCreationTimeUtc(string path) { throw new NotImplementedException(); }
       public static void SetLastAccessTime(string path, DateTime lastAccessTime) {}
       public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) {}
       public static DateTime GetLastAccessTime(string path) { throw new NotImplementedException(); }
       public static DateTime GetLastAccessTimeUtc(string path) { throw new NotImplementedException(); }
       public static void SetLastWriteTime(string path, DateTime lastWriteTime) {}
       public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) {}
       public static DateTime GetLastWriteTime(string path) { throw new NotImplementedException(); }
       public static DateTime GetLastWriteTimeUtc(string path) { throw new NotImplementedException(); }
       public static FileStream OpenRead(string path) { throw new NotImplementedException(); }
       public static FileStream OpenWrite(string path) { throw new NotImplementedException(); }
       public static string ReadAllText(string path) { throw new NotImplementedException(); }
       public static string ReadAllText(string path, System.Text.Encoding encoding) { throw new NotImplementedException(); }
       public static void WriteAllText(string path, string contents) {}
       public static void WriteAllText(string path, string contents, System.Text.Encoding encoding) {}
       public static byte[] ReadAllBytes(string path) { throw new NotImplementedException(); }
       public static void WriteAllBytes(string path, byte[] bytes) {}
       public static string[] ReadAllLines(string path) { throw new NotImplementedException(); }
       public static string[] ReadAllLines(string path, System.Text.Encoding encoding) { throw new NotImplementedException(); }
       public static System.Collections.Generic.IEnumerable<string> ReadLines(string path) { throw new NotImplementedException(); }
       public static System.Collections.Generic.IEnumerable<string> ReadLines(string path, System.Text.Encoding encoding) { throw new NotImplementedException(); }
       public static void WriteAllLines(string path, System.Collections.Generic.IEnumerable<string> contents) {}
       public static void WriteAllLines(string path, System.Collections.Generic.IEnumerable<string> contents, System.Text.Encoding encoding) {}
       public static void AppendAllText(string path, string contents) {}
       public static void AppendAllText(string path, string contents, System.Text.Encoding encoding) {}
       public static void AppendAllLines(string path, System.Collections.Generic.IEnumerable<string> contents) {}
       public static void AppendAllLines(string path, System.Collections.Generic.IEnumerable<string> contents, System.Text.Encoding encoding) {}
       public static void Move(string sourceFileName, string destFileName) {}
       public virtual override string ToString() { throw new NotImplementedException(); }
       public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
       public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
       public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
       public virtual override int GetHashCode() { throw new NotImplementedException(); }
       public override Type GetType() { throw new NotImplementedException(); }
       protected virtual override void Finalize() {}
       protected override object MemberwiseClone() { throw new NotImplementedException(); }
   }
}
