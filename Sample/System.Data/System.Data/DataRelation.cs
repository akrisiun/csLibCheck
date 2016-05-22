
   [Guid("28a715a9-0e4d-3e5f-85a2-d3fb10f07d1d")]
   public class DataRelation
   {
       protected void CheckStateForProperty() {}
       public override string ToString() { throw new NotImplementedException(); }
      //ctor: 
      public DataRelation (string relationName, DataColumn parentColumn, DataColumn childColumn) {}
      //ctor: 
      public DataRelation (string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) {}
      //ctor: 
      public DataRelation (string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) {}
      //ctor: 
      public DataRelation (string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) {}
      //ctor: 
      public DataRelation (string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) {}
      //ctor: 
      public DataRelation (string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) {}
      public virtual DataColumn[] ChildColumns { get { throw new NotImplementedException(); } }
      public virtual DataTable ChildTable { get { throw new NotImplementedException(); } }
      public virtual DataSet DataSet { get { throw new NotImplementedException(); } }
      public virtual DataColumn[] ParentColumns { get { throw new NotImplementedException(); } }
      public virtual DataTable ParentTable { get { throw new NotImplementedException(); } }
      public virtual string RelationName { get; set; }
      public virtual bool Nested { get; set; }
      public virtual UniqueConstraint ParentKeyConstraint { get { throw new NotImplementedException(); } }
      public virtual ForeignKeyConstraint ChildKeyConstraint { get { throw new NotImplementedException(); } }
      public PropertyCollection ExtendedProperties { get { throw new NotImplementedException(); } }
   }
}
