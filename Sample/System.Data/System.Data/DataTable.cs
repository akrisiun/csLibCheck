
   [Guid("56839c77-582d-3a29-aeb5-7011a8335593")]
   public class DataTable : System.ComponentModel.MarshalByValueComponent System.ComponentModel.IListSource, System.ComponentModel.ISupportInitializeNotification, System.Runtime.Serialization.ISerializable, System.Xml.Serialization.IXmlSerializable
   {
       public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
       public virtual void BeginInit() {}
       public virtual void EndInit() {}
       public void AcceptChanges() {}
       protected virtual DataTable CreateInstance() { throw new NotImplementedException(); }
       public virtual DataTable Clone() { throw new NotImplementedException(); }
       public DataTable Copy() { throw new NotImplementedException(); }
       public void Clear() {}
       public object Compute(string expression, string filter) { throw new NotImplementedException(); }
       public DataTable GetChanges() { throw new NotImplementedException(); }
       public DataTable GetChanges(System.Data.DataRowState rowStates) { throw new NotImplementedException(); }
       public DataRow[] GetErrors() { throw new NotImplementedException(); }
       public void ImportRow(System.Data.DataRow row) {}
       public DataRow NewRow() { throw new NotImplementedException(); }
       protected virtual DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) { throw new NotImplementedException(); }
       protected virtual Type GetRowType() { throw new NotImplementedException(); }
      // protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) {}
       protected virtual void OnRemoveColumn(System.Data.DataColumn column) {}
       protected virtual void OnRowChanged(System.Data.DataRowChangeEventArgs e) {}
       protected virtual void OnRowChanging(System.Data.DataRowChangeEventArgs e) {}
       protected virtual void OnRowDeleting(System.Data.DataRowChangeEventArgs e) {}
       protected virtual void OnRowDeleted(System.Data.DataRowChangeEventArgs e) {}
       protected virtual void OnTableCleared(System.Data.DataTableClearEventArgs e) {}
       protected virtual void OnTableClearing(System.Data.DataTableClearEventArgs e) {}
       protected virtual void OnTableNewRow(System.Data.DataTableNewRowEventArgs e) {}
       public void RejectChanges() {}
       public virtual void Reset() {}
       public DataRow[] Select() { throw new NotImplementedException(); }
       public DataRow[] Select(string filterExpression) { throw new NotImplementedException(); }
       public DataRow[] Select(string filterExpression, string sort) { throw new NotImplementedException(); }
       public DataRow[] Select(string filterExpression, string sort, DataViewRowState recordStates) { throw new NotImplementedException(); }
       public override string ToString() { throw new NotImplementedException(); }
       public void BeginLoadData() {}
       public void EndLoadData() {}
       public DataRow LoadDataRow(object[] values, bool fAcceptChanges) { throw new NotImplementedException(); }
       public DataRow LoadDataRow(object[] values, LoadOption loadOption) { throw new NotImplementedException(); }
       public void Merge(System.Data.DataTable table) {}
       public void Merge(System.Data.DataTable table, bool preserveChanges) {}
       public void Merge(System.Data.DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) {}
       public void Load(System.Data.IDataReader reader) {}
       public void Load(System.Data.IDataReader reader, LoadOption loadOption) {}
       public virtual void Load(System.Data.IDataReader reader, LoadOption loadOption, FillErrorEventHandler errorHandler) {}
       public DataTableReader CreateDataReader() { throw new NotImplementedException(); }
       public void WriteXml(System.IO.Stream stream) {}
       public void WriteXml(System.IO.Stream stream, bool writeHierarchy) {}
       public void WriteXml(System.IO.TextWriter writer) {}
       public void WriteXml(System.IO.TextWriter writer, bool writeHierarchy) {}
       public void WriteXml(System.Xml.XmlWriter writer) {}
       public void WriteXml(System.Xml.XmlWriter writer, bool writeHierarchy) {}
       public void WriteXml(string fileName) {}
       public void WriteXml(string fileName, bool writeHierarchy) {}
       public void WriteXml(System.IO.Stream stream, XmlWriteMode mode) {}
       public void WriteXml(System.IO.Stream stream, XmlWriteMode mode, bool writeHierarchy) {}
       public void WriteXml(System.IO.TextWriter writer, XmlWriteMode mode) {}
       public void WriteXml(System.IO.TextWriter writer, XmlWriteMode mode, bool writeHierarchy) {}
       public void WriteXml(System.Xml.XmlWriter writer, XmlWriteMode mode) {}
       public void WriteXml(System.Xml.XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) {}
       public void WriteXml(string fileName, XmlWriteMode mode) {}
       public void WriteXml(string fileName, XmlWriteMode mode, bool writeHierarchy) {}
       public void WriteXmlSchema(System.IO.Stream stream) {}
       public void WriteXmlSchema(System.IO.Stream stream, bool writeHierarchy) {}
       public void WriteXmlSchema(System.IO.TextWriter writer) {}
       public void WriteXmlSchema(System.IO.TextWriter writer, bool writeHierarchy) {}
       public void WriteXmlSchema(System.Xml.XmlWriter writer) {}
       public void WriteXmlSchema(System.Xml.XmlWriter writer, bool writeHierarchy) {}
       public void WriteXmlSchema(string fileName) {}
       public void WriteXmlSchema(string fileName, bool writeHierarchy) {}
       public XmlReadMode ReadXml(System.IO.Stream stream) { throw new NotImplementedException(); }
       public XmlReadMode ReadXml(System.IO.TextReader reader) { throw new NotImplementedException(); }
       public XmlReadMode ReadXml(string fileName) { throw new NotImplementedException(); }
       public XmlReadMode ReadXml(System.Xml.XmlReader reader) { throw new NotImplementedException(); }
       public void ReadXmlSchema(System.IO.Stream stream) {}
       public void ReadXmlSchema(System.IO.TextReader reader) {}
       public void ReadXmlSchema(string fileName) {}
       public void ReadXmlSchema(System.Xml.XmlReader reader) {}
       public static System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { throw new NotImplementedException(); }
       protected virtual System.Xml.Schema.XmlSchema GetSchema() { throw new NotImplementedException(); }
       protected virtual void ReadXmlSerializable(System.Xml.XmlReader reader) {}
       public virtual override void Dispose() {}
       protected virtual override void Dispose(bool disposing) {}
       public virtual override object GetService(Type service) { throw new NotImplementedException(); }
      //ctor: 
      public DataTable () {}
      //ctor: 
      public DataTable (string tableName) {}
      //ctor: 
      public DataTable (string tableName, string tableNamespace) {}
      //ctor: 
      protected DataTable (System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
      public bool CaseSensitive { get; set; }
      public virtual bool IsInitialized { get { throw new NotImplementedException(); } }
      public SerializationFormat RemotingFormat { get; set; }
      public DataRelationCollection ChildRelations { get { throw new NotImplementedException(); } }
      public DataColumnCollection Columns { get { throw new NotImplementedException(); } }
      public ConstraintCollection Constraints { get { throw new NotImplementedException(); } }
      public DataSet DataSet { get { throw new NotImplementedException(); } }
      public DataView DefaultView { get { throw new NotImplementedException(); } }
      public string DisplayExpression { get; set; }
      public PropertyCollection ExtendedProperties { get { throw new NotImplementedException(); } }
      public bool HasErrors { get { throw new NotImplementedException(); } }
      public System.Globalization.CultureInfo Locale { get; set; }
      public int MinimumCapacity { get; set; }
      public DataRelationCollection ParentRelations { get { throw new NotImplementedException(); } }
      public DataColumn[] PrimaryKey { get; set; }
      public DataRowCollection Rows { get { throw new NotImplementedException(); } }
      public string TableName { get; set; }
      public string Namespace { get; set; }
      public string Prefix { get; set; }
      public override System.ComponentModel.ISite Site { get; set; }
      protected System.ComponentModel.EventHandlerList Events { }
      public virtual System.ComponentModel.IContainer Container { get { throw new NotImplementedException(); } }
      public virtual bool DesignMode { get { throw new NotImplementedException(); } }
      // Event: 
   // public event DataColumnChangeEventHandler ColumnChanging;
      // Event: 
   // public event DataColumnChangeEventHandler ColumnChanged;
      // Event: 
   // public event EventHandler Initialized;
      // Event: 
   // public event DataRowChangeEventHandler RowChanged;
      // Event: 
   // public event DataRowChangeEventHandler RowChanging;
      // Event: 
   // public event DataRowChangeEventHandler RowDeleting;
      // Event: 
   // public event DataRowChangeEventHandler RowDeleted;
      // Event: 
   // public event DataTableClearEventHandler TableClearing;
      // Event: 
   // public event DataTableClearEventHandler TableCleared;
      // Event: 
   // public event DataTableNewRowEventHandler TableNewRow;
      // Event: 
   // public event EventHandler Disposed;
   }
}
