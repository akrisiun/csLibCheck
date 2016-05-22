
// Source:  \/Program Files (x86)/dotnet/bin/System.Runtime.InteropServices.PInvoke.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices
{  

   [Guid("bd6d2fff-53fe-335a-9ac4-2f2fdeb82083")]
   public static class PInvokeMarshal
   {
       public static IntPtr AllocateMemory(int sizeInBytes) { throw new NotImplementedException(); }
       public static void DestroyStructure(IntPtr ptr, Type structureType) {}
       public static void DestroyStructure(IntPtr ptr) {}
       public static void FreeMemory(IntPtr ptr) {}
      // public static delegate GetDelegateForFunctionPointer(IntPtr ptr, Type delegateType) { throw new NotImplementedException(); }
       public static GetDelegateForFunctionPointer(IntPtr ptr) { throw new NotImplementedException(); }
      // public static IntPtr GetFunctionPointerForDelegate(delegate d) { throw new NotImplementedException(); }
       public static IntPtr GetFunctionPointerForDelegate(System.Runtime.InteropServices.TDelegate d) { throw new NotImplementedException(); }
       public static int GetLastError() { throw new NotImplementedException(); }
       public static IntPtr OffsetOf(Type type, string fieldName) { throw new NotImplementedException(); }
       public static IntPtr OffsetOf(string fieldName) { throw new NotImplementedException(); }
       public static string PtrToStringAnsi(IntPtr ptr) { throw new NotImplementedException(); }
       public static string PtrToStringAnsi(IntPtr ptr, int len) { throw new NotImplementedException(); }
       public static string PtrToStringUTF16(IntPtr ptr) { throw new NotImplementedException(); }
       public static string PtrToStringUTF16(IntPtr ptr, int len) { throw new NotImplementedException(); }
       public static void PtrToStructure(IntPtr ptr, object structure) {}
       public static object PtrToStructure(IntPtr ptr, Type structureType) { throw new NotImplementedException(); }
       public static PtrToStructure(IntPtr ptr) { throw new NotImplementedException(); }
       public static void PtrToStructure(IntPtr ptr, T structure) {}
       public static IntPtr ReallocateMemory(IntPtr ptr, int sizeInBytes) { throw new NotImplementedException(); }
       public static int SizeOf(object structure) { throw new NotImplementedException(); }
       public static int SizeOf(Type type) { throw new NotImplementedException(); }
       public static int SizeOf() { throw new NotImplementedException(); }
       public static IntPtr StringToAllocatedMemoryAnsi(string s) { throw new NotImplementedException(); }
       public static IntPtr StringToAllocatedMemoryUTF16(string s) { throw new NotImplementedException(); }
       public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) {}
       public static void StructureToPtr(System.Runtime.InteropServices.T structure, IntPtr ptr, bool fDeleteOld) {}
       public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { throw new NotImplementedException(); }
       public static IntPtr UnsafeAddrOfPinnedArrayElement(System.Runtime.InteropServices.T[] arr, int index) { throw new NotImplementedException(); }
       public static void ZeroFreeMemoryAnsi(IntPtr s) {}
       public static void ZeroFreeMemoryUTF16(IntPtr s) {}
       // Field: 
       public static readonly int SystemDefaultCharSize;
       // Field: 
       public static readonly int SystemMaxDBCSCharSize;
   }
}
