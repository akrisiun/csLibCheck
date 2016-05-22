
   [Guid("6e3df7a0-377f-3a21-bb7c-c4c37f17758d")]
   public class DataSet : System.ComponentModel.MarshalByValueComponent System.ComponentModel.IListSource, System.Xml.Serialization.IXmlSerializable, System.ComponentModel.ISupportInitializeNotification, System.Runtime.Serialization.ISerializable
   {
       protected bool IsBinarySerialized(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { throw new NotImplementedException(); }
       protected SchemaSerializationMode DetermineSchemaSerializationMode(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { throw new NotImplementedException(); }
       protected SchemaSerializationMode DetermineSchemaSerializationMode(System.Xml.XmlReader reader) { throw new NotImplementedException(); }
       protected void GetSerializationData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
       public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
       protected virtual void InitializeDerivedDataSet() {}
       protected virtual bool ShouldSerializeRelations() { throw new NotImplementedException(); }
       protected virtual bool ShouldSerializeTables() { throw new NotImplementedException(); }
       public void AcceptChanges() {}
       public virtual void BeginInit() {}
       public virtual void EndInit() {}
       public void Clear() {}
       public virtual DataSet Clone() { throw new NotImplementedException(); }
       public DataSet Copy() { throw new NotImplementedException(); }
       public DataSet GetChanges() { throw new NotImplementedException(); }
       public DataSet GetChanges(System.Data.DataRowState rowStates) { throw new NotImplementedException(); }
       public string GetXml() { throw new NotImplementedException(); }
       public string GetXmlSchema() { throw new NotImplementedException(); }
       public bool HasChanges() { throw new NotImplementedException(); }
       public bool HasChanges(System.Data.DataRowState rowStates) { throw new NotImplementedException(); }
       public void InferXmlSchema(System.Xml.XmlReader reader, string[] nsArray) {}
       public void InferXmlSchema(System.IO.Stream stream, string[] nsArray) {}
       public void InferXmlSchema(System.IO.TextReader reader, string[] nsArray) {}
       public void InferXmlSchema(string fileName, string[] nsArray) {}
       public void ReadXmlSchema(System.Xml.XmlReader reader) {}
       public void ReadXmlSchema(System.IO.Stream stream) {}
       public void ReadXmlSchema(System.IO.TextReader reader) {}
       public void ReadXmlSchema(string fileName) {}
       public void WriteXmlSchema(System.IO.Stream stream) {}
       public void WriteXmlSchema(System.IO.Stream stream, Converter<Type,string> multipleTargetConverter) {}
       public void WriteXmlSchema(string fileName) {}
       public void WriteXmlSchema(string fileName, Converter<Type,string> multipleTargetConverter) {}
       public void WriteXmlSchema(System.IO.TextWriter writer) {}
       public void WriteXmlSchema(System.IO.TextWriter writer, Converter<Type,string> multipleTargetConverter) {}
       public void WriteXmlSchema(System.Xml.XmlWriter writer) {}
       public void WriteXmlSchema(System.Xml.XmlWriter writer, Converter<Type,string> multipleTargetConverter) {}
       public XmlReadMode ReadXml(System.Xml.XmlReader reader) { throw new NotImplementedException(); }
       public XmlReadMode ReadXml(System.IO.Stream stream) { throw new NotImplementedException(); }
       public XmlReadMode ReadXml(System.IO.TextReader reader) { throw new NotImplementedException(); }
       public XmlReadMode ReadXml(string fileName) { throw new NotImplementedException(); }
       public XmlReadMode ReadXml(System.Xml.XmlReader reader, XmlReadMode mode) { throw new NotImplementedException(); }
       public XmlReadMode ReadXml(System.IO.Stream stream, XmlReadMode mode) { throw new NotImplementedException(); }
       public XmlReadMode ReadXml(System.IO.TextReader reader, XmlReadMode mode) { throw new NotImplementedException(); }
       public XmlReadMode ReadXml(string fileName, XmlReadMode mode) { throw new NotImplementedException(); }
       public void WriteXml(System.IO.Stream stream) {}
       public void WriteXml(System.IO.TextWriter writer) {}
       public void WriteXml(System.Xml.XmlWriter writer) {}
       public void WriteXml(string fileName) {}
       public void WriteXml(System.IO.Stream stream, XmlWriteMode mode) {}
       public void WriteXml(System.IO.TextWriter writer, XmlWriteMode mode) {}
       public void WriteXml(System.Xml.XmlWriter writer, XmlWriteMode mode) {}
       public void WriteXml(string fileName, XmlWriteMode mode) {}
       public void Merge(System.Data.DataSet dataSet) {}
       public void Merge(System.Data.DataSet dataSet, bool preserveChanges) {}
       public void Merge(System.Data.DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) {}
       public void Merge(System.Data.DataTable table) {}
       public void Merge(System.Data.DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) {}
       public void Merge(System.Data.DataRow[] rows) {}
       public void Merge(System.Data.DataRow[] rows, bool preserveChanges, MissingSchemaAction missingSchemaAction) {}
      // protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) {}
       protected virtual void OnRemoveRelation(System.Data.DataRelation relation) {}
       public virtual void RejectChanges() {}
       public virtual void Reset() {}
       protected virtual void ReadXmlSerializable(System.Xml.XmlReader reader) {}
       protected virtual System.Xml.Schema.XmlSchema GetSchemaSerializable() { throw new NotImplementedException(); }
       public static System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { throw new NotImplementedException(); }
       public virtual void Load(System.Data.IDataReader reader, LoadOption loadOption, FillErrorEventHandler errorHandler, DataTable[] tables) {}
       public void Load(System.Data.IDataReader reader, LoadOption loadOption, DataTable[] tables) {}
       public void Load(System.Data.IDataReader reader, LoadOption loadOption, string[] tables) {}
       public DataTableReader CreateDataReader() { throw new NotImplementedException(); }
       public DataTableReader CreateDataReader(System.Data.DataTable[] dataTables) { throw new NotImplementedException(); }
       public virtual override void Dispose() {}
       protected virtual override void Dispose(bool disposing) {}
       public virtual override object GetService(Type service) { throw new NotImplementedException(); }
      //ctor: 
      public DataSet () {}
      //ctor: 
      public DataSet (string dataSetName) {}
      //ctor: 
      protected DataSet (System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
      //ctor: 
      protected DataSet (System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool ConstructSchema) {}
      public SerializationFormat RemotingFormat { get; set; }
      public virtual SchemaSerializationMode SchemaSerializationMode { get; set; }
      public bool CaseSensitive { get; set; }
      public DataViewManager DefaultViewManager { get { throw new NotImplementedException(); } }
      public bool EnforceConstraints { get; set; }
      public string DataSetName { get; set; }
      public string Namespace { get; set; }
      public string Prefix { get; set; }
      public PropertyCollection ExtendedProperties { get { throw new NotImplementedException(); } }
      public bool HasErrors { get { throw new NotImplementedException(); } }
      public virtual bool IsInitialized { get { throw new NotImplementedException(); } }
      public System.Globalization.CultureInfo Locale { get; set; }
      public override System.ComponentModel.ISite Site { get; set; }
      public DataRelationCollection Relations { get { throw new NotImplementedException(); } }
      public DataTableCollection Tables { get { throw new NotImplementedException(); } }
      protected System.ComponentModel.EventHandlerList Events { }
      public virtual System.ComponentModel.IContainer Container { get { throw new NotImplementedException(); } }
      public virtual bool DesignMode { get { throw new NotImplementedException(); } }
      // Event: 
   // public event MergeFailedEventHandler MergeFailed;
      // Event: 
   // public event EventHandler Initialized;
      // Event: 
   // public event EventHandler Disposed;
   }
}
