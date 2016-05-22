
   [Guid("b042f350-345a-3f37-b532-d557d91d5fca")]
   public sealed class DataTableReader : Common.DbDataReader
   {
       public override void Close() {}
       public override DataTable GetSchemaTable() { throw new NotImplementedException(); }
       public override bool NextResult() { throw new NotImplementedException(); }
       public override bool Read() { throw new NotImplementedException(); }
       public override Type GetProviderSpecificFieldType(int ordinal) { throw new NotImplementedException(); }
       public override object GetProviderSpecificValue(int ordinal) { throw new NotImplementedException(); }
       public override int GetProviderSpecificValues(object[] values) { throw new NotImplementedException(); }
       public override bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
       public override byte GetByte(int ordinal) { throw new NotImplementedException(); }
       public override long GetBytes(int ordinal, long dataIndex, byte[] buffer, int bufferIndex, int length) { throw new NotImplementedException(); }
       public override char GetChar(int ordinal) { throw new NotImplementedException(); }
       public override long GetChars(int ordinal, long dataIndex, char[] buffer, int bufferIndex, int length) { throw new NotImplementedException(); }
       public override string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
       public override DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
       public override decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
       public override double GetDouble(int ordinal) { throw new NotImplementedException(); }
       public override Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
       public override float GetFloat(int ordinal) { throw new NotImplementedException(); }
       public override Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
       public override short GetInt16(int ordinal) { throw new NotImplementedException(); }
       public override int GetInt32(int ordinal) { throw new NotImplementedException(); }
       public override long GetInt64(int ordinal) { throw new NotImplementedException(); }
       public override string GetName(int ordinal) { throw new NotImplementedException(); }
       public override int GetOrdinal(string name) { throw new NotImplementedException(); }
       public override string GetString(int ordinal) { throw new NotImplementedException(); }
       public override object GetValue(int ordinal) { throw new NotImplementedException(); }
       public override int GetValues(object[] values) { throw new NotImplementedException(); }
       public override bool IsDBNull(int ordinal) { throw new NotImplementedException(); }
       public override System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
       public virtual override void Dispose() {}
       protected virtual override void Dispose(bool disposing) {}
       public override Common.DbDataReader GetData(int ordinal) { throw new NotImplementedException(); }
       protected virtual override Common.DbDataReader GetDbDataReader(int ordinal) { throw new NotImplementedException(); }
       public virtual override System.IO.Stream GetStream(int ordinal) { throw new NotImplementedException(); }
       public virtual override System.IO.TextReader GetTextReader(int ordinal) { throw new NotImplementedException(); }
       public virtual override GetFieldValue(int ordinal) { throw new NotImplementedException(); }
       public override GetFieldValueAsync(int ordinal) { throw new NotImplementedException(); }
       public virtual override GetFieldValueAsync(int ordinal, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
       public override System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal) { throw new NotImplementedException(); }
       public virtual override System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
       public override System.Threading.Tasks.Task<bool> ReadAsync() { throw new NotImplementedException(); }
       public virtual override System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
       public override System.Threading.Tasks.Task<bool> NextResultAsync() { throw new NotImplementedException(); }
       public virtual override System.Threading.Tasks.Task<bool> NextResultAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
       protected override MarshalByRefObject MemberwiseClone(bool cloneIdentity) { throw new NotImplementedException(); }
       public virtual override object GetLifetimeService() { throw new NotImplementedException(); }
       public virtual override object InitializeLifetimeService() { throw new NotImplementedException(); }
       public virtual override System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) { throw new NotImplementedException(); }
      //ctor: 
      public DataTableReader (System.Data.DataTable dataTable) {}
      //ctor: 
      public DataTableReader (System.Data.DataTable[] dataTables) {}
      public override int Depth { get { throw new NotImplementedException(); } }
      public override bool IsClosed { get { throw new NotImplementedException(); } }
      public override int RecordsAffected { get { throw new NotImplementedException(); } }
      public override bool HasRows { get { throw new NotImplementedException(); } }
      public override object this [int ordinal] { get { throw new NotImplementedException(); } }
      public override object this [string name] { get { throw new NotImplementedException(); } }
      public override int FieldCount { get { throw new NotImplementedException(); } }
      public virtual int VisibleFieldCount { get { throw new NotImplementedException(); } }
   }
}
