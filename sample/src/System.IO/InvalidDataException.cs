
   [Guid("2ff22f56-357b-33c3-b56b-6875fb842fe0")]
   public sealed class InvalidDataException : System.Exception
   {
       public virtual override Exception GetBaseException() { throw new NotImplementedException(); }
       public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
       public virtual override Type GetType() { throw new NotImplementedException(); }
      //ctor: 
      public InvalidDataException () {}
      //ctor: 
      public InvalidDataException (string message) {}
      //ctor: 
      public InvalidDataException (string message, Exception innerException) {}
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
