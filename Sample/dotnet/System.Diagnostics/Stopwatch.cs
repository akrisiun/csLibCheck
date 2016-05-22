
// Source:  \/Program Files (x86)/dotnet/bin/System.Runtime.Extensions.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{  

   [Guid("05b9cfe5-cbed-375f-88d6-1ac55491b68f")]
   public class Stopwatch
   {
       public void Start() {}
       public static Stopwatch StartNew() { throw new NotImplementedException(); }
       public void Stop() {}
       public void Reset() {}
       public void Restart() {}
       public static long GetTimestamp() { throw new NotImplementedException(); }
      //ctor: 
      public Stopwatch () {}
      public bool IsRunning { get { throw new NotImplementedException(); } }
      public TimeSpan Elapsed { get { throw new NotImplementedException(); } }
      public long ElapsedMilliseconds { get { throw new NotImplementedException(); } }
      public long ElapsedTicks { get { throw new NotImplementedException(); } }
       // Field: 
       public static readonly long Frequency;
       // Field: 
       public static readonly bool IsHighResolution;
   }
}
