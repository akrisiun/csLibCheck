
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.NonGeneric.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections
{  

   [Guid("e935c35f-0df0-381a-9e7b-78dc27f51a83")]
   public sealed class Comparer : IComparer
   {
       public virtual int Compare(object a, object b) { throw new NotImplementedException(); }
      //ctor: 
      public Comparer (System.Globalization.CultureInfo culture) {}
       // Field: 
       public static readonly Comparer Default;
       // Field: 
       public static readonly Comparer DefaultInvariant;
   }
}
