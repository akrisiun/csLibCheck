
using System;
namespace System.Data
{  


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("5b6711b4-d415-3fd8-8d0a-ad3b6896db71")]
  public sealed enum CommandBehavior // // : System.Enum
{
    // // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("c0d78e71-d37f-305d-a90b-57a09437da1e")]
  public sealed enum CommandType // // : System.Enum
{
    // // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("ea4bbf61-06a6-3f8e-a81c-a4c4000e9e6c")]
  public sealed enum ConnectionState // // : System.Enum
{
    // // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("3fb13d62-d5d6-385a-aa95-6bba6e2d76d2")]
  public sealed enum DbType // // : System.Enum
{
    // // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("0fa899a2-3d46-3923-ba25-5fbbc92f03c0")]
  public sealed enum IsolationLevel // // : System.Enum
{
    // // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("6bafd43b-78e5-3b56-b97f-cb3e254c6472")]
  public sealed enum ParameterDirection // // : System.Enum
{
    // // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("1d6ad661-c6f5-3fb0-831c-727affd6a9e6")]
  public sealed class StateChangeEventArgs : System.EventArgs
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
public StateChangeEventArgs (System.Data.ConnectionState originalState, ConnectionState currentState) {}
   public ConnectionState CurrentState { get; }
   public ConnectionState OriginalState { get; }
// Field: 
public static readonly EventArgs Empty;
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
//[Guid("da44e687-a685-37ec-8cdc-d06ce8b18d35")]
  public sealed delegate StateChangeEventHandler; // : System.MulticastDelegate

//{
//    public virtual void Invoke(object sender, StateChangeEventArgs e) {}
//    public virtual IAsyncResult BeginInvoke(object sender, StateChangeEventArgs e, AsyncCallback callback, object object) { throw new NotImplementedException(); }
//    public virtual void EndInvoke(IAsyncResult result) {}
//    // public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
//    // public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
//    //protected virtual override delegate CombineImpl(delegate follow) { throw new NotImplementedException(); }
//    //protected virtual override delegate RemoveImpl(delegate value) { throw new NotImplementedException(); }

//    //public virtual override delegate[] GetInvocationList() { throw new NotImplementedException(); }
//    public virtual override int GetHashCode() { throw new NotImplementedException(); }
//    protected virtual override System.Reflection.MethodInfo GetMethodImpl() { throw new NotImplementedException(); }
//    public override object DynamicInvoke(object[] args) { throw new NotImplementedException(); }
//    protected virtual override object DynamicInvokeImpl(object[] args) { throw new NotImplementedException(); }
//    public static override delegate Combine(delegate a, delegate b) { throw new NotImplementedException(); }
//    public static override delegate Combine(delegate[] delegates) { throw new NotImplementedException(); }
//    public static override delegate Remove(delegate source, delegate value) { throw new NotImplementedException(); }
//    public static override delegate RemoveAll(delegate source, delegate value) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, object target, string method) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, Type target, string method) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, System.Reflection.MethodInfo method) { throw new NotImplementedException(); }
//    public virtual override string ToString() { throw new NotImplementedException(); }
//    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
//    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
//    public override Type GetType() { throw new NotImplementedException(); }
//    protected virtual override void Finalize() {}
//    protected override object MemberwiseClone() { throw new NotImplementedException(); }
////ctor: 
//public StateChangeEventHandler (object object, IntPtr method) {}
//   public System.Reflection.MethodInfo Method { get; }
//   public object Target { get; }
//  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("22b21535-cb12-3c02-b4bb-0e3a58ee6fda")]
  public sealed enum UpdateRowSource // // : System.Enum
{
    // // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("3ec27e46-f875-30dc-83cf-084e76e80cea")]
  public sealed enum DataRowVersion // // : System.Enum
{
    // // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("9f17f939-0aba-34b3-8f94-7a205403e04a")]
  public class DataTable : System.Object
{
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
[Guid("dbae8a91-bb4e-3e18-b45f-233c65fbda2b")]
  public interface IDataParameter
{
   DbType DbType { get; set; }
   ParameterDirection Direction { get; set; }
   bool IsNullable { get; }
   string ParameterName { get; set; }
   string SourceColumn { get; set; }
   DataRowVersion SourceVersion { get; set; }
   object Value { get; set; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("b490f13c-7e82-3a54-a31e-dfa010a1affe")]
  public interface IDataParameterCollection : System.Collections.IList
{
    bool Contains(string parameterName);
    int IndexOf(string parameterName);
    void RemoveAt(string parameterName) {}
    object this [string parameterName] { get; set; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("eef6063a-b303-370c-a350-20e70194f0b0")]
  public interface IDataReader : System.IDisposable, IDataRecord
{
    void Close() {}
    DataTable GetSchemaTable();
    bool NextResult();
    bool Read();
   int Depth { get; }
   bool IsClosed { get; }
   int RecordsAffected { get; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("6daa5a9d-4eac-3c24-b85c-794b4e65604d")]
  public interface IDataRecord
{
    string GetName(int i);
    string GetDataTypeName(int i);
    Type GetFieldType(int i);
    object GetValue(int i);
    int GetValues(object[] values);
    int GetOrdinal(string name);
    bool GetBoolean(int i);
    byte GetByte(int i);
    long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length);
    char GetChar(int i);
    long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length);
    Guid GetGuid(int i);
    short GetInt16(int i);
    int GetInt32(int i);
    long GetInt64(int i);
    float GetFloat(int i);
    double GetDouble(int i);
    string GetString(int i);
    decimal GetDecimal(int i);
    DateTime GetDateTime(int i);
    IDataReader GetData(int i);
    bool IsDBNull(int i);
   int FieldCount { get; }
   object this [int i] { get; }
   object this [string name] { get; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("e41ac658-7894-35bd-b768-0d4824cdd220")]
  public interface IDbCommand : System.IDisposable
{
    void Prepare() {}
    void Cancel() {}
    IDbDataParameter CreateParameter();
    int ExecuteNonQuery();
    IDataReader ExecuteReader();
    IDataReader ExecuteReader(System.Data.CommandBehavior behavior);
    object ExecuteScalar();
   public IDbConnection Connection { get; set; }
   public IDbTransaction Transaction { get; set; }
   public string CommandText { get; set; }
   public int CommandTimeout { get; set; }
   public CommandType CommandType { get; set; }
   public IDataParameterCollection Parameters { get; }
   public UpdateRowSource UpdatedRowSource { get; set; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("9bb226f4-2af3-37e7-b91d-3bb936fc0a7e")]
  public interface IDbConnection : System.IDisposable
{
    IDbTransaction BeginTransaction();
    IDbTransaction BeginTransaction(System.Data.IsolationLevel il);
    void Close() {}
    void ChangeDatabase(string databaseName) {}
    IDbCommand CreateCommand();
    void Open() {}
   public string ConnectionString { get; set; }
   public int ConnectionTimeout { get; }
   public string Database { get; }
   public ConnectionState State { get; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("391e486c-97be-3fd1-a26f-bc953af9ef2d")]
  public interface IDbDataParameter : IDataParameter
{
   public byte Precision { get; set; }
   public byte Scale { get; set; }
   public int Size { get; set; }
  }


// Source:  d:/Beta/dotData/System.Data.Common.dll  Build 4.6.23911.00
[Guid("62572de3-dd0d-3763-9548-50665d013f6d")]
  public interface IDbTransaction : System.IDisposable
{
    void Commit() {}
    void Rollback() {}
   public IDbConnection Connection { get; }
   public IsolationLevel IsolationLevel { get; }
  }
}


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("3f55d3a7-f105-3d6b-af5a-fc459030a556")]
  public sealed class OperationAbortedException : System.Exception
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
[Guid("672a04a7-0aba-32d6-b1b3-0d14ce2b4548")]
  public sealed class StatementCompletedEventArgs : System.EventArgs
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
public StatementCompletedEventArgs (int recordCount) {}
   public int RecordCount { get; }
// Field: 
public static readonly EventArgs Empty;
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("c736da64-6a07-3d15-95b4-714dc9f8d83e")]
  public sealed delegate StatementCompletedEventHandler : System.MulticastDelegate
{
    public virtual void Invoke(object sender, StatementCompletedEventArgs e) {}
    public virtual IAsyncResult BeginInvoke(object sender, StatementCompletedEventArgs e, AsyncCallback callback, object object) { throw new NotImplementedException(); }
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
public StatementCompletedEventHandler (object object, IntPtr method) {}
   public System.Reflection.MethodInfo Method { get; }
   public object Target { get; }
  }


// Source:  d:/Beta/dotData/System.Data.SqlClient.dll  Build 4.6.24013.00
[Guid("b24be752-9edd-3cc4-bdc7-98e33cb0683b")]
  public sealed enum SqlDbType // // : System.Enum
{
    // // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }

}