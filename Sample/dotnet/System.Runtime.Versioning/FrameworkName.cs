
// Source:  \/Program Files (x86)/dotnet/bin/System.Runtime.Extensions.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Versioning
{  

   [Guid("49404244-722f-3221-9548-f600d6e0c287")]
   public sealed class FrameworkName : System.IEquatable<System.Runtime.Versioning.FrameworkName>
   {
       public override bool Equals(object obj) { throw new NotImplementedException(); }
       public virtual bool Equals(System.Runtime.Versioning.FrameworkName other) { throw new NotImplementedException(); }
       public override int GetHashCode() { throw new NotImplementedException(); }
       public override string ToString() { throw new NotImplementedException(); }
      //ctor: 
      public FrameworkName (string identifier, Version version) {}
      //ctor: 
      public FrameworkName (string identifier, Version version, string profile) {}
      //ctor: 
      public FrameworkName (string frameworkName) {}
      public string Identifier { get { throw new NotImplementedException(); } }
      public Version Version { get { throw new NotImplementedException(); } }
      public string Profile { get { throw new NotImplementedException(); } }
      public string FullName { get { throw new NotImplementedException(); } }
   }
}
