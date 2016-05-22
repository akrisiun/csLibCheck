
// Source:  \/Program Files (x86)/dotnet/bin/System.IO.FileSystem.Watcher.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO
{  

   [Guid("c83a5bf4-5239-30c9-af99-3ea397d0e3d2")]
   public class InternalBufferOverflowException : System.Exception
   {
       public virtual override Exception GetBaseException() { throw new NotImplementedException(); }
       public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
       public virtual override Type GetType() { throw new NotImplementedException(); }
      //ctor: 
      public InternalBufferOverflowException () {}
      //ctor: 
      public InternalBufferOverflowException (string message) {}
      //ctor: 
      public InternalBufferOverflowException (string message, Exception inner) {}
      public virtual string Message { get { throw new NotImplementedException(); } }
      public virtual System.Collections.IDictionary Data { get { throw new NotImplementedException(); } }
      public virtual Exception InnerException { get { throw new NotImplementedException(); } }
      public virtual System.Reflection.MethodBase TargetSite { get { throw new NotImplementedException(); } }
      public virtual string StackTrace { get { throw new NotImplementedException(); } }
      public virtual string HelpLink { get; set; }
      public virtual string Source { get; set; }
      public int HResult { get { throw new NotImplementedException(); } }
      // Event: 
   // protected event EventHandler<System.Runtime.Serialization.SafeSerializationEventArgs> SerializeObjectState;
   }
}
