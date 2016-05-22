
// Source:  /webstack/WPF/LibCheck/dnx/System.Console.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System
{  

   [Guid("3645927f-f050-3383-a86a-b0c800288822")]
   public struct ConsoleKeyInfo 
   {
       public override bool Equals(object value);
       public bool Equals(ConsoleKeyInfo obj);
       public override int GetHashCode();
      //ctor: 
      public ConsoleKeyInfo (char keyChar, ConsoleKey key, bool shift, bool alt, bool control) {}
      public char KeyChar { get { throw new NotImplementedException(); } }
      public ConsoleKey Key { get { throw new NotImplementedException(); } }
      public ConsoleModifiers Modifiers { get { throw new NotImplementedException(); } }
   }
}
