
namespace System.Data.SqlTypes
{  


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("e7b3191e-cb93-3820-ab88-949781697507")]
  public interface INullable
{
   public bool IsNull { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("65770f80-4132-39ed-bfb3-cae28f428bf4")]
  public sealed struct SqlBinary : System.ValueType INullable, System.IComparable
{
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlBinary Add(System.Data.SqlTypes.SqlBinary x, SqlBinary y) { throw new NotImplementedException(); }
    public static SqlBinary Concat(System.Data.SqlTypes.SqlBinary x, SqlBinary y) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlBinary x, SqlBinary y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlBinary x, SqlBinary y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlBinary x, SqlBinary y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlBinary x, SqlBinary y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlBinary x, SqlBinary y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlBinary x, SqlBinary y) { throw new NotImplementedException(); }
    public SqlGuid ToSqlGuid() { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlBinary value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlBinary (byte[] value) {}
   public virtual bool IsNull { get; }
   public Byte[] Value { get; }
   public byte this [int index] { get; }
   public int Length { get; }
// Field: 
public static readonly SqlBinary Null;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("fa9fdefd-21d4-30e6-9d11-0f4ec10b8779")]
  public sealed struct SqlBoolean : System.ValueType INullable, System.IComparable
{
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlBoolean Parse(string s) { throw new NotImplementedException(); }
    public static SqlBoolean OnesComplement(System.Data.SqlTypes.SqlBoolean x) { throw new NotImplementedException(); }
    public static SqlBoolean And(System.Data.SqlTypes.SqlBoolean x, SqlBoolean y) { throw new NotImplementedException(); }
    public static SqlBoolean Or(System.Data.SqlTypes.SqlBoolean x, SqlBoolean y) { throw new NotImplementedException(); }
    public static SqlBoolean Xor(System.Data.SqlTypes.SqlBoolean x, SqlBoolean y) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlBoolean x, SqlBoolean y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlBoolean x, SqlBoolean y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlBoolean x, SqlBoolean y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlBoolean x, SqlBoolean y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEquals(System.Data.SqlTypes.SqlBoolean x, SqlBoolean y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEquals(System.Data.SqlTypes.SqlBoolean x, SqlBoolean y) { throw new NotImplementedException(); }
    public SqlByte ToSqlByte() { throw new NotImplementedException(); }
    public SqlDouble ToSqlDouble() { throw new NotImplementedException(); }
    public SqlInt16 ToSqlInt16() { throw new NotImplementedException(); }
    public SqlInt32 ToSqlInt32() { throw new NotImplementedException(); }
    public SqlInt64 ToSqlInt64() { throw new NotImplementedException(); }
    public SqlMoney ToSqlMoney() { throw new NotImplementedException(); }
    public SqlDecimal ToSqlDecimal() { throw new NotImplementedException(); }
    public SqlSingle ToSqlSingle() { throw new NotImplementedException(); }
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlBoolean value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlBoolean (bool value) {}
//ctor: 
public SqlBoolean (int value) {}
   public virtual bool IsNull { get; }
   public bool Value { get; }
   public bool IsTrue { get; }
   public bool IsFalse { get; }
   public byte ByteValue { get; }
// Field: 
public static readonly SqlBoolean True;
// Field: 
public static readonly SqlBoolean False;
// Field: 
public static readonly SqlBoolean Null;
// Field: 
public static readonly SqlBoolean Zero;
// Field: 
public static readonly SqlBoolean One;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("7e573f30-68c5-3188-97f2-249d19656fab")]
  public sealed struct SqlByte : System.ValueType INullable, System.IComparable
{
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlByte Parse(string s) { throw new NotImplementedException(); }
    public static SqlByte OnesComplement(System.Data.SqlTypes.SqlByte x) { throw new NotImplementedException(); }
    public static SqlByte Add(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlByte Subtract(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlByte Multiply(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlByte Divide(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlByte Mod(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlByte Modulus(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlByte BitwiseAnd(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlByte BitwiseOr(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlByte Xor(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlByte x, SqlByte y) { throw new NotImplementedException(); }
    public SqlBoolean ToSqlBoolean() { throw new NotImplementedException(); }
    public SqlDouble ToSqlDouble() { throw new NotImplementedException(); }
    public SqlInt16 ToSqlInt16() { throw new NotImplementedException(); }
    public SqlInt32 ToSqlInt32() { throw new NotImplementedException(); }
    public SqlInt64 ToSqlInt64() { throw new NotImplementedException(); }
    public SqlMoney ToSqlMoney() { throw new NotImplementedException(); }
    public SqlDecimal ToSqlDecimal() { throw new NotImplementedException(); }
    public SqlSingle ToSqlSingle() { throw new NotImplementedException(); }
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlByte value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlByte (byte value) {}
   public virtual bool IsNull { get; }
   public byte Value { get; }
// Field: 
public static readonly SqlByte Null;
// Field: 
public static readonly SqlByte Zero;
// Field: 
public static readonly SqlByte MinValue;
// Field: 
public static readonly SqlByte MaxValue;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("0c48a537-662c-33c8-b76a-4491bb23d93b")]
  public sealed class SqlBytes : System.Object INullable
{
    public void SetNull() {}
    public void SetLength(long value) {}
    public long Read(long offset, byte[] buffer, int offsetInBuffer, int count) { throw new NotImplementedException(); }
    public void Write(long offset, byte[] buffer, int offsetInBuffer, int count) {}
    public SqlBinary ToSqlBinary() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlBytes () {}
//ctor: 
public SqlBytes (byte[] buffer) {}
//ctor: 
public SqlBytes (System.Data.SqlTypes.SqlBinary value) {}
//ctor: 
public SqlBytes (System.IO.Stream s) {}
   public virtual bool IsNull { get; }
   public Byte[] Buffer { get; }
   public long Length { get; }
   public long MaxLength { get; }
   public Byte[] Value { get; }
   public byte this [long offset] { get; set; }
   public StorageState Storage { get; }
   public System.IO.Stream Stream { get; set; }
   public static SqlBytes Null { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("c76c020d-6873-366d-889b-f49cdfd51c82")]
  public sealed class SqlChars : System.Object INullable
{
    public void SetNull() {}
    public void SetLength(long value) {}
    public long Read(long offset, char[] buffer, int offsetInBuffer, int count) { throw new NotImplementedException(); }
    public void Write(long offset, char[] buffer, int offsetInBuffer, int count) {}
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlChars () {}
//ctor: 
public SqlChars (char[] buffer) {}
//ctor: 
public SqlChars (System.Data.SqlTypes.SqlString value) {}
   public virtual bool IsNull { get; }
   public Char[] Buffer { get; }
   public long Length { get; }
   public long MaxLength { get; }
   public Char[] Value { get; }
   public char this [long offset] { get; set; }
   public StorageState Storage { get; }
   public static SqlChars Null { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("906d2e2f-ea64-35c4-b502-ebb48a8bab36")]
  public sealed struct SqlDateTime : System.ValueType INullable, System.IComparable
{
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlDateTime Parse(string s) { throw new NotImplementedException(); }
    public static SqlDateTime Add(System.Data.SqlTypes.SqlDateTime x, TimeSpan t) { throw new NotImplementedException(); }
    public static SqlDateTime Subtract(System.Data.SqlTypes.SqlDateTime x, TimeSpan t) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlDateTime x, SqlDateTime y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlDateTime x, SqlDateTime y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlDateTime x, SqlDateTime y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDateTime x, SqlDateTime y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlDateTime x, SqlDateTime y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlDateTime x, SqlDateTime y) { throw new NotImplementedException(); }
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlDateTime value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlDateTime (DateTime value) {}
//ctor: 
public SqlDateTime (int year, int month, int day) {}
//ctor: 
public SqlDateTime (int year, int month, int day, int hour, int minute, int second) {}
//ctor: 
public SqlDateTime (int year, int month, int day, int hour, int minute, int second, double millisecond) {}
//ctor: 
public SqlDateTime (int year, int month, int day, int hour, int minute, int second, int bilisecond) {}
//ctor: 
public SqlDateTime (int dayTicks, int timeTicks) {}
   public virtual bool IsNull { get; }
   public DateTime Value { get; }
   public int DayTicks { get; }
   public int TimeTicks { get; }
// Field: 
public static readonly int SQLTicksPerSecond;
// Field: 
public static readonly int SQLTicksPerMinute;
// Field: 
public static readonly int SQLTicksPerHour;
// Field: 
public static readonly SqlDateTime MinValue;
// Field: 
public static readonly SqlDateTime MaxValue;
// Field: 
public static readonly SqlDateTime Null;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("3e579115-b528-31a5-9d94-1eb904021d1b")]
  public sealed struct SqlDecimal : System.ValueType INullable, System.IComparable
{
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlDecimal Parse(string s) { throw new NotImplementedException(); }
    public double ToDouble() { throw new NotImplementedException(); }
    public static SqlDecimal AdjustScale(System.Data.SqlTypes.SqlDecimal n, int digits, bool fRound) { throw new NotImplementedException(); }
    public static SqlDecimal ConvertToPrecScale(System.Data.SqlTypes.SqlDecimal n, int precision, int scale) { throw new NotImplementedException(); }
    public static SqlDecimal Add(System.Data.SqlTypes.SqlDecimal x, SqlDecimal y) { throw new NotImplementedException(); }
    public static SqlDecimal Subtract(System.Data.SqlTypes.SqlDecimal x, SqlDecimal y) { throw new NotImplementedException(); }
    public static SqlDecimal Multiply(System.Data.SqlTypes.SqlDecimal x, SqlDecimal y) { throw new NotImplementedException(); }
    public static SqlDecimal Divide(System.Data.SqlTypes.SqlDecimal x, SqlDecimal y) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlDecimal x, SqlDecimal y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlDecimal x, SqlDecimal y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlDecimal x, SqlDecimal y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDecimal x, SqlDecimal y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlDecimal x, SqlDecimal y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlDecimal x, SqlDecimal y) { throw new NotImplementedException(); }
    public SqlBoolean ToSqlBoolean() { throw new NotImplementedException(); }
    public SqlByte ToSqlByte() { throw new NotImplementedException(); }
    public SqlDouble ToSqlDouble() { throw new NotImplementedException(); }
    public SqlInt16 ToSqlInt16() { throw new NotImplementedException(); }
    public SqlInt32 ToSqlInt32() { throw new NotImplementedException(); }
    public SqlInt64 ToSqlInt64() { throw new NotImplementedException(); }
    public SqlMoney ToSqlMoney() { throw new NotImplementedException(); }
    public SqlSingle ToSqlSingle() { throw new NotImplementedException(); }
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public static SqlDecimal Abs(System.Data.SqlTypes.SqlDecimal n) { throw new NotImplementedException(); }
    public static SqlDecimal Ceiling(System.Data.SqlTypes.SqlDecimal n) { throw new NotImplementedException(); }
    public static SqlDecimal Floor(System.Data.SqlTypes.SqlDecimal n) { throw new NotImplementedException(); }
    public static SqlInt32 Sign(System.Data.SqlTypes.SqlDecimal n) { throw new NotImplementedException(); }
    public static SqlDecimal Round(System.Data.SqlTypes.SqlDecimal n, int position) { throw new NotImplementedException(); }
    public static SqlDecimal Truncate(System.Data.SqlTypes.SqlDecimal n, int position) { throw new NotImplementedException(); }
    public static SqlDecimal Power(System.Data.SqlTypes.SqlDecimal n, double exp) { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlDecimal value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlDecimal (decimal value) {}
//ctor: 
public SqlDecimal (int value) {}
//ctor: 
public SqlDecimal (long value) {}
//ctor: 
public SqlDecimal (byte bPrecision, byte bScale, bool fPositive, int[] bits) {}
//ctor: 
public SqlDecimal (byte bPrecision, byte bScale, bool fPositive, int data1, int data2, int data3, int data4) {}
//ctor: 
public SqlDecimal (double dVal) {}
   public virtual bool IsNull { get; }
   public decimal Value { get; }
   public bool IsPositive { get; }
   public byte Precision { get; }
   public byte Scale { get; }
   public Int32[] Data { get; }
   public Byte[] BinData { get; }
// Field: 
public static readonly byte MaxPrecision;
// Field: 
public static readonly byte MaxScale;
// Field: 
public static readonly SqlDecimal Null;
// Field: 
public static readonly SqlDecimal MinValue;
// Field: 
public static readonly SqlDecimal MaxValue;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("79df1604-1986-3217-b3e8-72ce6670c8df")]
  public sealed struct SqlDouble : System.ValueType INullable, System.IComparable
{
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlDouble Parse(string s) { throw new NotImplementedException(); }
    public static SqlDouble Add(System.Data.SqlTypes.SqlDouble x, SqlDouble y) { throw new NotImplementedException(); }
    public static SqlDouble Subtract(System.Data.SqlTypes.SqlDouble x, SqlDouble y) { throw new NotImplementedException(); }
    public static SqlDouble Multiply(System.Data.SqlTypes.SqlDouble x, SqlDouble y) { throw new NotImplementedException(); }
    public static SqlDouble Divide(System.Data.SqlTypes.SqlDouble x, SqlDouble y) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlDouble x, SqlDouble y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlDouble x, SqlDouble y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlDouble x, SqlDouble y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDouble x, SqlDouble y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlDouble x, SqlDouble y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlDouble x, SqlDouble y) { throw new NotImplementedException(); }
    public SqlBoolean ToSqlBoolean() { throw new NotImplementedException(); }
    public SqlByte ToSqlByte() { throw new NotImplementedException(); }
    public SqlInt16 ToSqlInt16() { throw new NotImplementedException(); }
    public SqlInt32 ToSqlInt32() { throw new NotImplementedException(); }
    public SqlInt64 ToSqlInt64() { throw new NotImplementedException(); }
    public SqlMoney ToSqlMoney() { throw new NotImplementedException(); }
    public SqlDecimal ToSqlDecimal() { throw new NotImplementedException(); }
    public SqlSingle ToSqlSingle() { throw new NotImplementedException(); }
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlDouble value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlDouble (double value) {}
   public virtual bool IsNull { get; }
   public double Value { get; }
// Field: 
public static readonly SqlDouble Null;
// Field: 
public static readonly SqlDouble Zero;
// Field: 
public static readonly SqlDouble MinValue;
// Field: 
public static readonly SqlDouble MaxValue;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("ccfaae11-bd26-3c38-a4b1-02b1f8698b00")]
  public sealed struct SqlGuid : System.ValueType INullable, System.IComparable
{
    public byte[] ToByteArray() { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlGuid Parse(string s) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlGuid x, SqlGuid y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlGuid x, SqlGuid y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlGuid x, SqlGuid y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlGuid x, SqlGuid y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlGuid x, SqlGuid y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlGuid x, SqlGuid y) { throw new NotImplementedException(); }
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public SqlBinary ToSqlBinary() { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlGuid value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlGuid (byte[] value) {}
//ctor: 
public SqlGuid (string s) {}
//ctor: 
public SqlGuid (Guid g) {}
//ctor: 
public SqlGuid (int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) {}
   public virtual bool IsNull { get; }
   public Guid Value { get; }
// Field: 
public static readonly SqlGuid Null;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("0ec8c218-f79c-3569-9373-ba55034959b5")]
  public sealed struct SqlInt16 : System.ValueType INullable, System.IComparable
{
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlInt16 Parse(string s) { throw new NotImplementedException(); }
    public static SqlInt16 OnesComplement(System.Data.SqlTypes.SqlInt16 x) { throw new NotImplementedException(); }
    public static SqlInt16 Add(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlInt16 Subtract(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlInt16 Multiply(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlInt16 Divide(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlInt16 Mod(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlInt16 Modulus(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlInt16 BitwiseAnd(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlInt16 BitwiseOr(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlInt16 Xor(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlInt16 x, SqlInt16 y) { throw new NotImplementedException(); }
    public SqlBoolean ToSqlBoolean() { throw new NotImplementedException(); }
    public SqlByte ToSqlByte() { throw new NotImplementedException(); }
    public SqlDouble ToSqlDouble() { throw new NotImplementedException(); }
    public SqlInt32 ToSqlInt32() { throw new NotImplementedException(); }
    public SqlInt64 ToSqlInt64() { throw new NotImplementedException(); }
    public SqlMoney ToSqlMoney() { throw new NotImplementedException(); }
    public SqlDecimal ToSqlDecimal() { throw new NotImplementedException(); }
    public SqlSingle ToSqlSingle() { throw new NotImplementedException(); }
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlInt16 value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlInt16 (short value) {}
   public virtual bool IsNull { get; }
   public short Value { get; }
// Field: 
public static readonly SqlInt16 Null;
// Field: 
public static readonly SqlInt16 Zero;
// Field: 
public static readonly SqlInt16 MinValue;
// Field: 
public static readonly SqlInt16 MaxValue;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("e155df44-29db-365f-893b-e40a2b4e9ef5")]
  public sealed struct SqlInt32 : System.ValueType INullable, System.IComparable
{
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlInt32 Parse(string s) { throw new NotImplementedException(); }
    public static SqlInt32 OnesComplement(System.Data.SqlTypes.SqlInt32 x) { throw new NotImplementedException(); }
    public static SqlInt32 Add(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlInt32 Subtract(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlInt32 Multiply(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlInt32 Divide(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlInt32 Mod(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlInt32 Modulus(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlInt32 BitwiseAnd(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlInt32 BitwiseOr(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlInt32 Xor(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlInt32 x, SqlInt32 y) { throw new NotImplementedException(); }
    public SqlBoolean ToSqlBoolean() { throw new NotImplementedException(); }
    public SqlByte ToSqlByte() { throw new NotImplementedException(); }
    public SqlDouble ToSqlDouble() { throw new NotImplementedException(); }
    public SqlInt16 ToSqlInt16() { throw new NotImplementedException(); }
    public SqlInt64 ToSqlInt64() { throw new NotImplementedException(); }
    public SqlMoney ToSqlMoney() { throw new NotImplementedException(); }
    public SqlDecimal ToSqlDecimal() { throw new NotImplementedException(); }
    public SqlSingle ToSqlSingle() { throw new NotImplementedException(); }
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlInt32 value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlInt32 (int value) {}
   public virtual bool IsNull { get; }
   public int Value { get; }
// Field: 
public static readonly SqlInt32 Null;
// Field: 
public static readonly SqlInt32 Zero;
// Field: 
public static readonly SqlInt32 MinValue;
// Field: 
public static readonly SqlInt32 MaxValue;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("2e8b4f40-0826-3c46-8311-15b57a5d5a3f")]
  public sealed struct SqlInt64 : System.ValueType INullable, System.IComparable
{
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlInt64 Parse(string s) { throw new NotImplementedException(); }
    public static SqlInt64 OnesComplement(System.Data.SqlTypes.SqlInt64 x) { throw new NotImplementedException(); }
    public static SqlInt64 Add(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlInt64 Subtract(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlInt64 Multiply(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlInt64 Divide(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlInt64 Mod(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlInt64 Modulus(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlInt64 BitwiseAnd(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlInt64 BitwiseOr(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlInt64 Xor(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlInt64 x, SqlInt64 y) { throw new NotImplementedException(); }
    public SqlBoolean ToSqlBoolean() { throw new NotImplementedException(); }
    public SqlByte ToSqlByte() { throw new NotImplementedException(); }
    public SqlDouble ToSqlDouble() { throw new NotImplementedException(); }
    public SqlInt16 ToSqlInt16() { throw new NotImplementedException(); }
    public SqlInt32 ToSqlInt32() { throw new NotImplementedException(); }
    public SqlMoney ToSqlMoney() { throw new NotImplementedException(); }
    public SqlDecimal ToSqlDecimal() { throw new NotImplementedException(); }
    public SqlSingle ToSqlSingle() { throw new NotImplementedException(); }
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlInt64 value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlInt64 (long value) {}
   public virtual bool IsNull { get; }
   public long Value { get; }
// Field: 
public static readonly SqlInt64 Null;
// Field: 
public static readonly SqlInt64 Zero;
// Field: 
public static readonly SqlInt64 MinValue;
// Field: 
public static readonly SqlInt64 MaxValue;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("d111ca54-9396-3f9d-b3ce-fbfb005b3190")]
  public sealed struct SqlMoney : System.ValueType INullable, System.IComparable
{
    public decimal ToDecimal() { throw new NotImplementedException(); }
    public long ToInt64() { throw new NotImplementedException(); }
    public int ToInt32() { throw new NotImplementedException(); }
    public double ToDouble() { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlMoney Parse(string s) { throw new NotImplementedException(); }
    public static SqlMoney Add(System.Data.SqlTypes.SqlMoney x, SqlMoney y) { throw new NotImplementedException(); }
    public static SqlMoney Subtract(System.Data.SqlTypes.SqlMoney x, SqlMoney y) { throw new NotImplementedException(); }
    public static SqlMoney Multiply(System.Data.SqlTypes.SqlMoney x, SqlMoney y) { throw new NotImplementedException(); }
    public static SqlMoney Divide(System.Data.SqlTypes.SqlMoney x, SqlMoney y) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlMoney x, SqlMoney y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlMoney x, SqlMoney y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlMoney x, SqlMoney y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlMoney x, SqlMoney y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlMoney x, SqlMoney y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlMoney x, SqlMoney y) { throw new NotImplementedException(); }
    public SqlBoolean ToSqlBoolean() { throw new NotImplementedException(); }
    public SqlByte ToSqlByte() { throw new NotImplementedException(); }
    public SqlDouble ToSqlDouble() { throw new NotImplementedException(); }
    public SqlInt16 ToSqlInt16() { throw new NotImplementedException(); }
    public SqlInt32 ToSqlInt32() { throw new NotImplementedException(); }
    public SqlInt64 ToSqlInt64() { throw new NotImplementedException(); }
    public SqlDecimal ToSqlDecimal() { throw new NotImplementedException(); }
    public SqlSingle ToSqlSingle() { throw new NotImplementedException(); }
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlMoney value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlMoney (int value) {}
//ctor: 
public SqlMoney (long value) {}
//ctor: 
public SqlMoney (decimal value) {}
//ctor: 
public SqlMoney (double value) {}
   public virtual bool IsNull { get; }
   public decimal Value { get; }
// Field: 
public static readonly SqlMoney Null;
// Field: 
public static readonly SqlMoney Zero;
// Field: 
public static readonly SqlMoney MinValue;
// Field: 
public static readonly SqlMoney MaxValue;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("0251a5cb-f1ed-32b0-8dd4-b394e93c5296")]
  public sealed struct SqlSingle : System.ValueType INullable, System.IComparable
{
    public override string ToString() { throw new NotImplementedException(); }
    public static SqlSingle Parse(string s) { throw new NotImplementedException(); }
    public static SqlSingle Add(System.Data.SqlTypes.SqlSingle x, SqlSingle y) { throw new NotImplementedException(); }
    public static SqlSingle Subtract(System.Data.SqlTypes.SqlSingle x, SqlSingle y) { throw new NotImplementedException(); }
    public static SqlSingle Multiply(System.Data.SqlTypes.SqlSingle x, SqlSingle y) { throw new NotImplementedException(); }
    public static SqlSingle Divide(System.Data.SqlTypes.SqlSingle x, SqlSingle y) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlSingle x, SqlSingle y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlSingle x, SqlSingle y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlSingle x, SqlSingle y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlSingle x, SqlSingle y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlSingle x, SqlSingle y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlSingle x, SqlSingle y) { throw new NotImplementedException(); }
    public SqlBoolean ToSqlBoolean() { throw new NotImplementedException(); }
    public SqlByte ToSqlByte() { throw new NotImplementedException(); }
    public SqlDouble ToSqlDouble() { throw new NotImplementedException(); }
    public SqlInt16 ToSqlInt16() { throw new NotImplementedException(); }
    public SqlInt32 ToSqlInt32() { throw new NotImplementedException(); }
    public SqlInt64 ToSqlInt64() { throw new NotImplementedException(); }
    public SqlMoney ToSqlMoney() { throw new NotImplementedException(); }
    public SqlDecimal ToSqlDecimal() { throw new NotImplementedException(); }
    public SqlString ToSqlString() { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlSingle value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlSingle (float value) {}
//ctor: 
public SqlSingle (double value) {}
   public virtual bool IsNull { get; }
   public float Value { get; }
// Field: 
public static readonly SqlSingle Null;
// Field: 
public static readonly SqlSingle Zero;
// Field: 
public static readonly SqlSingle MinValue;
// Field: 
public static readonly SqlSingle MaxValue;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("fadffb2a-5f63-3f3e-b1fb-7a121004bbc7")]
  public sealed enum SqlCompareOptions : System.Enum
{
    public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("0fa2b4f2-6691-3c4d-b166-106258fbe372")]
  public sealed struct SqlString : System.ValueType INullable, System.IComparable
{
    public override string ToString() { throw new NotImplementedException(); }
    public byte[] GetUnicodeBytes() { throw new NotImplementedException(); }
    public byte[] GetNonUnicodeBytes() { throw new NotImplementedException(); }
    public SqlString Clone() { throw new NotImplementedException(); }
    public static SqlString Concat(System.Data.SqlTypes.SqlString x, SqlString y) { throw new NotImplementedException(); }
    public static SqlString Add(System.Data.SqlTypes.SqlString x, SqlString y) { throw new NotImplementedException(); }
    public static SqlBoolean Equals(System.Data.SqlTypes.SqlString x, SqlString y) { throw new NotImplementedException(); }
    public static SqlBoolean NotEquals(System.Data.SqlTypes.SqlString x, SqlString y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThan(System.Data.SqlTypes.SqlString x, SqlString y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThan(System.Data.SqlTypes.SqlString x, SqlString y) { throw new NotImplementedException(); }
    public static SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlString x, SqlString y) { throw new NotImplementedException(); }
    public static SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlString x, SqlString y) { throw new NotImplementedException(); }
    public SqlBoolean ToSqlBoolean() { throw new NotImplementedException(); }
    public SqlByte ToSqlByte() { throw new NotImplementedException(); }
    public SqlDateTime ToSqlDateTime() { throw new NotImplementedException(); }
    public SqlDouble ToSqlDouble() { throw new NotImplementedException(); }
    public SqlInt16 ToSqlInt16() { throw new NotImplementedException(); }
    public SqlInt32 ToSqlInt32() { throw new NotImplementedException(); }
    public SqlInt64 ToSqlInt64() { throw new NotImplementedException(); }
    public SqlMoney ToSqlMoney() { throw new NotImplementedException(); }
    public SqlDecimal ToSqlDecimal() { throw new NotImplementedException(); }
    public SqlSingle ToSqlSingle() { throw new NotImplementedException(); }
    public SqlGuid ToSqlGuid() { throw new NotImplementedException(); }
    public static System.Globalization.CompareOptions CompareOptionsFromSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions) { throw new NotImplementedException(); }
    public virtual int CompareTo(object value) { throw new NotImplementedException(); }
    public int CompareTo(System.Data.SqlTypes.SqlString value) { throw new NotImplementedException(); }
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlString (int lcid, SqlCompareOptions compareOptions, byte[] data, int index, int count, bool fUnicode) {}
//ctor: 
public SqlString (int lcid, SqlCompareOptions compareOptions, byte[] data, bool fUnicode) {}
//ctor: 
public SqlString (int lcid, SqlCompareOptions compareOptions, byte[] data, int index, int count) {}
//ctor: 
public SqlString (int lcid, SqlCompareOptions compareOptions, byte[] data) {}
//ctor: 
public SqlString (string data, int lcid, SqlCompareOptions compareOptions) {}
//ctor: 
public SqlString (string data, int lcid) {}
//ctor: 
public SqlString (string data) {}
   public virtual bool IsNull { get; }
   public string Value { get; }
   public int LCID { get; }
   public System.Globalization.CultureInfo CultureInfo { get; }
   public System.Globalization.CompareInfo CompareInfo { get; }
   public SqlCompareOptions SqlCompareOptions { get; }
// Field: 
public static readonly SqlString Null;
// Field: 
public static readonly int IgnoreCase;
// Field: 
public static readonly int IgnoreWidth;
// Field: 
public static readonly int IgnoreNonSpace;
// Field: 
public static readonly int IgnoreKanaType;
// Field: 
public static readonly int BinarySort;
// Field: 
public static readonly int BinarySort2;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("ef3200db-fc8d-391f-b81a-ce9bf2b2125b")]
  public sealed enum StorageState : System.Enum
{
    public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("efbc0566-4a2c-3561-bc12-85959c7cc12b")]
  public class SqlTypeException : System.Exception
{
    public virtual override Exception GetBaseException() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
    public virtual override Type GetType() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlTypeException () {}
//ctor: 
public SqlTypeException (string message) {}
//ctor: 
public SqlTypeException (string message, Exception e) {}
   public virtual string Message { get; }
   public virtual System.Collections.IDictionary Data { get; }
   public virtual Exception InnerException { get; }
   public virtual System.Reflection.MethodBase TargetSite { get; }
   public virtual string StackTrace { get; }
   public virtual string HelpLink { get; set; }
   public virtual string Source { get; set; }
   public int HResult { get; }
//Event: 
protected event EventHandler<System.Runtime.Serialization.SafeSerializationEventArgs> SerializeObjectState;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("3974af07-0db4-370a-9ea0-99ccb3e40c09")]
  public sealed class SqlNullValueException : SqlTypeException
{
    public virtual override Exception GetBaseException() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
    public virtual override Type GetType() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlNullValueException () {}
//ctor: 
public SqlNullValueException (string message) {}
//ctor: 
public SqlNullValueException (string message, Exception e) {}
   public virtual string Message { get; }
   public virtual System.Collections.IDictionary Data { get; }
   public virtual Exception InnerException { get; }
   public virtual System.Reflection.MethodBase TargetSite { get; }
   public virtual string StackTrace { get; }
   public virtual string HelpLink { get; set; }
   public virtual string Source { get; set; }
   public int HResult { get; }
//Event: 
protected event EventHandler<System.Runtime.Serialization.SafeSerializationEventArgs> SerializeObjectState;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("00616cd8-d635-330f-8611-65d47c5328a0")]
  public sealed class SqlTruncateException : SqlTypeException
{
    public virtual override Exception GetBaseException() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
    public virtual override Type GetType() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlTruncateException () {}
//ctor: 
public SqlTruncateException (string message) {}
//ctor: 
public SqlTruncateException (string message, Exception e) {}
   public virtual string Message { get; }
   public virtual System.Collections.IDictionary Data { get; }
   public virtual Exception InnerException { get; }
   public virtual System.Reflection.MethodBase TargetSite { get; }
   public virtual string StackTrace { get; }
   public virtual string HelpLink { get; set; }
   public virtual string Source { get; set; }
   public int HResult { get; }
//Event: 
protected event EventHandler<System.Runtime.Serialization.SafeSerializationEventArgs> SerializeObjectState;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("27fe2ac1-f35e-3435-b118-6ac5bdde9f11")]
  public sealed class SqlXml : System.Object INullable
{
    public System.Xml.XmlReader CreateReader() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlXml () {}
//ctor: 
public SqlXml (System.Xml.XmlReader value) {}
//ctor: 
public SqlXml (System.IO.Stream value) {}
   public virtual bool IsNull { get; }
   public string Value { get; }
   public static SqlXml Null { get; }
  }
