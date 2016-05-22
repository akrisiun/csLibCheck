
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.Specialized.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections.Specialized
{  

   [Guid("63fd37dd-3514-3af5-8b72-d3647095b428")]
   public class HybridDictionary : System.Collections.IDictionary
   {
       public virtual void Add(object key, object value) {}
       public virtual void Clear() {}
       public virtual bool Contains(object key) { throw new NotImplementedException(); }
       public virtual void CopyTo(Array array, int index) {}
       public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { throw new NotImplementedException(); }
       public virtual void Remove(object key) {}
      //ctor: 
      public HybridDictionary () {}
      //ctor: 
      public HybridDictionary (int initialSize) {}
      //ctor: 
      public HybridDictionary (bool caseInsensitive) {}
      //ctor: 
      public HybridDictionary (int initialSize, bool caseInsensitive) {}
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
