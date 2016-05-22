
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.Specialized.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections.Specialized
{  

   [Guid("0d2c82b1-3f52-34f4-afe6-d1016005cdf3")]
   public interface IOrderedDictionary : System.Collections.IDictionary
   {
       System.Collections.IDictionaryEnumerator GetEnumerator();
       void Insert(int index, object key, object value);
       void RemoveAt(int index);
       object this [int index] { get; set; }
   }
}
