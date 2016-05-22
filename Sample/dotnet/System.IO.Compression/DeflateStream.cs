
// Source:  \/Program Files (x86)/dotnet/bin/System.IO.Compression.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO.Compression
{  

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
      //ctor: 
      public DeflateStream (System.IO.Stream stream, CompressionMode mode) {}
      //ctor: 
      public DeflateStream (System.IO.Stream stream, CompressionMode mode, bool leaveOpen) {}
      //ctor: 
      public DeflateStream (System.IO.Stream stream, CompressionLevel compressionLevel) {}
      //ctor: 
      public DeflateStream (System.IO.Stream stream, CompressionLevel compressionLevel, bool leaveOpen) {}
      public System.IO.Stream BaseStream { get { throw new NotImplementedException(); } }
      public override bool CanRead { get { throw new NotImplementedException(); } }
      public override bool CanWrite { get { throw new NotImplementedException(); } }
      public override bool CanSeek { get { throw new NotImplementedException(); } }
      public override long Length { get { throw new NotImplementedException(); } }
      public override long Position { get; set; }
      public virtual bool CanTimeout { get { throw new NotImplementedException(); } }
      public virtual int ReadTimeout { get; set; }
      public virtual int WriteTimeout { get; set; }
       // Field: 
       public static readonly System.IO.Stream Null;
   }
}
