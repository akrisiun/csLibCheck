
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.Specialized.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections.Specialized
{  

   [Guid("af7f2655-9597-3797-967b-c97b75fb7af2")]
   public struct BitVector32 
   {
       public static int CreateMask();
       public static int CreateMask(int previous);
       public static Section CreateSection(short maxValue);
       public static Section CreateSection(short maxValue, Section previous);
       public override bool Equals(object o);
       public override int GetHashCode();
       public static string ToString(System.Collections.Specialized.BitVector32 value);
       public override string ToString();
      //ctor: 
      public BitVector32 (int data) {}
      //ctor: 
      public BitVector32 (System.Collections.Specialized.BitVector32 value) {}
      public bool this [int bit] { get; set; }
      public int this [System.Collections.Specialized.Section section] { get; set; }
      public int Data { get { throw new NotImplementedException(); } }
   public sealed struct Section.Section
   }
}
