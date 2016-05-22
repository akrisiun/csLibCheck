
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.NonGeneric.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections
{  

   [Guid("0b46b944-86d3-37b0-ab43-913f25d0b0d6")]
   public abstract class DictionaryBase : IDictionary
   {
       public virtual void CopyTo(Array array, int index) {}
       public virtual void Clear() {}
       public virtual IDictionaryEnumerator GetEnumerator() { throw new NotImplementedException(); }
       protected virtual object OnGet(object key, object currentValue) { throw new NotImplementedException(); }
       protected virtual void OnSet(object key, object oldValue, object newValue) {}
       protected virtual void OnInsert(object key, object value) {}
       protected virtual void OnClear() {}
       protected virtual void OnRemove(object key, object value) {}
       protected virtual void OnValidate(object key, object value) {}
       protected virtual void OnSetComplete(object key, object oldValue, object newValue) {}
       protected virtual void OnInsertComplete(object key, object value) {}
       protected virtual void OnClearComplete() {}
       protected virtual void OnRemoveComplete(object key, object value) {}
      //ctor: 
      protected DictionaryBase () {}
      protected Hashtable InnerHashtable { }
      protected IDictionary Dictionary { }
      public virtual int Count { get { throw new NotImplementedException(); } }
   }
}
