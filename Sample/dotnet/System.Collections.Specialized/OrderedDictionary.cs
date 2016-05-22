
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.Specialized.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections.Specialized
{  

   [Guid("d88fabda-aa80-35f0-8fb7-acc9c2b4c86c")]
   public class OrderedDictionary : IOrderedDictionary
   {
       public virtual void Add(object key, object value) {}
       public virtual void Clear() {}
       public OrderedDictionary AsReadOnly() { throw new NotImplementedException(); }
       public virtual bool Contains(object key) { throw new NotImplementedException(); }
       public virtual void CopyTo(Array array, int index) {}
       public virtual void Insert(int index, object key, object value) {}
       public virtual void RemoveAt(int index) {}
       public virtual void Remove(object key) {}
       public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { throw new NotImplementedException(); }
      //ctor: 
      public OrderedDictionary () {}
      //ctor: 
      public OrderedDictionary (int capacity) {}
      //ctor: 
      public OrderedDictionary (System.Collections.IEqualityComparer comparer) {}
      //ctor: 
      public OrderedDictionary (int capacity, System.Collections.IEqualityComparer comparer) {}
      public virtual int Count { get { throw new NotImplementedException(); } }
      public virtual bool IsReadOnly { get { throw new NotImplementedException(); } }
      public virtual System.Collections.ICollection Keys { get { throw new NotImplementedException(); } }
      public virtual object this [int index] { get; set; }
      public virtual object this [object key] { get; set; }
      public virtual System.Collections.ICollection Values { get { throw new NotImplementedException(); } }
   }
}
