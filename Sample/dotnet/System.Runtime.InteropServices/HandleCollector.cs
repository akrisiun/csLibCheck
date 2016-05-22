
// Source:  \/Program Files (x86)/dotnet/bin/System.Runtime.InteropServices.PInvoke.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices
{  

   [Guid("1f0673cf-6969-38c9-a5f4-453077d0c218")]
   public sealed class HandleCollector
   {
       public void Add() {}
       public void Remove() {}
      //ctor: 
      public HandleCollector (string name, int initialThreshold) {}
      //ctor: 
      public HandleCollector (string name, int initialThreshold, int maximumThreshold) {}
      public int Count { get { throw new NotImplementedException(); } }
      public int InitialThreshold { get { throw new NotImplementedException(); } }
      public int MaximumThreshold { get { throw new NotImplementedException(); } }
      public string Name { get { throw new NotImplementedException(); } }
   }
}
