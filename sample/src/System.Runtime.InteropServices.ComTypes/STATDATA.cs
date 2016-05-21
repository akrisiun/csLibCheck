
// Source:  D:/webstack/WPF/LibCheck/dnx/System.Runtime.InteropServices.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{  

   [Guid("114fe409-4145-3ef6-acf8-7490335f848d")]
   public sealed struct STATDATA : System.ValueType
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
    public FORMATETC formatetc;
       // Field: 
    public ADVF advf;
       // Field: 
    public IAdviseSink advSink;
       // Field: 
    public int connection;
   }
}
