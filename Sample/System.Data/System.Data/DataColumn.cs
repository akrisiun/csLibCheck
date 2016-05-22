
   [Guid("7ae16284-bc54-3d58-b276-b5b4d6d65157")]
   public class DataColumn : System.ComponentModel.MarshalByValueComponent
   {
       public void SetOrdinal(int ordinal) {}
       protected void CheckUnique() {}
      // protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) {}
       public override string ToString() { throw new NotImplementedException(); }
       public virtual override void Dispose() {}
       protected virtual override void Dispose(bool disposing) {}
       public virtual override object GetService(Type service) { throw new NotImplementedException(); }
      //ctor: 
      public DataColumn (string columnName, Type dataType) {}
      //ctor: 
      public DataColumn (string columnName, Type dataType, string expr, MappingType type) {}
      //ctor: 
      public DataColumn () {}
      //ctor: 
      public DataColumn (string columnName) {}
      //ctor: 
      public DataColumn (string columnName, Type dataType, string expr) {}
      public bool AllowDBNull { get; set; }
      public bool AutoIncrement { get; set; }
      public long AutoIncrementSeed { get; set; }
      public long AutoIncrementStep { get; set; }
      public string Caption { get; set; }
      public string ColumnName { get; set; }
      public string Prefix { get; set; }
      public Type DataType { get; set; }
      public DataSetDateTime DateTimeMode { get; set; }
      public object DefaultValue { get; set; }
      public string Expression { get; set; }
      public PropertyCollection ExtendedProperties { get { throw new NotImplementedException(); } }
      public int MaxLength { get; set; }
      public string Namespace { get; set; }
      public int Ordinal { get { throw new NotImplementedException(); } }
      public bool ReadOnly { get; set; }
      public DataTable Table { get { throw new NotImplementedException(); } }
      public bool Unique { get; set; }
      public virtual MappingType ColumnMapping { get; set; }
      protected System.ComponentModel.EventHandlerList Events { }
      public virtual System.ComponentModel.ISite Site { get; set; }
      public virtual System.ComponentModel.IContainer Container { get { throw new NotImplementedException(); } }
      public virtual bool DesignMode { get { throw new NotImplementedException(); } }
      // Event: 
   // public event EventHandler Disposed;
   }
}
