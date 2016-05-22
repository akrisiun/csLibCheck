
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.Specialized.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections.Specialized
{  

   [Guid("490d17f9-dccd-3801-82c3-65ee1d43fd40")]
   public abstract class NameObjectCollectionBase : System.Collections.ICollection
   {
       protected bool BaseHasKeys() { throw new NotImplementedException(); }
       protected void BaseAdd(string name, object value) {}
       protected void BaseRemove(string name) {}
       protected void BaseRemoveAt(int index) {}
       protected void BaseClear() {}
       protected object BaseGet(string name) { throw new NotImplementedException(); }
       protected void BaseSet(string name, object value) {}
       protected object BaseGet(int index) { throw new NotImplementedException(); }
       protected string BaseGetKey(int index) { throw new NotImplementedException(); }
       protected void BaseSet(int index, object value) {}
       public virtual System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
       protected string[] BaseGetAllKeys() { throw new NotImplementedException(); }
       protected object[] BaseGetAllValues() { throw new NotImplementedException(); }
       protected object[] BaseGetAllValues(Type type) { throw new NotImplementedException(); }
      //ctor: 
      protected NameObjectCollectionBase () {}
      //ctor: 
      protected NameObjectCollectionBase (System.Collections.IEqualityComparer equalityComparer) {}
      //ctor: 
      protected NameObjectCollectionBase (int capacity, System.Collections.IEqualityComparer equalityComparer) {}
      //ctor: 
      protected NameObjectCollectionBase (int capacity) {}
      protected bool IsReadOnly { }
      public virtual int Count { get { throw new NotImplementedException(); } }
      public virtual KeysCollection Keys { get { throw new NotImplementedException(); } }
   public class KeysCollection.KeysCollection
   }
}
