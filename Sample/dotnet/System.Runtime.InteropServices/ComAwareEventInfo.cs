
// Source:  \/Program Files (x86)/dotnet/bin/System.Runtime.InteropServices.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices
{  

   [Guid("c526468d-572b-3646-b059-26a6c9978056")]
   public class ComAwareEventInfo : System.Reflection.EventInfo
   {
      // public override void AddEventHandler(object target, delegate handler) {}
      // public override void RemoveEventHandler(object target, delegate handler) {}
       public override System.Reflection.MethodInfo GetAddMethod(bool nonPublic) { throw new NotImplementedException(); }
       public override System.Reflection.MethodInfo GetRaiseMethod(bool nonPublic) { throw new NotImplementedException(); }
       public override System.Reflection.MethodInfo GetRemoveMethod(bool nonPublic) { throw new NotImplementedException(); }
       public override object[] GetCustomAttributes(Type attributeType, bool inherit) { throw new NotImplementedException(); }
       public override object[] GetCustomAttributes(bool inherit) { throw new NotImplementedException(); }
       public override bool IsDefined(Type attributeType, bool inherit) { throw new NotImplementedException(); }
       public virtual override System.Reflection.MethodInfo[] GetOtherMethods(bool nonPublic) { throw new NotImplementedException(); }
       public override System.Reflection.MethodInfo[] GetOtherMethods() { throw new NotImplementedException(); }
       public virtual override System.Reflection.MethodInfo GetAddMethod() { throw new NotImplementedException(); }
       public virtual override System.Reflection.MethodInfo GetRemoveMethod() { throw new NotImplementedException(); }
       public virtual override System.Reflection.MethodInfo GetRaiseMethod() { throw new NotImplementedException(); }
       public virtual override System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData() { throw new NotImplementedException(); }
      // ctor: 
   // public ComAwareEventInfo (Type type, string eventName) {}
      public override System.Reflection.EventAttributes Attributes { get { throw new NotImplementedException(); } }
      public override Type DeclaringType { get { throw new NotImplementedException(); } }
      public override string Name { get { throw new NotImplementedException(); } }
      public override Type ReflectedType { get { throw new NotImplementedException(); } }
      public virtual System.Reflection.MemberTypes MemberType { get { throw new NotImplementedException(); } }
      public virtual System.Reflection.MethodInfo AddMethod { get { throw new NotImplementedException(); } }
      public virtual System.Reflection.MethodInfo RemoveMethod { get { throw new NotImplementedException(); } }
      public virtual System.Reflection.MethodInfo RaiseMethod { get { throw new NotImplementedException(); } }
      public virtual Type EventHandlerType { get { throw new NotImplementedException(); } }
      public virtual bool IsSpecialName { get { throw new NotImplementedException(); } }
      public virtual bool IsMulticast { get { throw new NotImplementedException(); } }
      public virtual System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData> CustomAttributes { get { throw new NotImplementedException(); } }
      public virtual int MetadataToken { get { throw new NotImplementedException(); } }
      public virtual System.Reflection.Module Module { get { throw new NotImplementedException(); } }
   }
}
