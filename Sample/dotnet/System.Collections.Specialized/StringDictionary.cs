
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.Specialized.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections.Specialized
{  

   [Guid("77f89a80-10a4-3a7a-9c2a-d98faaeb74ff")]
   public class StringDictionary : System.Collections.IEnumerable
   {
       public virtual void Add(string key, string value) {}
       public virtual void Clear() {}
       public virtual bool ContainsKey(string key) { throw new NotImplementedException(); }
       public virtual bool ContainsValue(string value) { throw new NotImplementedException(); }
       public virtual void CopyTo(Array array, int index) {}
       public virtual System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
       public virtual void Remove(string key) {}
      //ctor: 
      public StringDictionary () {}
      public virtual int Count { get { throw new NotImplementedException(); } }
      public virtual bool IsSynchronized { get { throw new NotImplementedException(); } }
      public virtual string this [string key] { get; set; }
      public virtual System.Collections.ICollection Keys { get { throw new NotImplementedException(); } }
      public virtual object SyncRoot { get { throw new NotImplementedException(); } }
      public virtual System.Collections.ICollection Values { get { throw new NotImplementedException(); } }
   }
}
