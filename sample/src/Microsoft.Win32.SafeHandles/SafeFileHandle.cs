
// Source:  D:/webstack/WPF/LibCheck/dnx/System.IO.FileSystem.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{  
   //SafeFileHandle  4.0.1-rc2-24008\ref\netstandard1.3\System.Runtime.Handles.dll

   [Guid("1fc692d1-3486-347b-ac6c-f67cf838a2e3")]
   public sealed class SafeFileHandle : System.Runtime.InteropServices.SafeHandle, IDisposable
   {
       protected override bool ReleaseHandle() { throw new NotImplementedException(); }
       //protected virtual override void Finalize() {}
       protected override void SetHandle(IntPtr handle) {}
       public override IntPtr DangerousGetHandle() { throw new NotImplementedException(); }
       public override void Close() {}
       public virtual override void Dispose() {}
       protected virtual override void Dispose(bool disposing) {}
       public override void SetHandleAsInvalid() {}
       public override void DangerousAddRef(bool success) {}
       public override void DangerousRelease() {}

       // public virtual override string ToString() { throw new NotImplementedException(); }
       //public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
       //public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
       //public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
       //public virtual override int GetHashCode() { throw new NotImplementedException(); }
       //public override Type GetType() { throw new NotImplementedException(); }
       //protected override object MemberwiseClone() { throw new NotImplementedException(); }
      //ctor: 
   public SafeFileHandle (IntPtr preexistingHandle, bool ownsHandle) {}
      public override bool IsInvalid { get; }
      public bool IsClosed { get; }
       // Field: 
    protected IntPtr handle;
   }
}
