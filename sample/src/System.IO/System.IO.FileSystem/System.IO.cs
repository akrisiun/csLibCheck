namespace System.IO
{


// Source:  d:/Beta/dotData/System.IO.FileSystem.dll  Build 4.6.24027.00
[Guid("77a734a0-bea2-3af6-98d1-74b3c0031a28")]
  public abstract sealed class Directory : System.Object
{
    public static bool Exists(string path) { throw new NotImplementedException(); }
    public static void SetCreationTime(string path, DateTime creationTime) {}
    public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc) {}
    public static DateTime GetCreationTime(string path) { throw new NotImplementedException(); }
    public static DateTime GetCreationTimeUtc(string path) { throw new NotImplementedException(); }
    public static void SetLastWriteTime(string path, DateTime lastWriteTime) {}
    public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) {}
    public static DateTime GetLastWriteTime(string path) { throw new NotImplementedException(); }
    public static DateTime GetLastWriteTimeUtc(string path) { throw new NotImplementedException(); }
    public static void SetLastAccessTime(string path, DateTime lastAccessTime) {}
    public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) {}
    public static DateTime GetLastAccessTime(string path) { throw new NotImplementedException(); }
    public static DateTime GetLastAccessTimeUtc(string path) { throw new NotImplementedException(); }
    public static string[] GetFiles(string path) { throw new NotImplementedException(); }
    public static string[] GetFiles(string path, string searchPattern) { throw new NotImplementedException(); }
    public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption) { throw new NotImplementedException(); }
    public static string[] GetDirectories(string path) { throw new NotImplementedException(); }
    public static string[] GetDirectories(string path, string searchPattern) { throw new NotImplementedException(); }
    public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption) { throw new NotImplementedException(); }
    public static string[] GetFileSystemEntries(string path) { throw new NotImplementedException(); }
    public static string[] GetFileSystemEntries(string path, string searchPattern) { throw new NotImplementedException(); }
    public static string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption) { throw new NotImplementedException(); }
    public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories(string path) { throw new NotImplementedException(); }
    public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories(string path, string searchPattern) { throw new NotImplementedException(); }
    public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption) { throw new NotImplementedException(); }
    public static System.Collections.Generic.IEnumerable<string> EnumerateFiles(string path) { throw new NotImplementedException(); }
    public static System.Collections.Generic.IEnumerable<string> EnumerateFiles(string path, string searchPattern) { throw new NotImplementedException(); }
    public static System.Collections.Generic.IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption) { throw new NotImplementedException(); }
    public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries(string path) { throw new NotImplementedException(); }
    public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern) { throw new NotImplementedException(); }
    public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption) { throw new NotImplementedException(); }
    public static string GetDirectoryRoot(string path) { throw new NotImplementedException(); }
    public static string GetCurrentDirectory() { throw new NotImplementedException(); }
    public static void SetCurrentDirectory(string path) {}
    public static void Move(string sourceDirName, string destDirName) {}
    public static void Delete(string path) {}
    public static void Delete(string path, bool recursive) {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.IO.FileSystem.dll  Build 4.6.24027.00
[Guid("868a1715-a118-3c6b-9b0f-1e8748a5c880")]
  public abstract sealed class File : System.Object
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


// Source:  d:/Beta/dotData/System.IO.FileSystem.dll  Build 4.6.24027.00
[Guid("e0edda71-2f5d-3b10-aa7a-e50105ca0c64")]
  public sealed enum FileOptions // : System.Enum
{
    // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.IO.FileSystem.dll  Build 4.6.24027.00
[Guid("9e0113e8-bf1f-3a18-92cd-e17d7a1034a5")]
  public class FileStream : Stream
{
    public virtual void Flush(bool flushToDisk) {}
    public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    protected override void Dispose(bool disposing) {}
    public override void Flush() {}
    public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public virtual int Read(byte[] buffer, int offset, int count) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override int ReadByte() { throw new NotImplementedException(); }
    public override long Seek(long offset, SeekOrigin origin) { throw new NotImplementedException(); }
    public override void SetLength(long value) {}
    public override void Write(byte[] buffer, int offset, int count) {}
    public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override void WriteByte(byte value) {}
    protected override void Finalize() {}
    public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize) { throw new NotImplementedException(); }
    public override void CopyTo(System.IO.Stream destination) {}
    public override void CopyTo(System.IO.Stream destination, int bufferSize) {}
    public virtual override void Close() {}
    public virtual override void Dispose() {}
    public override System.Threading.Tasks.Task FlushAsync() { throw new NotImplementedException(); }
    protected virtual override System.Threading.WaitHandle CreateWaitHandle() { throw new NotImplementedException(); }
    public virtual override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { throw new NotImplementedException(); }
    public virtual override int EndRead(IAsyncResult asyncResult) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count) { throw new NotImplementedException(); }
    public virtual override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { throw new NotImplementedException(); }
    public virtual override void EndWrite(IAsyncResult asyncResult) {}
    public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count) { throw new NotImplementedException(); }
    public static override Stream Synchronized(System.IO.Stream stream) { throw new NotImplementedException(); }
    protected virtual override void ObjectInvariant() {}
    protected override MarshalByRefObject MemberwiseClone(bool cloneIdentity) { throw new NotImplementedException(); }
    public virtual override object GetLifetimeService() { throw new NotImplementedException(); }
    public virtual override object InitializeLifetimeService() { throw new NotImplementedException(); }
    public virtual override System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   public virtual bool IsAsync { get; }
   public string Name { get; }
   public virtual Microsoft.Win32.SafeHandles.SafeFileHandle SafeFileHandle { get; }
   public override bool CanRead { get; }
   public override bool CanSeek { get; }
   public override bool CanWrite { get; }
   public override long Length { get; }
   public override long Position { get; set; }
   public override int ReadTimeout { get; set; }
   public override bool CanTimeout { get; }
   public override int WriteTimeout { get; set; }
// Field: 
public static readonly Stream Null;
  }
}


// Source:  d:/Beta/dotData/System.IO.FileSystem.dll  Build 4.6.24027.00
[Guid("0ceefb60-bfb5-3c13-af9d-bdfe122f5016")]
  public sealed enum SearchOption // : System.Enum
{
    // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }

}