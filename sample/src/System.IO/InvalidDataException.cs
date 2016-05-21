
// Source:  D:/webstack/WPF/LibCheck/dnx/System.IO.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO
{  

   [Guid("2ff22f56-357b-33c3-b56b-6875fb842fe0")]
   public sealed class InvalidDataException : System.Exception
   {
       public virtual override Exception GetBaseException() { throw new NotImplementedException(); }
       public virtual override string ToString() { throw new NotImplementedException(); }
       public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
       public virtual override Type GetType() { throw new NotImplementedException(); }
       public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
       public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
       public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
       public virtual override int GetHashCode() { throw new NotImplementedException(); }
       protected virtual override void Finalize() {}
       protected override object MemberwiseClone() { throw new NotImplementedException(); }
      //ctor: 
   public InvalidDataException () {}
      //ctor: 
   public InvalidDataException (string message) {}
      //ctor: 
   public InvalidDataException (string message, Exception innerException) {}
      public virtual string Message { get; }
      public virtual System.Collections.IDictionary Data { get; }
      public virtual Exception InnerException { get; }
      public virtual System.Reflection.MethodBase TargetSite { get; }
      public virtual string StackTrace { get; }
      public virtual string HelpLink { get; set; }
      public virtual string Source { get; set; }
      public int HResult { get; }
   //Event: 
protected event EventHandler<System.Runtime.Serialization.SafeSerializationEventArgs> SerializeObjectState;
   }
}
