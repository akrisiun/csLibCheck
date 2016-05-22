
// Source:  \/Program Files (x86)/dotnet/bin/System.IO.FileSystem.Watcher.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.IO
{  

   [Guid("f5f3b354-6598-3851-b088-f153b0c163a3")]
   public sealed delegate FileSystemEventHandler : System.MulticastDelegate
   {
       public virtual void Invoke(object sender, FileSystemEventArgs e) {}
       public virtual IAsyncResult BeginInvoke(object sender, FileSystemEventArgs e, AsyncCallback callback, object object) { throw new NotImplementedException(); }
       public virtual void EndInvoke(IAsyncResult result) {}
       public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
      // protected virtual override delegate CombineImpl(delegate follow) { throw new NotImplementedException(); }
      // protected virtual override delegate RemoveImpl(delegate value) { throw new NotImplementedException(); }
      // public virtual override delegate[] GetInvocationList() { throw new NotImplementedException(); }
       protected virtual override System.Reflection.MethodInfo GetMethodImpl() { throw new NotImplementedException(); }
       public override object DynamicInvoke(object[] args) { throw new NotImplementedException(); }
       protected virtual override object DynamicInvokeImpl(object[] args) { throw new NotImplementedException(); }
      // public static override delegate Combine(delegate a, delegate b) { throw new NotImplementedException(); }
      // public static override delegate Combine(delegate[] delegates) { throw new NotImplementedException(); }
      // public static override delegate Remove(delegate source, delegate value) { throw new NotImplementedException(); }
      // public static override delegate RemoveAll(delegate source, delegate value) { throw new NotImplementedException(); }
       public virtual override object Clone() { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, object target, string method) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, Type target, string method) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, System.Reflection.MethodInfo method) { throw new NotImplementedException(); }
      //ctor: 
      public FileSystemEventHandler (object object, IntPtr method) {}
      public System.Reflection.MethodInfo Method { get { throw new NotImplementedException(); } }
      public object Target { get { throw new NotImplementedException(); } }
   }
}
