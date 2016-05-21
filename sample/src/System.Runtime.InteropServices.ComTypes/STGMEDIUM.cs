
// Source:  D:/webstack/WPF/LibCheck/dnx/System.Runtime.InteropServices.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{  

   [Guid("2f5ae4d1-72c1-3c50-a351-62ca604648cd")]
   public sealed struct STGMEDIUM : System.ValueType
   {
       public virtual override bool Equals(object obj);
       public virtual override int GetHashCode();
       public virtual override string ToString();
       public static override bool Equals(object objA, object objB);
       public static override bool ReferenceEquals(object objA, object objB);
       public override Type GetType();
       protected virtual override void Finalize();
       protected override object MemberwiseClone();
       // Field: 
    public TYMED tymed;
       // Field: 
    public IntPtr unionmember;
       // Field: 
    public object pUnkForRelease;
   }
}
