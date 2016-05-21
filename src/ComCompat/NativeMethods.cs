using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using ComTypes = System.Runtime.InteropServices.ComTypes;
using System.Security;

//[Obsolete("Use System.Runtime.InteropServices.ComTypes.ITypeLib instead)]
//[Guid("00020402-0000-0000-C000-000000000046")]
//[InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
//[ComImport]
//public interface UCOMITypeLib
//{
//    void GetTypeInfo(int index, out UCOMITypeInfo ppTI);
//    void GetTypeInfoType(int index, out TYPEKIND pTKind);
//    void GetTypeInfoOfGuid(ref Guid guid, out UCOMITypeInfo ppTInfo);
//    bool IsName([MarshalAs(UnmanagedType.LPWStr)] String szNameBuf, int lHashVal);
//    void FindName([MarshalAs(UnmanagedType.LPWStr)] String szNameBuf, int lHashVal, [MarshalAs(UnmanagedType.LPArray), Out] UCOMITypeInfo[] ppTInfo, [MarshalAs(UnmanagedType.LPArray), Out] int[] rgMemId, ref Int16 pcFound);
//}

//[Guid("00020402-0000-0000-C000-000000000046")]
//[InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
//[ComImport]
//public interface ITypeLib
//{
//    [PreserveSig]
//    int GetTypeInfoCount();
//    void GetTypeInfo(int index, out ITypeInfo ppTI);
//    void GetTypeInfoType(int index, out TYPEKIND pTKind);
//    void GetTypeInfoOfGuid(ref Guid guid, out ITypeInfo ppTInfo);
//}

/// <summary>
/// PInvoke methods.
/// </summary>
namespace ComComparer 
{
	internal class NativeMethods
	{
		[DllImport("oleaut32.dll", CharSet=CharSet.Unicode, PreserveSig=false)]
		internal static extern ITypeLib LoadTypeLibEx(string szFile, REGKIND regkind);
	}

	// REGKIND enumeration used by LoadTypeLibEx
	internal enum REGKIND
	{
		REGKIND_DEFAULT = 0,
		REGKIND_REGISTER = 1,
		REGKIND_NONE = 2
	}

	// Various type information structures

	internal struct VARDESC
	{
		public int memid;
		public IntPtr lpstrSchema;
		public DESCUNION descUnion;
		public ComTypes.ELEMDESC elemdescVar;
		public short wVarFlags;
		public VARKIND varkind;
	}

	internal struct ARRAYDESC
	{
		internal ComTypes.TYPEDESC tdescElem;
		internal ushort cDims;
		internal IntPtr rgbounds;
	}

	internal struct SAFEARRAYBOUND 
	{
		internal ulong cElements;
		internal long lLbound;
	}

	internal struct PARAMDESCEX 
	{
		internal IntPtr cByte;
		[MarshalAs(UnmanagedType.Struct)] internal object varDefaultValue;
	}

	[StructLayout(LayoutKind.Explicit)]
	internal struct DESCUNION
	{
		[FieldOffset(0)] public int oInst;
		[FieldOffset(0)] public IntPtr lpvarValue;
	}
	internal enum VARKIND
	{
		VAR_PERINSTANCE,
		VAR_STATIC,
		VAR_CONST,
		VAR_DISPATCH
	}

	class DummyClass
	{
		private void WarningSilencer()
		{
			// Use "unused" fields to silence warnings.
			// The fields are really used by unmanaged code

			VARDESC v = new VARDESC();
			v.elemdescVar = new ComTypes.ELEMDESC();
			v.lpstrSchema = IntPtr.Zero;
			v.memid = 0;
			v.varkind = 0;
			v.wVarFlags = 0;
			v.descUnion = new DESCUNION();

			ARRAYDESC a = new ARRAYDESC();
			a.cDims = 0;
			a.rgbounds = IntPtr.Zero;
			a.tdescElem = new ComTypes.TYPEDESC();

			SAFEARRAYBOUND sb = new SAFEARRAYBOUND();
			sb.cElements = 0;
			sb.lLbound = 0;

			PARAMDESCEX p = new PARAMDESCEX();
			p.cByte = IntPtr.Zero;
			p.varDefaultValue = null;
		}
	}
}