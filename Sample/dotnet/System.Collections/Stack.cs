
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.NonGeneric.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections
{  

   [Guid("6d292bf9-fee6-3c8d-85ff-754e50d175df")]
   public class Stack : ICollection
   {
       public virtual void Clear() {}
       public virtual object Clone() { throw new NotImplementedException(); }
       public virtual bool Contains(object obj) { throw new NotImplementedException(); }
       public virtual void CopyTo(Array array, int index) {}
       public virtual IEnumerator GetEnumerator() { throw new NotImplementedException(); }
       public virtual object Peek() { throw new NotImplementedException(); }
       public virtual object Pop() { throw new NotImplementedException(); }
       public virtual void Push(object obj) {}
       public static Stack Synchronized(System.Collections.Stack stack) { throw new NotImplementedException(); }
       public virtual object[] ToArray() { throw new NotImplementedException(); }
      //ctor: 
      public Stack () {}
      //ctor: 
      public Stack (int initialCapacity) {}
      //ctor: 
      public Stack (System.Collections.ICollection col) {}
      public virtual int Count { get { throw new NotImplementedException(); } }
      public virtual bool IsSynchronized { get { throw new NotImplementedException(); } }
      public virtual object SyncRoot { get { throw new NotImplementedException(); } }
   }
}
