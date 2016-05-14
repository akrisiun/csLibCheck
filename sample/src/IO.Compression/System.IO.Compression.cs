
namespace System.IO.Compression
{  


// Source:  d:/Beta/dotData/System.IO.Compression.dll  Build 4.6.24027.00
[Guid("44009137-8b7a-3151-ae3e-3c19973c1659")]
  public class ZipArchive : System.Object System.IDisposable
{
    public ZipArchiveEntry CreateEntry(string entryName) { throw new NotImplementedException(); }
    public ZipArchiveEntry CreateEntry(string entryName, CompressionLevel compressionLevel) { throw new NotImplementedException(); }
    protected virtual void Dispose(bool disposing) {}
    public virtual void Dispose() {}
    public ZipArchiveEntry GetEntry(string entryName) { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public ZipArchive (System.IO.Stream stream) {}
//ctor: 
public ZipArchive (System.IO.Stream stream, ZipArchiveMode mode) {}
//ctor: 
public ZipArchive (System.IO.Stream stream, ZipArchiveMode mode, bool leaveOpen) {}
//ctor: 
public ZipArchive (System.IO.Stream stream, ZipArchiveMode mode, bool leaveOpen, System.Text.Encoding entryNameEncoding) {}
   public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry> Entries { get; }
   public ZipArchiveMode Mode { get; }
  }


// Source:  d:/Beta/dotData/System.IO.Compression.dll  Build 4.6.24027.00
[Guid("d660f8f3-901a-3f78-b798-3bfa48976daf")]
  public class ZipArchiveEntry : System.Object
{
    public void Delete() {}
    public System.IO.Stream Open() { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   public ZipArchive Archive { get; }
   public long CompressedLength { get; }
   public string FullName { get; }
   public DateTimeOffset LastWriteTime { get; set; }
   public long Length { get; }
   public string Name { get; }
  }


// Source:  d:/Beta/dotData/System.IO.Compression.dll  Build 4.6.24027.00
[Guid("d0e48122-4a72-3414-8341-ef274812291a")]
  public sealed enum ZipArchiveMode : System.Enum
{
    public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.IO.Compression.dll  Build 4.6.24027.00
[Guid("77d307ff-ce2a-39f7-afeb-b536c3f83329")]
  public sealed enum CompressionLevel : System.Enum
{
    public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.IO.Compression.dll  Build 4.6.24027.00
[Guid("a1ccd0ed-9eb4-39bb-9790-af6f647c3513")]
  public sealed enum CompressionMode : System.Enum
{
    public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.IO.Compression.dll  Build 4.6.24027.00
[Guid("baaf3f76-3124-3dcc-b2f1-a6cc0c51f672")]
  public class DeflateStream : System.IO.Stream
{
    public override void Flush() {}
    public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { throw new NotImplementedException(); }
    public override void SetLength(long value) {}
    public override int ReadByte() { throw new NotImplementedException(); }
    public virtual int Read(byte[] array, int offset, int count) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<int> ReadAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override void Write(byte[] array, int offset, int count) {}
    protected override void Dispose(bool disposing) {}
    public override System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize) { throw new NotImplementedException(); }
    public virtual override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
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
    public virtual override void WriteByte(byte value) {}
    public static override System.IO.Stream Synchronized(System.IO.Stream stream) { throw new NotImplementedException(); }
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
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public DeflateStream (System.IO.Stream stream, CompressionMode mode) {}
//ctor: 
public DeflateStream (System.IO.Stream stream, CompressionMode mode, bool leaveOpen) {}
//ctor: 
public DeflateStream (System.IO.Stream stream, CompressionLevel compressionLevel) {}
//ctor: 
public DeflateStream (System.IO.Stream stream, CompressionLevel compressionLevel, bool leaveOpen) {}
   public System.IO.Stream BaseStream { get; }
   public override bool CanRead { get; }
   public override bool CanWrite { get; }
   public override bool CanSeek { get; }
   public override long Length { get; }
   public override long Position { get; set; }
   public virtual bool CanTimeout { get; }
   public virtual int ReadTimeout { get; set; }
   public virtual int WriteTimeout { get; set; }
// Field: 
public static readonly System.IO.Stream Null;
  }


// Source:  d:/Beta/dotData/System.IO.Compression.dll  Build 4.6.24027.00
[Guid("6c2826ca-0fda-37d0-b70f-6439331a9474")]
  public class GZipStream : System.IO.Stream
{
    public override void Flush() {}
    public override long Seek(long offset, System.IO.SeekOrigin origin) { throw new NotImplementedException(); }
    public override void SetLength(long value) {}
    public override int ReadByte() { throw new NotImplementedException(); }
    public virtual int Read(byte[] array, int offset, int count) { throw new NotImplementedException(); }
    public override void Write(byte[] array, int offset, int count) {}
    protected override void Dispose(bool disposing) {}
    public override System.Threading.Tasks.Task<int> ReadAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize) { throw new NotImplementedException(); }
    public virtual override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
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
    public virtual override void WriteByte(byte value) {}
    public static override System.IO.Stream Synchronized(System.IO.Stream stream) { throw new NotImplementedException(); }
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
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public GZipStream (System.IO.Stream stream, CompressionMode mode) {}
//ctor: 
public GZipStream (System.IO.Stream stream, CompressionMode mode, bool leaveOpen) {}
//ctor: 
public GZipStream (System.IO.Stream stream, CompressionLevel compressionLevel) {}
//ctor: 
public GZipStream (System.IO.Stream stream, CompressionLevel compressionLevel, bool leaveOpen) {}
   public override bool CanRead { get; }
   public override bool CanWrite { get; }
   public override bool CanSeek { get; }
   public override long Length { get; }
   public override long Position { get; set; }
   public System.IO.Stream BaseStream { get; }
   public virtual bool CanTimeout { get; }
   public virtual int ReadTimeout { get; set; }
   public virtual int WriteTimeout { get; set; }
// Field: 
public static readonly System.IO.Stream Null;
  }
