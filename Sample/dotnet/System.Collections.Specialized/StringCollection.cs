
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.Specialized.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections.Specialized
{  

   [Guid("9c6f3e51-4816-30cc-abb8-8c89034e360e")]
   public class StringCollection : System.Collections.IList
   {
       public int Add(string value) { throw new NotImplementedException(); }
       public void AddRange(string[] value) {}
       public virtual void Clear() {}
       public bool Contains(string value) { throw new NotImplementedException(); }
       public void CopyTo(string[] array, int index) {}
       public StringEnumerator GetEnumerator() { throw new NotImplementedException(); }
       public int IndexOf(string value) { throw new NotImplementedException(); }
       public void Insert(int index, string value) {}
       public void Remove(string value) {}
       public virtual void RemoveAt(int index) {}
      //ctor: 
      public StringCollection () {}
      public string this [int index] { get; set; }
      public virtual int Count { get { throw new NotImplementedException(); } }
      public bool IsReadOnly { get { throw new NotImplementedException(); } }
      public virtual bool IsSynchronized { get { throw new NotImplementedException(); } }
      public virtual object SyncRoot { get { throw new NotImplementedException(); } }
   }
}
