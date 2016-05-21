
   [Guid("3645927f-f050-3383-a86a-b0c800288822")]
   public sealed struct ConsoleKeyInfo : ValueType
   {
       public override bool Equals(object value);
       public bool Equals(ConsoleKeyInfo obj);
       public override int GetHashCode();
       public virtual override string ToString();
       public static override bool Equals(object objA, object objB);
       public static override bool ReferenceEquals(object objA, object objB);
       public override Type GetType();
       protected virtual override void Finalize();
       protected override object MemberwiseClone();
      //ctor: 
   public ConsoleKeyInfo (char keyChar, ConsoleKey key, bool shift, bool alt, bool control) {}
      public char KeyChar { get; }
      public ConsoleKey Key { get; }
      public ConsoleModifiers Modifiers { get; }
   }
}
