
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.Specialized.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections.Specialized
{  

   [Guid("4b049581-a7fe-3139-a05b-2ca075ca6e50")]
   public class ListDictionary : System.Collections.IDictionary
   {
       public virtual void Add(object key, object value) {}
       public virtual void Clear() {}
       public virtual bool Contains(object key) { throw new NotImplementedException(); }
       public virtual void CopyTo(Array array, int index) {}
       public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { throw new NotImplementedException(); }
       public virtual void Remove(object key) {}
      //ctor: 
      public ListDictionary () {}
      //ctor: 
      public ListDictionary (System.Collections.IComparer comparer) {}
      public virtual object this [object key] { get; set; }
      public virtual int Count { get { throw new NotImplementedException(); } }
      public virtual System.Collections.ICollection Keys { get { throw new NotImplementedException(); } }
      public virtual bool IsReadOnly { get { throw new NotImplementedException(); } }
      public virtual bool IsFixedSize { get { throw new NotImplementedException(); } }
      public virtual bool IsSynchronized { get { throw new NotImplementedException(); } }
      public virtual object SyncRoot { get { throw new NotImplementedException(); } }
      public virtual System.Collections.ICollection Values { get { throw new NotImplementedException(); } }
   }
}
