
// Source:  \/Program Files (x86)/dotnet/bin/System.Runtime.InteropServices.RuntimeInformation.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices
{  

   [Guid("18b00225-12ca-3832-bba3-b5f402799fb1")]
   public struct OSPlatform : System.IEquatable<System.Runtime.InteropServices.OSPlatform>
   {
       public static OSPlatform Create(string osPlatform);
       public virtual bool Equals(System.Runtime.InteropServices.OSPlatform other);
       public override bool Equals(object obj);
       public override int GetHashCode();
       public override string ToString();
      public static OSPlatform Linux { get { throw new NotImplementedException(); } }
      public static OSPlatform OSX { get { throw new NotImplementedException(); } }
      public static OSPlatform Windows { get { throw new NotImplementedException(); } }
   }
}
