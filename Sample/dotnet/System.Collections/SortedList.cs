
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.NonGeneric.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections
{  

   [Guid("0fcc7625-b285-35f8-b534-a526665f2114")]
   public class SortedList : IDictionary
   {
       public virtual void Add(object key, object value) {}
       public virtual void Clear() {}
       public virtual object Clone() { throw new NotImplementedException(); }
       public virtual bool Contains(object key) { throw new NotImplementedException(); }
       public virtual bool ContainsKey(object key) { throw new NotImplementedException(); }
       public virtual bool ContainsValue(object value) { throw new NotImplementedException(); }
       public virtual void CopyTo(Array array, int arrayIndex) {}
       public virtual object GetByIndex(int index) { throw new NotImplementedException(); }
       public virtual IDictionaryEnumerator GetEnumerator() { throw new NotImplementedException(); }
       public virtual object GetKey(int index) { throw new NotImplementedException(); }
       public virtual IList GetKeyList() { throw new NotImplementedException(); }
       public virtual IList GetValueList() { throw new NotImplementedException(); }
       public virtual int IndexOfKey(object key) { throw new NotImplementedException(); }
       public virtual int IndexOfValue(object value) { throw new NotImplementedException(); }
       public virtual void RemoveAt(int index) {}
       public virtual void Remove(object key) {}
       public virtual void SetByIndex(int index, object value) {}
       public static SortedList Synchronized(System.Collections.SortedList list) { throw new NotImplementedException(); }
       public virtual void TrimToSize() {}
      //ctor: 
      public SortedList () {}
      //ctor: 
      public SortedList (int initialCapacity) {}
      //ctor: 
      public SortedList (System.Collections.IComparer comparer) {}
      //ctor: 
      public SortedList (System.Collections.IComparer comparer, int capacity) {}
      //ctor: 
      public SortedList (System.Collections.IDictionary d) {}
      //ctor: 
      public SortedList (System.Collections.IDictionary d, IComparer comparer) {}
      public virtual int Capacity { get; set; }
      public virtual int Count { get { throw new NotImplementedException(); } }
      public virtual ICollection Keys { get { throw new NotImplementedException(); } }
      public virtual ICollection Values { get { throw new NotImplementedException(); } }
      public virtual bool IsReadOnly { get { throw new NotImplementedException(); } }
      public virtual bool IsFixedSize { get { throw new NotImplementedException(); } }
      public virtual bool IsSynchronized { get { throw new NotImplementedException(); } }
      public virtual object SyncRoot { get { throw new NotImplementedException(); } }
      public virtual object this [object key] { get; set; }
   }
}
