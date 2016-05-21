
// Source:  D:/webstack/WPF/LibCheck/dnx/System.Runtime.InteropServices.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{  

   [Guid("5d74c2cc-5637-3943-9ebe-d87e15bb68f2")]
   public sealed struct FORMATETC : System.ValueType
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
    public short cfFormat;
       // Field: 
    public IntPtr ptd;
       // Field: 
    public DVASPECT dwAspect;
       // Field: 
    public int lindex;
       // Field: 
    public TYMED tymed;
   }
}
