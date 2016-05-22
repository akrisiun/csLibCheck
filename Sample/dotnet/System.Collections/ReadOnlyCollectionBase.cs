
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.NonGeneric.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections
{  

   [Guid("ee11a1d5-26f1-33b3-bd06-0eebdef20078")]
   public abstract class ReadOnlyCollectionBase : ICollection
   {
       public virtual IEnumerator GetEnumerator() { throw new NotImplementedException(); }
      //ctor: 
      protected ReadOnlyCollectionBase () {}
      protected ArrayList InnerList { }
      public virtual int Count { get { throw new NotImplementedException(); } }
   }
}
