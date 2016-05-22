
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.NonGeneric.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections
{  

   [Guid("c4de933a-042e-32d7-bdab-3f7672c3e78e")]
   public class ArrayList : IList
   {
       public static ArrayList Adapter(System.Collections.IList list) { throw new NotImplementedException(); }
       public virtual int Add(object value) { throw new NotImplementedException(); }
       public virtual void AddRange(System.Collections.ICollection c) {}
       public virtual int BinarySearch(int index, int count, object value, IComparer comparer) { throw new NotImplementedException(); }
       public virtual int BinarySearch(object value) { throw new NotImplementedException(); }
       public virtual int BinarySearch(object value, IComparer comparer) { throw new NotImplementedException(); }
       public virtual void Clear() {}
       public virtual object Clone() { throw new NotImplementedException(); }
       public virtual bool Contains(object item) { throw new NotImplementedException(); }
       public virtual void CopyTo(Array array) {}
       public virtual void CopyTo(Array array, int arrayIndex) {}
       public virtual void CopyTo(int index, Array array, int arrayIndex, int count) {}
       public static IList FixedSize(System.Collections.IList list) { throw new NotImplementedException(); }
       public static ArrayList FixedSize(System.Collections.ArrayList list) { throw new NotImplementedException(); }
       public virtual IEnumerator GetEnumerator() { throw new NotImplementedException(); }
       public virtual IEnumerator GetEnumerator(int index, int count) { throw new NotImplementedException(); }
       public virtual int IndexOf(object value) { throw new NotImplementedException(); }
       public virtual int IndexOf(object value, int startIndex) { throw new NotImplementedException(); }
       public virtual int IndexOf(object value, int startIndex, int count) { throw new NotImplementedException(); }
       public virtual void Insert(int index, object value) {}
       public virtual void InsertRange(int index, ICollection c) {}
       public virtual int LastIndexOf(object value) { throw new NotImplementedException(); }
       public virtual int LastIndexOf(object value, int startIndex) { throw new NotImplementedException(); }
       public virtual int LastIndexOf(object value, int startIndex, int count) { throw new NotImplementedException(); }
       public static IList ReadOnly(System.Collections.IList list) { throw new NotImplementedException(); }
       public static ArrayList ReadOnly(System.Collections.ArrayList list) { throw new NotImplementedException(); }
       public virtual void Remove(object obj) {}
       public virtual void RemoveAt(int index) {}
       public virtual void RemoveRange(int index, int count) {}
       public static ArrayList Repeat(object value, int count) { throw new NotImplementedException(); }
       public virtual void Reverse() {}
       public virtual void Reverse(int index, int count) {}
       public virtual void SetRange(int index, ICollection c) {}
       public virtual ArrayList GetRange(int index, int count) { throw new NotImplementedException(); }
       public virtual void Sort() {}
       public virtual void Sort(System.Collections.IComparer comparer) {}
       public virtual void Sort(int index, int count, IComparer comparer) {}
       public static IList Synchronized(System.Collections.IList list) { throw new NotImplementedException(); }
       public static ArrayList Synchronized(System.Collections.ArrayList list) { throw new NotImplementedException(); }
       public virtual object[] ToArray() { throw new NotImplementedException(); }
       public virtual Array ToArray(Type type) { throw new NotImplementedException(); }
       public virtual void TrimToSize() {}
      //ctor: 
      public ArrayList () {}
      //ctor: 
      public ArrayList (int capacity) {}
      //ctor: 
      public ArrayList (System.Collections.ICollection c) {}
      public virtual int Capacity { get; set; }
      public virtual int Count { get { throw new NotImplementedException(); } }
      public virtual bool IsFixedSize { get { throw new NotImplementedException(); } }
      public virtual bool IsReadOnly { get { throw new NotImplementedException(); } }
      public virtual bool IsSynchronized { get { throw new NotImplementedException(); } }
      public virtual object SyncRoot { get { throw new NotImplementedException(); } }
      public virtual object this [int index] { get; set; }
   }
}
