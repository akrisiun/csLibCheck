
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.NonGeneric.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections
{  

   [Guid("72271114-e21d-3afa-bd86-6b9886d4d3e5")]
   public abstract class CollectionBase : IList
   {
       public virtual void Clear() {}
       public virtual void RemoveAt(int index) {}
       public virtual IEnumerator GetEnumerator() { throw new NotImplementedException(); }
       protected virtual void OnSet(int index, object oldValue, object newValue) {}
       protected virtual void OnInsert(int index, object value) {}
       protected virtual void OnClear() {}
       protected virtual void OnRemove(int index, object value) {}
       protected virtual void OnValidate(object value) {}
       protected virtual void OnSetComplete(int index, object oldValue, object newValue) {}
       protected virtual void OnInsertComplete(int index, object value) {}
       protected virtual void OnClearComplete() {}
       protected virtual void OnRemoveComplete(int index, object value) {}
      //ctor: 
      protected CollectionBase () {}
      //ctor: 
      protected CollectionBase (int capacity) {}
      protected ArrayList InnerList { }
      protected IList List { }
      public int Capacity { get; set; }
      public virtual int Count { get { throw new NotImplementedException(); } }
   }
}
