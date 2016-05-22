
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.Specialized.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections.Specialized
{  

   [Guid("c9927aaa-a7e1-3007-aeb1-59e95a9d5f0c")]
   public class NameValueCollection : NameObjectCollectionBase
   {
       protected void InvalidateCachedArrays() {}
       public void Add(System.Collections.Specialized.NameValueCollection c) {}
       public virtual void Clear() {}
       public void CopyTo(Array dest, int index) {}
       public bool HasKeys() { throw new NotImplementedException(); }
       public virtual void Add(string name, string value) {}
       public virtual string Get(string name) { throw new NotImplementedException(); }
       public virtual string[] GetValues(string name) { throw new NotImplementedException(); }
       public virtual void Set(string name, string value) {}
       public virtual void Remove(string name) {}
       public virtual string Get(int index) { throw new NotImplementedException(); }
       public virtual string[] GetValues(int index) { throw new NotImplementedException(); }
       public virtual string GetKey(int index) { throw new NotImplementedException(); }
       protected override bool BaseHasKeys() { throw new NotImplementedException(); }
       protected override void BaseAdd(string name, object value) {}
       protected override void BaseRemove(string name) {}
       protected override void BaseRemoveAt(int index) {}
       protected override void BaseClear() {}
       protected override object BaseGet(string name) { throw new NotImplementedException(); }
       protected override void BaseSet(string name, object value) {}
       protected override object BaseGet(int index) { throw new NotImplementedException(); }
       protected override string BaseGetKey(int index) { throw new NotImplementedException(); }
       protected override void BaseSet(int index, object value) {}
       public virtual override System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
       protected override string[] BaseGetAllKeys() { throw new NotImplementedException(); }
       protected override object[] BaseGetAllValues() { throw new NotImplementedException(); }
       protected override object[] BaseGetAllValues(Type type) { throw new NotImplementedException(); }
      //ctor: 
      public NameValueCollection () {}
      //ctor: 
      public NameValueCollection (System.Collections.Specialized.NameValueCollection col) {}
      //ctor: 
      public NameValueCollection (int capacity) {}
      //ctor: 
      public NameValueCollection (System.Collections.IEqualityComparer equalityComparer) {}
      //ctor: 
      public NameValueCollection (int capacity, System.Collections.IEqualityComparer equalityComparer) {}
      //ctor: 
      public NameValueCollection (int capacity, NameValueCollection col) {}
      public string this [string name] { get; set; }
      public string this [int index] { get { throw new NotImplementedException(); } }
      public virtual String[] AllKeys { get { throw new NotImplementedException(); } }
      protected bool IsReadOnly { }
      public virtual int Count { get { throw new NotImplementedException(); } }
      public virtual KeysCollection Keys { get { throw new NotImplementedException(); } }
   }
}
