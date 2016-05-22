
   [Guid("208ac0d0-8d94-3fe0-8090-4813634573a2")]
   public class DataRow
   {
       public void AcceptChanges() {}
       public void BeginEdit() {}
       public void CancelEdit() {}
       public void Delete() {}
       public void EndEdit() {}
       public void SetColumnError(int columnIndex, string error) {}
       public void SetColumnError(string columnName, string error) {}
       public void SetColumnError(System.Data.DataColumn column, string error) {}
       public string GetColumnError(int columnIndex) { throw new NotImplementedException(); }
       public string GetColumnError(string columnName) { throw new NotImplementedException(); }
       public string GetColumnError(System.Data.DataColumn column) { throw new NotImplementedException(); }
       public void ClearErrors() {}
       public DataColumn[] GetColumnsInError() { throw new NotImplementedException(); }
       public DataRow[] GetChildRows(string relationName) { throw new NotImplementedException(); }
       public DataRow[] GetChildRows(string relationName, DataRowVersion version) { throw new NotImplementedException(); }
       public DataRow[] GetChildRows(System.Data.DataRelation relation) { throw new NotImplementedException(); }
       public DataRow[] GetChildRows(System.Data.DataRelation relation, DataRowVersion version) { throw new NotImplementedException(); }
       public DataRow GetParentRow(string relationName) { throw new NotImplementedException(); }
       public DataRow GetParentRow(string relationName, DataRowVersion version) { throw new NotImplementedException(); }
       public DataRow GetParentRow(System.Data.DataRelation relation) { throw new NotImplementedException(); }
       public DataRow GetParentRow(System.Data.DataRelation relation, DataRowVersion version) { throw new NotImplementedException(); }
       public DataRow[] GetParentRows(string relationName) { throw new NotImplementedException(); }
       public DataRow[] GetParentRows(string relationName, DataRowVersion version) { throw new NotImplementedException(); }
       public DataRow[] GetParentRows(System.Data.DataRelation relation) { throw new NotImplementedException(); }
       public DataRow[] GetParentRows(System.Data.DataRelation relation, DataRowVersion version) { throw new NotImplementedException(); }
       public bool HasVersion(System.Data.DataRowVersion version) { throw new NotImplementedException(); }
       public bool IsNull(int columnIndex) { throw new NotImplementedException(); }
       public bool IsNull(string columnName) { throw new NotImplementedException(); }
       public bool IsNull(System.Data.DataColumn column) { throw new NotImplementedException(); }
       public bool IsNull(System.Data.DataColumn column, DataRowVersion version) { throw new NotImplementedException(); }
       public void RejectChanges() {}
       protected void SetNull(System.Data.DataColumn column) {}
       public void SetParentRow(System.Data.DataRow parentRow) {}
       public void SetParentRow(System.Data.DataRow parentRow, DataRelation relation) {}
       public void SetAdded() {}
       public void SetModified() {}
      public string RowError { get; set; }
      public DataRowState RowState { get { throw new NotImplementedException(); } }
      public DataTable Table { get { throw new NotImplementedException(); } }
      public object this [int columnIndex] { get; set; }
      public object this [string columnName] { get; set; }
      public object this [System.Data.DataColumn column] { get; set; }
      public object this [int columnIndex, DataRowVersion version] { get { throw new NotImplementedException(); } }
      public object this [string columnName, DataRowVersion version] { get { throw new NotImplementedException(); } }
      public object this [System.Data.DataColumn column, DataRowVersion version] { get { throw new NotImplementedException(); } }
      public Object[] ItemArray { get; set; }
      public bool HasErrors { get { throw new NotImplementedException(); } }
   }
}
