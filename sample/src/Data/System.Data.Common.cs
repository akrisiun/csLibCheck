
namespace System
{
    public class GuidAttribute : Attribute 
    {
        public GuidAttribute(string guid) {}
    }
}

namespace System.Data.Common
{  

// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("54e76ba8-fdad-397c-9525-69db30dd815f")]
  public abstract class DbCommand : System.Data.IDbCommand
{
    protected override void Finalize() {}
    public abstract void Cancel() {}
    public DbParameter CreateParameter() { throw new NotImplementedException(); }
    protected abstract DbParameter CreateDbParameter() { throw new NotImplementedException(); }
    protected abstract DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { throw new NotImplementedException(); }
    public abstract int ExecuteNonQuery() { throw new NotImplementedException(); }
    public DbDataReader ExecuteReader() { throw new NotImplementedException(); }
    public DbDataReader ExecuteReader(System.Data.CommandBehavior behavior) { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task<int> ExecuteNonQueryAsync() { throw new NotImplementedException(); }
    public virtual System.Threading.Tasks.Task<int> ExecuteNonQueryAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync() { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior) { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    protected virtual System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteDbDataReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task<object> ExecuteScalarAsync() { throw new NotImplementedException(); }
    public virtual System.Threading.Tasks.Task<object> ExecuteScalarAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public abstract object ExecuteScalar() { throw new NotImplementedException(); }
    public abstract void Prepare() {}
    public virtual void Dispose() {}
    protected virtual void Dispose(bool disposing) {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
protected DbCommand () {}
   public abstract string CommandText { get; set; }
   public abstract int CommandTimeout { get; set; }
   public abstract System.Data.CommandType CommandType { get; set; }
   public DbConnection Connection { get; set; }
   protected abstract DbConnection DbConnection { }
   protected abstract DbParameterCollection DbParameterCollection { }
   protected abstract DbTransaction DbTransaction { }
   public abstract bool DesignTimeVisible { get; set; }
   public DbParameterCollection Parameters { get; }
   public DbTransaction Transaction { get; set; }
   public abstract System.Data.UpdateRowSource UpdatedRowSource { get; set; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("bf466bea-eacb-301f-a6f3-d552589dd3cd")]
  public abstract class DbConnection : System.Data.IDbConnection
{
    protected override void Finalize() {}
    protected abstract DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel) { throw new NotImplementedException(); }
    public DbTransaction BeginTransaction() { throw new NotImplementedException(); }
    public DbTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel) { throw new NotImplementedException(); }
    public abstract void Close() {}
    public abstract void ChangeDatabase(string databaseName) {}
    public DbCommand CreateCommand() { throw new NotImplementedException(); }
    protected abstract DbCommand CreateDbCommand() { throw new NotImplementedException(); }
    protected virtual void OnStateChange(System.Data.StateChangeEventArgs stateChange) {}
    public abstract void Open() {}
    public System.Threading.Tasks.Task OpenAsync() { throw new NotImplementedException(); }
    public virtual System.Threading.Tasks.Task OpenAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public virtual void Dispose() {}
    protected virtual void Dispose(bool disposing) {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
protected DbConnection () {}
   public abstract string ConnectionString { get; set; }
   public virtual int ConnectionTimeout { get; }
   public abstract string Database { get; }
   public abstract string DataSource { get; }
   public abstract string ServerVersion { get; }
   public abstract System.Data.ConnectionState State { get; }
//Event: 
public event System.Data.StateChangeEventHandler StateChange { add; remove; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("fac3ccf3-aae3-3f77-b9b2-8faa667bc813")]
  public class DbConnectionStringBuilder : System.Collections.IDictionary
{
    public void Add(string keyword, object value) {}
    public static void AppendKeyValuePair(System.Text.StringBuilder builder, string keyword, string value) {}
    public virtual void Clear() {}
    public virtual bool ContainsKey(string keyword) { throw new NotImplementedException(); }
    public virtual bool EquivalentTo(System.Data.Common.DbConnectionStringBuilder connectionStringBuilder) { throw new NotImplementedException(); }
    public virtual bool Remove(string keyword) { throw new NotImplementedException(); }
    public virtual bool ShouldSerialize(string keyword) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual bool TryGetValue(string keyword, out object value) { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public DbConnectionStringBuilder () {}
   public virtual object this [string keyword] { get; set; }
   public string ConnectionString { get; set; }
   public virtual int Count { get; }
   public virtual bool IsReadOnly { get; }
   public virtual bool IsFixedSize { get; }
   public virtual System.Collections.ICollection Keys { get; }
   public virtual System.Collections.ICollection Values { get; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("4f6e6dba-cd87-33bc-81a1-6a8d24b81303")]
  public abstract class DbDataReader : System.Data.IDataReader, System.Collections.IEnumerable
{
    public virtual void Dispose() {}
    protected virtual void Dispose(bool disposing) {}
    public abstract string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
    public abstract System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
    public abstract Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
    public abstract string GetName(int ordinal) { throw new NotImplementedException(); }
    public abstract int GetOrdinal(string name) { throw new NotImplementedException(); }
    public abstract bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
    public abstract byte GetByte(int ordinal) { throw new NotImplementedException(); }
    public abstract long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
    public abstract char GetChar(int ordinal) { throw new NotImplementedException(); }
    public abstract long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
    public DbDataReader GetData(int ordinal) { throw new NotImplementedException(); }
    protected virtual DbDataReader GetDbDataReader(int ordinal) { throw new NotImplementedException(); }
    public abstract DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
    public abstract decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
    public abstract double GetDouble(int ordinal) { throw new NotImplementedException(); }
    public abstract float GetFloat(int ordinal) { throw new NotImplementedException(); }
    public abstract Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
    public abstract short GetInt16(int ordinal) { throw new NotImplementedException(); }
    public abstract int GetInt32(int ordinal) { throw new NotImplementedException(); }
    public abstract long GetInt64(int ordinal) { throw new NotImplementedException(); }
    public virtual Type GetProviderSpecificFieldType(int ordinal) { throw new NotImplementedException(); }
    public virtual object GetProviderSpecificValue(int ordinal) { throw new NotImplementedException(); }
    public virtual int GetProviderSpecificValues(object[] values) { throw new NotImplementedException(); }
    public abstract string GetString(int ordinal) { throw new NotImplementedException(); }
    public virtual System.IO.Stream GetStream(int ordinal) { throw new NotImplementedException(); }
    public virtual System.IO.TextReader GetTextReader(int ordinal) { throw new NotImplementedException(); }
    public abstract object GetValue(int ordinal) { throw new NotImplementedException(); }
    public virtual GetFieldValue(int ordinal) { throw new NotImplementedException(); }
    public GetFieldValueAsync(int ordinal) { throw new NotImplementedException(); }
    public virtual GetFieldValueAsync(int ordinal, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public abstract int GetValues(object[] values) { throw new NotImplementedException(); }
    public abstract bool IsDBNull(int ordinal) { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal) { throw new NotImplementedException(); }
    public virtual System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public abstract bool NextResult() { throw new NotImplementedException(); }
    public abstract bool Read() { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task<bool> ReadAsync() { throw new NotImplementedException(); }
    public virtual System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task<bool> NextResultAsync() { throw new NotImplementedException(); }
    public virtual System.Threading.Tasks.Task<bool> NextResultAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public virtual void Close() {}
    public virtual System.Data.DataTable GetSchemaTable() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
protected DbDataReader () {}
   public abstract int Depth { get; }
   public abstract int FieldCount { get; }
   public abstract bool HasRows { get; }
   public abstract bool IsClosed { get; }
   public abstract int RecordsAffected { get; }
   public virtual int VisibleFieldCount { get; }
   public abstract object this [int ordinal] { get; }
   public abstract object this [string name] { get; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("3547b78b-9b5d-37ee-85de-3e4a508d2e32")]
  public abstract class DbException : System.Exception
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
protected DbException () {}
//ctor: 
protected DbException (string message) {}
//ctor: 
protected DbException (string message, Exception innerException) {}
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


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("d5dd8047-b6f2-3773-95b1-f76c195a37a6")]
  public abstract class DbParameter : System.Data.IDbDataParameter
{
    public abstract void ResetDbType() {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
protected DbParameter () {}
   public abstract System.Data.DbType DbType { get; set; }
   public abstract System.Data.ParameterDirection Direction { get; set; }
   public abstract bool IsNullable { get; set; }
   public abstract string ParameterName { get; set; }
   public virtual byte Precision { get; set; }
   public virtual byte Scale { get; set; }
   public abstract int Size { get; set; }
   public abstract string SourceColumn { get; set; }
   public abstract bool SourceColumnNullMapping { get; set; }
   public abstract object Value { get; set; }
   public virtual System.Data.DataRowVersion SourceVersion { get; set; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("c05eb7ff-deab-3b7c-89c9-efcc27e348af")]
  public abstract class DbParameterCollection : System.Data.IDataParameterCollection
{
    public abstract int Add(object value) { throw new NotImplementedException(); }
    public abstract void AddRange(Array values) {}
    public abstract bool Contains(object value) { throw new NotImplementedException(); }
    public abstract bool Contains(string value) { throw new NotImplementedException(); }
    public abstract void CopyTo(Array array, int index) {}
    public abstract void Clear() {}
    public abstract System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
    protected abstract DbParameter GetParameter(int index) { throw new NotImplementedException(); }
    protected abstract DbParameter GetParameter(string parameterName) { throw new NotImplementedException(); }
    public abstract int IndexOf(object value) { throw new NotImplementedException(); }
    public abstract int IndexOf(string parameterName) { throw new NotImplementedException(); }
    public abstract void Insert(int index, object value) {}
    public abstract void Remove(object value) {}
    public abstract void RemoveAt(int index) {}
    public abstract void RemoveAt(string parameterName) {}
    protected abstract void SetParameter(int index, DbParameter value) {}
    protected abstract void SetParameter(string parameterName, DbParameter value) {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
protected DbParameterCollection () {}
   public abstract int Count { get; }
   public virtual bool IsReadOnly { get; }
   public virtual bool IsSynchronized { get; }
   public abstract object SyncRoot { get; }
   public DbParameter this [int index] { get; set; }
   public DbParameter this [string parameterName] { get; set; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("0ff203b5-218c-3775-8ada-99f730ab1712")]
  public abstract class DbProviderFactory : System.Object
{
    public virtual DbCommand CreateCommand() { throw new NotImplementedException(); }
    public virtual DbConnection CreateConnection() { throw new NotImplementedException(); }
    public virtual DbConnectionStringBuilder CreateConnectionStringBuilder() { throw new NotImplementedException(); }
    public virtual DbParameter CreateParameter() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
protected DbProviderFactory () {}
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("4a00f704-97ec-37f2-948e-5fe24414bf10")]
  public abstract class DbTransaction : System.Data.IDbTransaction
{
    public abstract void Commit() {}
    public virtual void Dispose() {}
    protected virtual void Dispose(bool disposing) {}
    public abstract void Rollback() {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
protected DbTransaction () {}
   public DbConnection Connection { get; }
   protected abstract DbConnection DbConnection { }
   public abstract System.Data.IsolationLevel IsolationLevel { get; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("11e628fd-f6ba-3426-b850-fe7d3abde124")]
  public abstract sealed class DbDataReaderExtensions : System.Object
{
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.DbColumn> GetColumnSchema(System.Data.Common.DbDataReader reader) { throw new NotImplementedException(); }
    public static bool CanGetColumnSchema(System.Data.Common.DbDataReader reader) { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("0f041571-135f-336b-81e9-f4218301209d")]
  public abstract class DbDataRecord : System.Data.IDataRecord
{
    public abstract bool GetBoolean(int i) { throw new NotImplementedException(); }
    public abstract byte GetByte(int i) { throw new NotImplementedException(); }
    public abstract long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length) { throw new NotImplementedException(); }
    public abstract char GetChar(int i) { throw new NotImplementedException(); }
    public abstract long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length) { throw new NotImplementedException(); }
    protected virtual DbDataReader GetDbDataReader(int i) { throw new NotImplementedException(); }
    public abstract string GetDataTypeName(int i) { throw new NotImplementedException(); }
    public abstract DateTime GetDateTime(int i) { throw new NotImplementedException(); }
    public abstract decimal GetDecimal(int i) { throw new NotImplementedException(); }
    public abstract double GetDouble(int i) { throw new NotImplementedException(); }
    public abstract Type GetFieldType(int i) { throw new NotImplementedException(); }
    public abstract float GetFloat(int i) { throw new NotImplementedException(); }
    public abstract Guid GetGuid(int i) { throw new NotImplementedException(); }
    public abstract short GetInt16(int i) { throw new NotImplementedException(); }
    public abstract int GetInt32(int i) { throw new NotImplementedException(); }
    public abstract long GetInt64(int i) { throw new NotImplementedException(); }
    public abstract string GetName(int i) { throw new NotImplementedException(); }
    public abstract int GetOrdinal(string name) { throw new NotImplementedException(); }
    public abstract string GetString(int i) { throw new NotImplementedException(); }
    public abstract object GetValue(int i) { throw new NotImplementedException(); }
    public abstract int GetValues(object[] values) { throw new NotImplementedException(); }
    public abstract bool IsDBNull(int i) { throw new NotImplementedException(); }
    public virtual System.Data.IDataReader GetData(int i) { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
protected DbDataRecord () {}
   public abstract int FieldCount { get; }
   public abstract object this [int i] { get; }
   public abstract object this [string name] { get; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("37fb2a7c-676f-31b0-ba2b-1ac00a722522")]
  public abstract class DbColumn : System.Object
{
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
protected DbColumn () {}
   public System.Nullable<System.Boolean> AllowDBNull { get; }
   public string BaseCatalogName { get; }
   public string BaseColumnName { get; }
   public string BaseSchemaName { get; }
   public string BaseServerName { get; }
   public string BaseTableName { get; }
   public string ColumnName { get; }
   public System.Nullable<System.Int32> ColumnOrdinal { get; }
   public System.Nullable<System.Int32> ColumnSize { get; }
   public System.Nullable<System.Boolean> IsAliased { get; }
   public System.Nullable<System.Boolean> IsAutoIncrement { get; }
   public System.Nullable<System.Boolean> IsExpression { get; }
   public System.Nullable<System.Boolean> IsHidden { get; }
   public System.Nullable<System.Boolean> IsIdentity { get; }
   public System.Nullable<System.Boolean> IsKey { get; }
   public System.Nullable<System.Boolean> IsLong { get; }
   public System.Nullable<System.Boolean> IsReadOnly { get; }
   public System.Nullable<System.Boolean> IsUnique { get; }
   public System.Nullable<System.Int32> NumericPrecision { get; }
   public System.Nullable<System.Int32> NumericScale { get; }
   public string UdtAssemblyQualifiedName { get; }
   public Type DataType { get; }
   public string DataTypeName { get; }
   public virtual object this [string property] { get; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("59aed2d8-a48c-3e29-ab58-f5400cdaf8f2")]
  public interface IDbColumnSchemaGenerator
{
    System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.DbColumn> GetColumnSchema() { throw new NotImplementedException(); }
  }
}


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("41296ce6-89cc-354a-9315-91f7a1fe9a41")]
  public class DbEnumerator : System.Collections.IEnumerator
{
    public virtual bool MoveNext() { throw new NotImplementedException(); }
    public virtual void Reset() {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public DbEnumerator (System.Data.Common.DbDataReader reader, bool closeReader) {}
   public virtual object Current { get; }
  }

}