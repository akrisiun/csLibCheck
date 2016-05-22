
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.NonGeneric.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections
{  

   [Guid("744e870c-cf11-3b36-a8da-5e79cb8fdc84")]
   public class Queue : ICollection
   {
       public virtual object Clone() { throw new NotImplementedException(); }
       public virtual void Clear() {}
       public virtual void CopyTo(Array array, int index) {}
       public virtual void Enqueue(object obj) {}
       public virtual IEnumerator GetEnumerator() { throw new NotImplementedException(); }
       public virtual object Dequeue() { throw new NotImplementedException(); }
       public virtual object Peek() { throw new NotImplementedException(); }
       public static Queue Synchronized(System.Collections.Queue queue) { throw new NotImplementedException(); }
       public virtual bool Contains(object obj) { throw new NotImplementedException(); }
       public virtual object[] ToArray() { throw new NotImplementedException(); }
       public virtual void TrimToSize() {}
      //ctor: 
      public Queue () {}
      //ctor: 
      public Queue (int capacity) {}
      //ctor: 
      public Queue (int capacity, float growFactor) {}
      //ctor: 
      public Queue (System.Collections.ICollection col) {}
      public virtual int Count { get { throw new NotImplementedException(); } }
      public virtual bool IsSynchronized { get { throw new NotImplementedException(); } }
      public virtual object SyncRoot { get { throw new NotImplementedException(); } }
   }
}
