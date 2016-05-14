
namespace System.Data.SqlClient
{  


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("c020380f-998c-3cfa-ae78-3ec74002d4fa")]
  public sealed enum ApplicationIntent : System.Enum
{
    public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("2bb3ef53-a041-39b4-8576-766b5f2c21f6")]
  public class SqlRowsCopiedEventArgs : System.EventArgs
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
public SqlRowsCopiedEventArgs (long rowsCopied) {}
   public bool Abort { get; set; }
   public long RowsCopied { get; }
// Field: 
public static readonly EventArgs Empty;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("7e1ad45f-ddab-343c-9574-0a8f3be30c56")]
  public sealed delegate SqlRowsCopiedEventHandler : System.MulticastDelegate
{
    public virtual void Invoke(object sender, SqlRowsCopiedEventArgs e) {}
    public virtual IAsyncResult BeginInvoke(object sender, SqlRowsCopiedEventArgs e, AsyncCallback callback, object object) { throw new NotImplementedException(); }
    public virtual void EndInvoke(IAsyncResult result) {}
    public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    protected virtual override delegate CombineImpl(delegate follow) { throw new NotImplementedException(); }
    protected virtual override delegate RemoveImpl(delegate value) { throw new NotImplementedException(); }
    public virtual override delegate[] GetInvocationList() { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    protected virtual override System.Reflection.MethodInfo GetMethodImpl() { throw new NotImplementedException(); }
    public override object DynamicInvoke(object[] args) { throw new NotImplementedException(); }
    protected virtual override object DynamicInvokeImpl(object[] args) { throw new NotImplementedException(); }
    public static override delegate Combine(delegate a, delegate b) { throw new NotImplementedException(); }
    public static override delegate Combine(delegate[] delegates) { throw new NotImplementedException(); }
    public static override delegate Remove(delegate source, delegate value) { throw new NotImplementedException(); }
    public static override delegate RemoveAll(delegate source, delegate value) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, object target, string method) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, Type target, string method) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, System.Reflection.MethodInfo method) { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlRowsCopiedEventHandler (object object, IntPtr method) {}
   public System.Reflection.MethodInfo Method { get; }
   public object Target { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("8eb9ae38-4438-351a-9e64-242a080a8dba")]
  public sealed enum SortOrder : System.Enum
{
    public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("da4bac51-82ce-38b2-91e5-f89294114020")]
  public sealed class SqlBulkCopy : System.Object System.IDisposable
{
    public void Close() {}
    public void WriteToServer(System.Data.Common.DbDataReader reader) {}
    public System.Threading.Tasks.Task WriteToServerAsync(System.Data.Common.DbDataReader reader) { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task WriteToServerAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlBulkCopy (System.Data.SqlClient.SqlConnection connection) {}
//ctor: 
public SqlBulkCopy (System.Data.SqlClient.SqlConnection connection, SqlBulkCopyOptions copyOptions, SqlTransaction externalTransaction) {}
//ctor: 
public SqlBulkCopy (string connectionString) {}
//ctor: 
public SqlBulkCopy (string connectionString, SqlBulkCopyOptions copyOptions) {}
   public int BatchSize { get; set; }
   public int BulkCopyTimeout { get; set; }
   public bool EnableStreaming { get; set; }
   public SqlBulkCopyColumnMappingCollection ColumnMappings { get; }
   public string DestinationTableName { get; set; }
   public int NotifyAfter { get; set; }
//Event: 
public event SqlRowsCopiedEventHandler SqlRowsCopied;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("2bce9a6f-1c4b-3aef-b67d-ca1dec0cf255")]
  public sealed class SqlBulkCopyColumnMapping : System.Object
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
public SqlBulkCopyColumnMapping () {}
//ctor: 
public SqlBulkCopyColumnMapping (string sourceColumn, string destinationColumn) {}
//ctor: 
public SqlBulkCopyColumnMapping (int sourceColumnOrdinal, string destinationColumn) {}
//ctor: 
public SqlBulkCopyColumnMapping (string sourceColumn, int destinationOrdinal) {}
//ctor: 
public SqlBulkCopyColumnMapping (int sourceColumnOrdinal, int destinationOrdinal) {}
   public string DestinationColumn { get; set; }
   public int DestinationOrdinal { get; set; }
   public string SourceColumn { get; set; }
   public int SourceOrdinal { get; set; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("6bacddc2-5db8-3339-80f2-82d8db47db36")]
  public sealed class SqlBulkCopyColumnMappingCollection : System.Object System.Collections.IList
{
    public SqlBulkCopyColumnMapping Add(System.Data.SqlClient.SqlBulkCopyColumnMapping bulkCopyColumnMapping) { throw new NotImplementedException(); }
    public SqlBulkCopyColumnMapping Add(string sourceColumn, string destinationColumn) { throw new NotImplementedException(); }
    public SqlBulkCopyColumnMapping Add(int sourceColumnIndex, string destinationColumn) { throw new NotImplementedException(); }
    public SqlBulkCopyColumnMapping Add(string sourceColumn, int destinationColumnIndex) { throw new NotImplementedException(); }
    public SqlBulkCopyColumnMapping Add(int sourceColumnIndex, int destinationColumnIndex) { throw new NotImplementedException(); }
    public virtual void Clear() {}
    public bool Contains(System.Data.SqlClient.SqlBulkCopyColumnMapping value) { throw new NotImplementedException(); }
    public void CopyTo(System.Data.SqlClient.SqlBulkCopyColumnMapping[] array, int index) {}
    public virtual System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
    public int IndexOf(System.Data.SqlClient.SqlBulkCopyColumnMapping value) { throw new NotImplementedException(); }
    public void Insert(int index, SqlBulkCopyColumnMapping value) {}
    public void Remove(System.Data.SqlClient.SqlBulkCopyColumnMapping value) {}
    public virtual void RemoveAt(int index) {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   public virtual int Count { get; }
   public SqlBulkCopyColumnMapping this [int index] { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("a337617a-ad4b-3881-b3b6-738570980918")]
  public sealed enum SqlBulkCopyOptions : System.Enum
{
    public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("3f9e769a-7539-3fec-b17e-574dad22dc2d")]
  public sealed class SqlClientFactory : System.Data.Common.DbProviderFactory
{
    public override System.Data.Common.DbCommand CreateCommand() { throw new NotImplementedException(); }
    public override System.Data.Common.DbConnection CreateConnection() { throw new NotImplementedException(); }
    public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { throw new NotImplementedException(); }
    public override System.Data.Common.DbParameter CreateParameter() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
// Field: 
public static readonly SqlClientFactory Instance;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("7d5d1d29-cd07-36c7-a728-a012cfa7d30d")]
  public sealed class SqlCommand : System.Data.Common.DbCommand
{
    public void ResetCommandTimeout() {}
    public override void Prepare() {}
    public override void Cancel() {}
    public new SqlParameter CreateParameter() { throw new NotImplementedException(); }
    protected override System.Data.Common.DbParameter CreateDbParameter() { throw new NotImplementedException(); }
    protected override void Dispose(bool disposing) {}
    public override object ExecuteScalar() { throw new NotImplementedException(); }
    public override int ExecuteNonQuery() { throw new NotImplementedException(); }
    public System.Xml.XmlReader ExecuteXmlReader() { throw new NotImplementedException(); }
    protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { throw new NotImplementedException(); }
    public new SqlDataReader ExecuteReader() { throw new NotImplementedException(); }
    public new SqlDataReader ExecuteReader(System.Data.CommandBehavior behavior) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<int> ExecuteNonQueryAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    protected override System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteDbDataReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync() { throw new NotImplementedException(); }
    public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior) { throw new NotImplementedException(); }
    public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<object> ExecuteScalarAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task<System.Xml.XmlReader> ExecuteXmlReaderAsync() { throw new NotImplementedException(); }
    public System.Threading.Tasks.Task<System.Xml.XmlReader> ExecuteXmlReaderAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    public override System.Threading.Tasks.Task<int> ExecuteNonQueryAsync() { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<object> ExecuteScalarAsync() { throw new NotImplementedException(); }
    public virtual override void Dispose() {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlCommand () {}
//ctor: 
public SqlCommand (string cmdText) {}
//ctor: 
public SqlCommand (string cmdText, SqlConnection connection) {}
//ctor: 
public SqlCommand (string cmdText, SqlConnection connection, SqlTransaction transaction) {}
   public new SqlConnection Connection { get; set; }
   protected override System.Data.Common.DbConnection DbConnection { }
   public new SqlTransaction Transaction { get; set; }
   protected override System.Data.Common.DbTransaction DbTransaction { }
   public override string CommandText { get; set; }
   public override int CommandTimeout { get; set; }
   public override System.Data.CommandType CommandType { get; set; }
   public override bool DesignTimeVisible { get; set; }
   public new SqlParameterCollection Parameters { get; }
   protected override System.Data.Common.DbParameterCollection DbParameterCollection { }
   public override System.Data.UpdateRowSource UpdatedRowSource { get; set; }
//Event: 
public event System.Data.StatementCompletedEventHandler StatementCompleted;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("d37ffa1a-083f-314e-9712-4cd6d955de28")]
  public sealed class SqlConnection : System.Data.Common.DbConnection
{
    protected override void OnStateChange(System.Data.StateChangeEventArgs stateChange) {}
    public new SqlTransaction BeginTransaction() { throw new NotImplementedException(); }
    public new SqlTransaction BeginTransaction(System.Data.IsolationLevel iso) { throw new NotImplementedException(); }
    public SqlTransaction BeginTransaction(string transactionName) { throw new NotImplementedException(); }
    protected override System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel) { throw new NotImplementedException(); }
    public SqlTransaction BeginTransaction(System.Data.IsolationLevel iso, string transactionName) { throw new NotImplementedException(); }
    public override void ChangeDatabase(string database) {}
    public static void ClearAllPools() {}
    public static void ClearPool(System.Data.SqlClient.SqlConnection connection) {}
    public override void Close() {}
    public new SqlCommand CreateCommand() { throw new NotImplementedException(); }
    public override void Open() {}
    public override System.Threading.Tasks.Task OpenAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public void ResetStatistics() {}
    public System.Collections.IDictionary RetrieveStatistics() { throw new NotImplementedException(); }
    protected override System.Data.Common.DbCommand CreateDbCommand() { throw new NotImplementedException(); }
    protected override void Dispose(bool disposing) {}
    protected virtual override void Finalize() {}
    public override System.Threading.Tasks.Task OpenAsync() { throw new NotImplementedException(); }
    public virtual override void Dispose() {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlConnection (string connectionString) {}
//ctor: 
public SqlConnection () {}
   public bool StatisticsEnabled { get; set; }
   public override string ConnectionString { get; set; }
   public override int ConnectionTimeout { get; }
   public override string Database { get; }
   public override string DataSource { get; }
   public int PacketSize { get; }
   public Guid ClientConnectionId { get; }
   public override string ServerVersion { get; }
   public override System.Data.ConnectionState State { get; }
   public string WorkstationId { get; }
   public bool FireInfoMessageEventOnUserErrors { get; set; }
//Event: 
public event SqlInfoMessageEventHandler InfoMessage;
//Event: 
public event System.Data.StateChangeEventHandler StateChange;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("677a3d0f-4e2b-3fc0-b6a9-39b1a6c7e2e9")]
  public sealed class SqlConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder
{
    public override void Clear() {}
    public override bool ContainsKey(string keyword) { throw new NotImplementedException(); }
    public override bool Remove(string keyword) { throw new NotImplementedException(); }
    public override bool ShouldSerialize(string keyword) { throw new NotImplementedException(); }
    public override bool TryGetValue(string keyword, out object value) { throw new NotImplementedException(); }
    public override void Add(string keyword, object value) {}
    public static override void AppendKeyValuePair(System.Text.StringBuilder builder, string keyword, string value) {}
    public virtual override bool EquivalentTo(System.Data.Common.DbConnectionStringBuilder connectionStringBuilder) { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlConnectionStringBuilder () {}
//ctor: 
public SqlConnectionStringBuilder (string connectionString) {}
   public override object this [string keyword] { get; set; }
   public ApplicationIntent ApplicationIntent { get; set; }
   public string ApplicationName { get; set; }
   public string AttachDBFilename { get; set; }
   public int ConnectTimeout { get; set; }
   public string CurrentLanguage { get; set; }
   public string DataSource { get; set; }
   public bool Encrypt { get; set; }
   public bool TrustServerCertificate { get; set; }
   public string FailoverPartner { get; set; }
   public string InitialCatalog { get; set; }
   public bool IntegratedSecurity { get; set; }
   public int LoadBalanceTimeout { get; set; }
   public int MaxPoolSize { get; set; }
   public int ConnectRetryCount { get; set; }
   public int ConnectRetryInterval { get; set; }
   public int MinPoolSize { get; set; }
   public bool MultipleActiveResultSets { get; set; }
   public bool MultiSubnetFailover { get; set; }
   public int PacketSize { get; set; }
   public string Password { get; set; }
   public bool PersistSecurityInfo { get; set; }
   public bool Pooling { get; set; }
   public bool Replication { get; set; }
   public string TypeSystemVersion { get; set; }
   public string UserID { get; set; }
   public bool UserInstance { get; set; }
   public string WorkstationID { get; set; }
   public override System.Collections.ICollection Keys { get; }
   public override System.Collections.ICollection Values { get; }
   public string ConnectionString { get; set; }
   public virtual int Count { get; }
   public virtual bool IsReadOnly { get; }
   public virtual bool IsFixedSize { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("f9aa3fa1-09cd-3162-8599-486cb6a0b5a6")]
  public class SqlDataReader : System.Data.Common.DbDataReader System.Data.Common.IDbColumnSchemaGenerator
{
    protected override void Dispose(bool disposing) {}
    public override string GetDataTypeName(int i) { throw new NotImplementedException(); }
    public override System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
    public override Type GetFieldType(int i) { throw new NotImplementedException(); }
    public override string GetName(int i) { throw new NotImplementedException(); }
    public override Type GetProviderSpecificFieldType(int i) { throw new NotImplementedException(); }
    public override int GetOrdinal(string name) { throw new NotImplementedException(); }
    public override object GetProviderSpecificValue(int i) { throw new NotImplementedException(); }
    public override int GetProviderSpecificValues(object[] values) { throw new NotImplementedException(); }
    public override bool GetBoolean(int i) { throw new NotImplementedException(); }
    public virtual System.Xml.XmlReader GetXmlReader(int i) { throw new NotImplementedException(); }
    public override System.IO.Stream GetStream(int i) { throw new NotImplementedException(); }
    public override byte GetByte(int i) { throw new NotImplementedException(); }
    public override long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length) { throw new NotImplementedException(); }
    public override System.IO.TextReader GetTextReader(int i) { throw new NotImplementedException(); }
    public override char GetChar(int i) { throw new NotImplementedException(); }
    public override long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length) { throw new NotImplementedException(); }
    public override DateTime GetDateTime(int i) { throw new NotImplementedException(); }
    public override decimal GetDecimal(int i) { throw new NotImplementedException(); }
    public override double GetDouble(int i) { throw new NotImplementedException(); }
    public override float GetFloat(int i) { throw new NotImplementedException(); }
    public override Guid GetGuid(int i) { throw new NotImplementedException(); }
    public override short GetInt16(int i) { throw new NotImplementedException(); }
    public override int GetInt32(int i) { throw new NotImplementedException(); }
    public override long GetInt64(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlBoolean GetSqlBoolean(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlBinary GetSqlBinary(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlByte GetSqlByte(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlBytes GetSqlBytes(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlChars GetSqlChars(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlDateTime GetSqlDateTime(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlDecimal GetSqlDecimal(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlGuid GetSqlGuid(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlDouble GetSqlDouble(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlInt16 GetSqlInt16(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlInt32 GetSqlInt32(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlInt64 GetSqlInt64(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlMoney GetSqlMoney(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlSingle GetSqlSingle(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlString GetSqlString(int i) { throw new NotImplementedException(); }
    public virtual System.Data.SqlTypes.SqlXml GetSqlXml(int i) { throw new NotImplementedException(); }
    public virtual object GetSqlValue(int i) { throw new NotImplementedException(); }
    public virtual int GetSqlValues(object[] values) { throw new NotImplementedException(); }
    public override string GetString(int i) { throw new NotImplementedException(); }
    public override GetFieldValue(int i) { throw new NotImplementedException(); }
    public override object GetValue(int i) { throw new NotImplementedException(); }
    public virtual TimeSpan GetTimeSpan(int i) { throw new NotImplementedException(); }
    public virtual DateTimeOffset GetDateTimeOffset(int i) { throw new NotImplementedException(); }
    public override int GetValues(object[] values) { throw new NotImplementedException(); }
    public override bool IsDBNull(int i) { throw new NotImplementedException(); }
    public override bool NextResult() { throw new NotImplementedException(); }
    public override bool Read() { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<bool> NextResultAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<bool> IsDBNullAsync(int i, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public override GetFieldValueAsync(int i, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.DbColumn> GetColumnSchema() { throw new NotImplementedException(); }
    public virtual override void Dispose() {}
    public override System.Data.Common.DbDataReader GetData(int ordinal) { throw new NotImplementedException(); }
    protected virtual override System.Data.Common.DbDataReader GetDbDataReader(int ordinal) { throw new NotImplementedException(); }
    public override GetFieldValueAsync(int ordinal) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal) { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<bool> ReadAsync() { throw new NotImplementedException(); }
    public override System.Threading.Tasks.Task<bool> NextResultAsync() { throw new NotImplementedException(); }
    public virtual override System.Data.DataTable GetSchemaTable() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   protected SqlConnection Connection { }
   public override int Depth { get; }
   public override int FieldCount { get; }
   public override bool HasRows { get; }
   public override bool IsClosed { get; }
   public override int RecordsAffected { get; }
   public override int VisibleFieldCount { get; }
   public override object this [int i] { get; }
   public override object this [string name] { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("4d0fce6f-7312-38c0-9b82-ee6c1ddd65a9")]
  public sealed class SqlError : System.Object
{
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   public string Source { get; }
   public int Number { get; }
   public byte State { get; }
   public byte Class { get; }
   public string Server { get; }
   public string Message { get; }
   public string Procedure { get; }
   public int LineNumber { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("fca78adc-a8a0-321a-b067-7826b0af7d01")]
  public sealed class SqlErrorCollection : System.Object System.Collections.ICollection
{
    public virtual void CopyTo(Array array, int index) {}
    public void CopyTo(System.Data.SqlClient.SqlError[] array, int index) {}
    public virtual System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   public virtual int Count { get; }
   public SqlError this [int index] { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("1190e01b-1523-3f5e-893a-e71657cf7a18")]
  public sealed class SqlException : System.Data.Common.DbException
{
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override Exception GetBaseException() { throw new NotImplementedException(); }
    public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
    public virtual override Type GetType() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   public SqlErrorCollection Errors { get; }
   public Guid ClientConnectionId { get; }
   public byte Class { get; }
   public int LineNumber { get; }
   public int Number { get; }
   public string Procedure { get; }
   public string Server { get; }
   public byte State { get; }
   public override string Source { get; }
   public virtual string Message { get; }
   public virtual System.Collections.IDictionary Data { get; }
   public virtual Exception InnerException { get; }
   public virtual System.Reflection.MethodBase TargetSite { get; }
   public virtual string StackTrace { get; }
   public virtual string HelpLink { get; set; }
   public int HResult { get; }
//Event: 
protected event EventHandler<System.Runtime.Serialization.SafeSerializationEventArgs> SerializeObjectState;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("bbedcd99-2a79-3bce-bc2d-b2ae73d8987f")]
  public sealed class SqlInfoMessageEventArgs : System.EventArgs
{
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   public SqlErrorCollection Errors { get; }
   public string Message { get; }
   public string Source { get; }
// Field: 
public static readonly EventArgs Empty;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("4367dd93-5d4c-30b4-9fda-d642eb92466e")]
  public sealed delegate SqlInfoMessageEventHandler : System.MulticastDelegate
{
    public virtual void Invoke(object sender, SqlInfoMessageEventArgs e) {}
    public virtual IAsyncResult BeginInvoke(object sender, SqlInfoMessageEventArgs e, AsyncCallback callback, object object) { throw new NotImplementedException(); }
    public virtual void EndInvoke(IAsyncResult result) {}
    public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    protected virtual override delegate CombineImpl(delegate follow) { throw new NotImplementedException(); }
    protected virtual override delegate RemoveImpl(delegate value) { throw new NotImplementedException(); }
    public virtual override delegate[] GetInvocationList() { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    protected virtual override System.Reflection.MethodInfo GetMethodImpl() { throw new NotImplementedException(); }
    public override object DynamicInvoke(object[] args) { throw new NotImplementedException(); }
    protected virtual override object DynamicInvokeImpl(object[] args) { throw new NotImplementedException(); }
    public static override delegate Combine(delegate a, delegate b) { throw new NotImplementedException(); }
    public static override delegate Combine(delegate[] delegates) { throw new NotImplementedException(); }
    public static override delegate Remove(delegate source, delegate value) { throw new NotImplementedException(); }
    public static override delegate RemoveAll(delegate source, delegate value) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, object target, string method) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, Type target, string method) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
    public static override delegate CreateDelegate(Type type, System.Reflection.MethodInfo method) { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlInfoMessageEventHandler (object object, IntPtr method) {}
   public System.Reflection.MethodInfo Method { get; }
   public object Target { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("3c40c1ac-c52d-3e5f-9900-f31d96f04fdf")]
  public sealed class SqlParameter : System.Data.Common.DbParameter
{
    public override void ResetDbType() {}
    public void ResetSqlDbType() {}
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public SqlParameter () {}
//ctor: 
public SqlParameter (string parameterName, System.Data.SqlDbType dbType) {}
//ctor: 
public SqlParameter (string parameterName, object value) {}
//ctor: 
public SqlParameter (string parameterName, System.Data.SqlDbType dbType, int size) {}
//ctor: 
public SqlParameter (string parameterName, System.Data.SqlDbType dbType, int size, string sourceColumn) {}
   public System.Data.SqlTypes.SqlCompareOptions CompareInfo { get; set; }
   public string XmlSchemaCollectionDatabase { get; set; }
   public string XmlSchemaCollectionOwningSchema { get; set; }
   public string XmlSchemaCollectionName { get; set; }
   public override System.Data.DbType DbType { get; set; }
   public int LocaleId { get; set; }
   public override string ParameterName { get; set; }
   public override byte Precision { get; set; }
   public override byte Scale { get; set; }
   public System.Data.SqlDbType SqlDbType { get; set; }
   public object SqlValue { get; set; }
   public string TypeName { get; set; }
   public override object Value { get; set; }
   public override System.Data.ParameterDirection Direction { get; set; }
   public override bool IsNullable { get; set; }
   public int Offset { get; set; }
   public override int Size { get; set; }
   public override string SourceColumn { get; set; }
   public override bool SourceColumnNullMapping { get; set; }
   public virtual System.Data.DataRowVersion SourceVersion { get; set; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("49078a63-6945-3a4e-aefd-8ad76eb1ba6c")]
  public sealed class SqlParameterCollection : System.Data.Common.DbParameterCollection
{
    public SqlParameter Add(System.Data.SqlClient.SqlParameter value) { throw new NotImplementedException(); }
    public SqlParameter AddWithValue(string parameterName, object value) { throw new NotImplementedException(); }
    public SqlParameter Add(string parameterName, System.Data.SqlDbType sqlDbType) { throw new NotImplementedException(); }
    public SqlParameter Add(string parameterName, System.Data.SqlDbType sqlDbType, int size) { throw new NotImplementedException(); }
    public SqlParameter Add(string parameterName, System.Data.SqlDbType sqlDbType, int size, string sourceColumn) { throw new NotImplementedException(); }
    public void AddRange(System.Data.SqlClient.SqlParameter[] values) {}
    public override bool Contains(string value) { throw new NotImplementedException(); }
    public bool Contains(System.Data.SqlClient.SqlParameter value) { throw new NotImplementedException(); }
    public void CopyTo(System.Data.SqlClient.SqlParameter[] array, int index) {}
    public int IndexOf(System.Data.SqlClient.SqlParameter value) { throw new NotImplementedException(); }
    public void Insert(int index, SqlParameter value) {}
    public void Remove(System.Data.SqlClient.SqlParameter value) {}
    public override int Add(object value) { throw new NotImplementedException(); }
    public override void AddRange(Array values) {}
    public override void Clear() {}
    public override bool Contains(object value) { throw new NotImplementedException(); }
    public override void CopyTo(Array array, int index) {}
    public override System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
    protected override System.Data.Common.DbParameter GetParameter(int index) { throw new NotImplementedException(); }
    protected override System.Data.Common.DbParameter GetParameter(string parameterName) { throw new NotImplementedException(); }
    public override int IndexOf(string parameterName) { throw new NotImplementedException(); }
    public override int IndexOf(object value) { throw new NotImplementedException(); }
    public override void Insert(int index, object value) {}
    public override void Remove(object value) {}
    public override void RemoveAt(int index) {}
    public override void RemoveAt(string parameterName) {}
    protected override void SetParameter(int index, System.Data.Common.DbParameter value) {}
    protected override void SetParameter(string parameterName, System.Data.Common.DbParameter value) {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   public new SqlParameter this [int index] { get; set; }
   public new SqlParameter this [string parameterName] { get; set; }
   public override int Count { get; }
   public override object SyncRoot { get; }
   public virtual bool IsReadOnly { get; }
   public virtual bool IsSynchronized { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("ce885c69-eb54-3490-98ff-c5fe5b94d993")]
  public sealed class SqlTransaction : System.Data.Common.DbTransaction
{
    public override void Commit() {}
    protected override void Dispose(bool disposing) {}
    public override void Rollback() {}
    public void Rollback(string transactionName) {}
    public void Save(string savePointName) {}
    public virtual override void Dispose() {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   public new SqlConnection Connection { get; }
   protected override System.Data.Common.DbConnection DbConnection { }
   public override System.Data.IsolationLevel IsolationLevel { get; }
  }
