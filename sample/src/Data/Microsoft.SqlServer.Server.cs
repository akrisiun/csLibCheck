
using System;
namespace Microsoft.SqlServer.Server
{

    // Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
    [Guid("d65ccb00-437f-32b6-8718-dd115bd8b00c")]
    public class SqlDataRecord : System.Object
    {
        public virtual string GetName(int ordinal) { throw new NotImplementedException(); }
        public virtual string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
        public virtual Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
        public virtual object GetValue(int ordinal) { throw new NotImplementedException(); }
        public virtual int GetValues(object[] values) { throw new NotImplementedException(); }
        public virtual int GetOrdinal(string name) { throw new NotImplementedException(); }
        public virtual bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
        public virtual byte GetByte(int ordinal) { throw new NotImplementedException(); }
        public virtual long GetBytes(int ordinal, long fieldOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
        public virtual char GetChar(int ordinal) { throw new NotImplementedException(); }
        public virtual long GetChars(int ordinal, long fieldOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
        public virtual Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
        public virtual short GetInt16(int ordinal) { throw new NotImplementedException(); }
        public virtual int GetInt32(int ordinal) { throw new NotImplementedException(); }
        public virtual long GetInt64(int ordinal) { throw new NotImplementedException(); }
        public virtual float GetFloat(int ordinal) { throw new NotImplementedException(); }
        public virtual double GetDouble(int ordinal) { throw new NotImplementedException(); }
        public virtual string GetString(int ordinal) { throw new NotImplementedException(); }
        public virtual decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
        public virtual DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
        public virtual DateTimeOffset GetDateTimeOffset(int ordinal) { throw new NotImplementedException(); }
        public virtual TimeSpan GetTimeSpan(int ordinal) { throw new NotImplementedException(); }
        public virtual bool IsDBNull(int ordinal) { throw new NotImplementedException(); }
        public virtual SqlMetaData GetSqlMetaData(int ordinal) { throw new NotImplementedException(); }
        public virtual Type GetSqlFieldType(int ordinal) { throw new NotImplementedException(); }
        public virtual object GetSqlValue(int ordinal) { throw new NotImplementedException(); }
        public virtual int GetSqlValues(object[] values) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlBinary GetSqlBinary(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlBytes GetSqlBytes(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlXml GetSqlXml(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlBoolean GetSqlBoolean(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlByte GetSqlByte(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlChars GetSqlChars(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlInt16 GetSqlInt16(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlInt32 GetSqlInt32(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlInt64 GetSqlInt64(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlSingle GetSqlSingle(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlDouble GetSqlDouble(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlMoney GetSqlMoney(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlDateTime GetSqlDateTime(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlDecimal GetSqlDecimal(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlString GetSqlString(int ordinal) { throw new NotImplementedException(); }
        public virtual System.Data.SqlTypes.SqlGuid GetSqlGuid(int ordinal) { throw new NotImplementedException(); }
        public virtual int SetValues(object[] values) { throw new NotImplementedException(); }
        public virtual void SetValue(int ordinal, object value) { }
        public virtual void SetBoolean(int ordinal, bool value) { }
        public virtual void SetByte(int ordinal, byte value) { }
        public virtual void SetBytes(int ordinal, long fieldOffset, byte[] buffer, int bufferOffset, int length) { }
        public virtual void SetChar(int ordinal, char value) { }
        public virtual void SetChars(int ordinal, long fieldOffset, char[] buffer, int bufferOffset, int length) { }
        public virtual void SetInt16(int ordinal, short value) { }
        public virtual void SetInt32(int ordinal, int value) { }
        public virtual void SetInt64(int ordinal, long value) { }
        public virtual void SetFloat(int ordinal, float value) { }
        public virtual void SetDouble(int ordinal, double value) { }
        public virtual void SetString(int ordinal, string value) { }
        public virtual void SetDecimal(int ordinal, decimal value) { }
        public virtual void SetDateTime(int ordinal, DateTime value) { }
        public virtual void SetTimeSpan(int ordinal, TimeSpan value) { }
        public virtual void SetDateTimeOffset(int ordinal, DateTimeOffset value) { }
        public virtual void SetDBNull(int ordinal) { }
        public virtual void SetGuid(int ordinal, Guid value) { }
        public virtual void SetSqlBoolean(int ordinal, System.Data.SqlTypes.SqlBoolean value) { }
        public virtual void SetSqlByte(int ordinal, System.Data.SqlTypes.SqlByte value) { }
        public virtual void SetSqlInt16(int ordinal, System.Data.SqlTypes.SqlInt16 value) { }
        public virtual void SetSqlInt32(int ordinal, System.Data.SqlTypes.SqlInt32 value) { }
        public virtual void SetSqlInt64(int ordinal, System.Data.SqlTypes.SqlInt64 value) { }
        public virtual void SetSqlSingle(int ordinal, System.Data.SqlTypes.SqlSingle value) { }
        public virtual void SetSqlDouble(int ordinal, System.Data.SqlTypes.SqlDouble value) { }
        public virtual void SetSqlMoney(int ordinal, System.Data.SqlTypes.SqlMoney value) { }
        public virtual void SetSqlDateTime(int ordinal, System.Data.SqlTypes.SqlDateTime value) { }
        public virtual void SetSqlXml(int ordinal, System.Data.SqlTypes.SqlXml value) { }
        public virtual void SetSqlDecimal(int ordinal, System.Data.SqlTypes.SqlDecimal value) { }
        public virtual void SetSqlString(int ordinal, System.Data.SqlTypes.SqlString value) { }
        public virtual void SetSqlBinary(int ordinal, System.Data.SqlTypes.SqlBinary value) { }
        public virtual void SetSqlGuid(int ordinal, System.Data.SqlTypes.SqlGuid value) { }
        public virtual void SetSqlChars(int ordinal, System.Data.SqlTypes.SqlChars value) { }
        public virtual void SetSqlBytes(int ordinal, System.Data.SqlTypes.SqlBytes value) { }
        public virtual override string ToString() { throw new NotImplementedException(); }
        public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
        public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
        public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
        public virtual override int GetHashCode() { throw new NotImplementedException(); }
        public override Type GetType() { throw new NotImplementedException(); }
        protected virtual override void Finalize() { }
        protected override object MemberwiseClone() { throw new NotImplementedException(); }
        //ctor: 
        public SqlDataRecord(Microsoft.SqlServer.Server.SqlMetaData[] metaData) { }
        public virtual int FieldCount { get; }
        public virtual object this[int ordinal] { get; }
        public virtual object this[string name] { get; }
    }


    // Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
    [Guid("ffa01f6c-c701-3260-97e2-fa366566c74e")]
    public sealed class SqlMetaData : System.Object
    {
        public short Adjust(short value) { throw new NotImplementedException(); }
        public int Adjust(int value) { throw new NotImplementedException(); }
        public long Adjust(long value) { throw new NotImplementedException(); }
        public float Adjust(float value) { throw new NotImplementedException(); }
        public double Adjust(double value) { throw new NotImplementedException(); }
        public string Adjust(string value) { throw new NotImplementedException(); }
        public decimal Adjust(decimal value) { throw new NotImplementedException(); }
        public DateTime Adjust(DateTime value) { throw new NotImplementedException(); }
        public Guid Adjust(Guid value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlBoolean Adjust(System.Data.SqlTypes.SqlBoolean value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlByte Adjust(System.Data.SqlTypes.SqlByte value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlInt16 Adjust(System.Data.SqlTypes.SqlInt16 value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlInt32 Adjust(System.Data.SqlTypes.SqlInt32 value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlInt64 Adjust(System.Data.SqlTypes.SqlInt64 value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlSingle Adjust(System.Data.SqlTypes.SqlSingle value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlDouble Adjust(System.Data.SqlTypes.SqlDouble value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlMoney Adjust(System.Data.SqlTypes.SqlMoney value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlDateTime Adjust(System.Data.SqlTypes.SqlDateTime value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlDecimal Adjust(System.Data.SqlTypes.SqlDecimal value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlString Adjust(System.Data.SqlTypes.SqlString value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlBinary Adjust(System.Data.SqlTypes.SqlBinary value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlGuid Adjust(System.Data.SqlTypes.SqlGuid value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlChars Adjust(System.Data.SqlTypes.SqlChars value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlBytes Adjust(System.Data.SqlTypes.SqlBytes value) { throw new NotImplementedException(); }
        public System.Data.SqlTypes.SqlXml Adjust(System.Data.SqlTypes.SqlXml value) { throw new NotImplementedException(); }
        public TimeSpan Adjust(TimeSpan value) { throw new NotImplementedException(); }
        public DateTimeOffset Adjust(DateTimeOffset value) { throw new NotImplementedException(); }
        public object Adjust(object value) { throw new NotImplementedException(); }
        public static SqlMetaData InferFromValue(object value, string name) { throw new NotImplementedException(); }
        public bool Adjust(bool value) { throw new NotImplementedException(); }
        public byte Adjust(byte value) { throw new NotImplementedException(); }
        public byte[] Adjust(byte[] value) { throw new NotImplementedException(); }
        public char Adjust(char value) { throw new NotImplementedException(); }
        public char[] Adjust(char[] value) { throw new NotImplementedException(); }
        public virtual override string ToString() { throw new NotImplementedException(); }
        public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
        public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
        public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
        public virtual override int GetHashCode() { throw new NotImplementedException(); }
        public override Type GetType() { throw new NotImplementedException(); }
        protected virtual override void Finalize() { }
        protected override object MemberwiseClone() { throw new NotImplementedException(); }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType) { }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength) { }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType, byte precision, byte scale) { }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType, byte precision, byte scale, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions) { }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType, string database, string owningSchema, string objectName, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, byte precision, byte scale, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions, Type userDefinedType) { }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, byte precision, byte scale, long localeId, System.Data.SqlTypes.SqlCompareOptions compareOptions, Type userDefinedType, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        //ctor: 
        public SqlMetaData(string name, System.Data.SqlDbType dbType, string database, string owningSchema, string objectName) { }
        public System.Data.SqlTypes.SqlCompareOptions CompareOptions { get; }
        public bool IsUniqueKey { get; }
        public long LocaleId { get; }
        public static long Max { get; }
        public long MaxLength { get; }
        public string Name { get; }
        public byte Precision { get; }
        public byte Scale { get; }
        public System.Data.SqlClient.SortOrder SortOrder { get; }
        public int SortOrdinal { get; }
        public System.Data.SqlDbType SqlDbType { get; }
        public string TypeName { get; }
        public bool UseServerDefault { get; }
        public string XmlSchemaCollectionDatabase { get; }
        public string XmlSchemaCollectionName { get; }
        public string XmlSchemaCollectionOwningSchema { get; }
    }

}