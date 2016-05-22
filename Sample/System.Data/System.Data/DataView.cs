
   [Guid("954dcfbb-b6bf-3baa-b683-d6ecdb9e8fd8")]
   public class DataView : System.ComponentModel.MarshalByValueComponent System.ComponentModel.IBindingListView, System.ComponentModel.ITypedList, System.ComponentModel.ISupportInitializeNotification
   {
       public virtual DataRowView AddNew() { throw new NotImplementedException(); }
       public virtual void BeginInit() {}
       public virtual void EndInit() {}
       protected void Close() {}
       public virtual void CopyTo(Array array, int index) {}
       public void Delete(int index) {}
       protected override void Dispose(bool disposing) {}
       public int Find(object key) { throw new NotImplementedException(); }
       public int Find(object[] key) { throw new NotImplementedException(); }
       public DataRowView[] FindRows(object key) { throw new NotImplementedException(); }
       public DataRowView[] FindRows(object[] key) { throw new NotImplementedException(); }
       public virtual System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
       protected virtual void IndexListChanged(object sender, System.ComponentModel.ListChangedEventArgs e) {}
       protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) {}
       protected void Open() {}
       protected void Reset() {}
       protected void UpdateIndex() {}
       protected virtual void UpdateIndex(bool force) {}
       protected virtual void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {}
       public DataTable ToTable() { throw new NotImplementedException(); }
       public DataTable ToTable(string tableName) { throw new NotImplementedException(); }
       public DataTable ToTable(bool distinct, string[] columnNames) { throw new NotImplementedException(); }
       public DataTable ToTable(string tableName, bool distinct, string[] columnNames) { throw new NotImplementedException(); }
       public virtual bool Equals(System.Data.DataView view) { throw new NotImplementedException(); }
       public virtual override void Dispose() {}
       public virtual override object GetService(Type service) { throw new NotImplementedException(); }
      //ctor: 
      public DataView () {}
      //ctor: 
      public DataView (System.Data.DataTable table) {}
      //ctor: 
      public DataView (System.Data.DataTable table, string RowFilter, string Sort, DataViewRowState RowState) {}
      public bool AllowDelete { get; set; }
      public bool ApplyDefaultSort { get; set; }
      public bool AllowEdit { get; set; }
      public bool AllowNew { get; set; }
      public virtual int Count { get { throw new NotImplementedException(); } }
      public DataViewManager DataViewManager { get { throw new NotImplementedException(); } }
      public virtual bool IsInitialized { get { throw new NotImplementedException(); } }
      protected bool IsOpen { }
      public virtual string RowFilter { get; set; }
      public DataViewRowState RowStateFilter { get; set; }
      public string Sort { get; set; }
      public DataTable Table { get; set; }
      public DataRowView this [int recordIndex] { get { throw new NotImplementedException(); } }
      protected System.ComponentModel.EventHandlerList Events { }
      public virtual System.ComponentModel.ISite Site { get; set; }
      public virtual System.ComponentModel.IContainer Container { get { throw new NotImplementedException(); } }
      public virtual bool DesignMode { get { throw new NotImplementedException(); } }
      // Event: 
   // public event System.ComponentModel.ListChangedEventHandler ListChanged;
      // Event: 
   // public event EventHandler Initialized;
      // Event: 
   // public event EventHandler Disposed;
   }
}
