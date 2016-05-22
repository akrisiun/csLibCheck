
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.NonGeneric.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections
{  

   [Guid("8e8c0482-d227-329b-800c-025579d657bb")]
   public class CaseInsensitiveComparer : IComparer
   {
       public virtual int Compare(object a, object b) { throw new NotImplementedException(); }
      //ctor: 
      public CaseInsensitiveComparer () {}
      //ctor: 
      public CaseInsensitiveComparer (System.Globalization.CultureInfo culture) {}
      public static CaseInsensitiveComparer Default { get { throw new NotImplementedException(); } }
      public static CaseInsensitiveComparer DefaultInvariant { get { throw new NotImplementedException(); } }
   }
}
