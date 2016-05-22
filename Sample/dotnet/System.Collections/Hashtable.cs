
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.NonGeneric.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections
{  

   [Guid("0c51d98f-8398-3fb7-bb72-b77c21f20913")]
   public class Hashtable : IDictionary
   {
       public virtual void Add(object key, object value) {}
       public virtual void Clear() {}
       public virtual object Clone() { throw new NotImplementedException(); }
       public virtual bool Contains(object key) { throw new NotImplementedException(); }
       public virtual bool ContainsKey(object key) { throw new NotImplementedException(); }
       public virtual bool ContainsValue(object value) { throw new NotImplementedException(); }
       public virtual void CopyTo(Array array, int arrayIndex) {}
       public virtual IDictionaryEnumerator GetEnumerator() { throw new NotImplementedException(); }
       protected virtual int GetHash(object key) { throw new NotImplementedException(); }
       protected virtual bool KeyEquals(object item, object key) { throw new NotImplementedException(); }
       public virtual void Remove(object key) {}
       public static Hashtable Synchronized(System.Collections.Hashtable table) { throw new NotImplementedException(); }
      //ctor: 
      public Hashtable () {}
      //ctor: 
      public Hashtable (int capacity) {}
      //ctor: 
      public Hashtable (int capacity, float loadFactor) {}
      //ctor: 
      public Hashtable (int capacity, float loadFactor, IEqualityComparer equalityComparer) {}
      //ctor: 
      public Hashtable (System.Collections.IEqualityComparer equalityComparer) {}
      //ctor: 
      public Hashtable (int capacity, IEqualityComparer equalityComparer) {}
      //ctor: 
      public Hashtable (System.Collections.IDictionary d) {}
      //ctor: 
      public Hashtable (System.Collections.IDictionary d, float loadFactor) {}
      //ctor: 
      public Hashtable (System.Collections.IDictionary d, IEqualityComparer equalityComparer) {}
      //ctor: 
      public Hashtable (System.Collections.IDictionary d, float loadFactor, IEqualityComparer equalityComparer) {}
      protected IEqualityComparer EqualityComparer { }
      public virtual object this [object key] { get; set; }
      public virtual bool IsReadOnly { get { throw new NotImplementedException(); } }
      public virtual bool IsFixedSize { get { throw new NotImplementedException(); } }
      public virtual bool IsSynchronized { get { throw new NotImplementedException(); } }
      public virtual ICollection Keys { get { throw new NotImplementedException(); } }
      public virtual ICollection Values { get { throw new NotImplementedException(); } }
      public virtual object SyncRoot { get { throw new NotImplementedException(); } }
      public virtual int Count { get { throw new NotImplementedException(); } }
   }
}
