
namespace System
{  


// Source:  d:/Beta/dotData/System.Console.dll  Build 4.6.24027.00
[Guid("b2cf826e-d080-3aff-9ce2-c79086c378b6")]
  public abstract sealed class Console : Object
{
    public static ConsoleKeyInfo ReadKey() { throw new NotImplementedException(); }
    public static ConsoleKeyInfo ReadKey(bool intercept) { throw new NotImplementedException(); }
    public static void ResetColor() {}
    public static void SetBufferSize(int width, int height) {}
    public static void SetWindowPosition(int left, int top) {}
    public static void SetWindowSize(int width, int height) {}
    public static void Beep() {}
    public static void Beep(int frequency, int duration) {}
    public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop) {}
    public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor) {}
    public static void Clear() {}
    public static void SetCursorPosition(int left, int top) {}
    public static IO.Stream OpenStandardInput() { throw new NotImplementedException(); }
    public static IO.Stream OpenStandardOutput() { throw new NotImplementedException(); }
    public static IO.Stream OpenStandardError() { throw new NotImplementedException(); }
    public static void SetIn(System.IO.TextReader newIn) {}
    public static void SetOut(System.IO.TextWriter newOut) {}
    public static void SetError(System.IO.TextWriter newError) {}
    public static int Read() { throw new NotImplementedException(); }
    public static string ReadLine() { throw new NotImplementedException(); }
    public static void WriteLine() {}
    public static void WriteLine(bool value) {}
    public static void WriteLine(char value) {}
    public static void WriteLine(char[] buffer) {}
    public static void WriteLine(char[] buffer, int index, int count) {}
    public static void WriteLine(decimal value) {}
    public static void WriteLine(double value) {}
    public static void WriteLine(float value) {}
    public static void WriteLine(int value) {}
    public static void WriteLine(uint value) {}
    public static void WriteLine(long value) {}
    public static void WriteLine(ulong value) {}
    public static void WriteLine(object value) {}
    public static void WriteLine(string value) {}
    public static void WriteLine(string format, object arg0) {}
    public static void WriteLine(string format, object arg0, object arg1) {}
    public static void WriteLine(string format, object arg0, object arg1, object arg2) {}
    public static void WriteLine(string format, object[] arg) {}
    public static void Write(string format, object arg0) {}
    public static void Write(string format, object arg0, object arg1) {}
    public static void Write(string format, object arg0, object arg1, object arg2) {}
    public static void Write(string format, object[] arg) {}
    public static void Write(bool value) {}
    public static void Write(char value) {}
    public static void Write(char[] buffer) {}
    public static void Write(char[] buffer, int index, int count) {}
    public static void Write(double value) {}
    public static void Write(decimal value) {}
    public static void Write(float value) {}
    public static void Write(int value) {}
    public static void Write(uint value) {}
    public static void Write(long value) {}
    public static void Write(ulong value) {}
    public static void Write(object value) {}
    public static void Write(string value) {}
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   public static IO.TextReader In { get; }
   public static Text.Encoding InputEncoding { get; set; }
   public static Text.Encoding OutputEncoding { get; set; }
   public static bool KeyAvailable { get; }
   public static IO.TextWriter Out { get; }
   public static IO.TextWriter Error { get; }
   public static bool IsInputRedirected { get; }
   public static bool IsOutputRedirected { get; }
   public static bool IsErrorRedirected { get; }
   public static int CursorSize { get; set; }
   public static bool NumberLock { get; }
   public static bool CapsLock { get; }
   public static ConsoleColor BackgroundColor { get; set; }
   public static ConsoleColor ForegroundColor { get; set; }
   public static int BufferWidth { get; set; }
   public static int BufferHeight { get; set; }
   public static int WindowLeft { get; set; }
   public static int WindowTop { get; set; }
   public static int WindowWidth { get; set; }
   public static int WindowHeight { get; set; }
   public static int LargestWindowWidth { get; }
   public static int LargestWindowHeight { get; }
   public static bool CursorVisible { get; set; }
   public static int CursorLeft { get; set; }
   public static int CursorTop { get; set; }
   public static string Title { get; set; }
   public static bool TreatControlCAsInput { get; set; }
//Event: 
public event ConsoleCancelEventHandler CancelKeyPress;
  }


// Source:  d:/Beta/dotData/System.Console.dll  Build 4.6.24027.00
[Guid("360e52ca-ee62-31dc-8177-c3a7829b4f5e")]
  public sealed delegate ConsoleCancelEventHandler; // : MulticastDelegate
//{
//    public virtual void Invoke(object sender, ConsoleCancelEventArgs e) {}
//    public virtual IAsyncResult BeginInvoke(object sender, ConsoleCancelEventArgs e, AsyncCallback callback, object object) { throw new NotImplementedException(); }
//    public virtual void EndInvoke(IAsyncResult result) {}
//    public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, Runtime.Serialization.StreamingContext context) {}
//    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
//    protected virtual override delegate CombineImpl(delegate follow) { throw new NotImplementedException(); }
//    protected virtual override delegate RemoveImpl(delegate value) { throw new NotImplementedException(); }
//    public virtual override delegate[] GetInvocationList() { throw new NotImplementedException(); }
//    public virtual override int GetHashCode() { throw new NotImplementedException(); }
//    protected virtual override Reflection.MethodInfo GetMethodImpl() { throw new NotImplementedException(); }
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
//    public static override delegate CreateDelegate(Type type, Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, object firstArgument, Reflection.MethodInfo method) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, object firstArgument, Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
//    public static override delegate CreateDelegate(Type type, Reflection.MethodInfo method) { throw new NotImplementedException(); }
//    public virtual override string ToString() { throw new NotImplementedException(); }
//    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
//    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
//    public override Type GetType() { throw new NotImplementedException(); }
//    protected virtual override void Finalize() {}
//    protected override object MemberwiseClone() { throw new NotImplementedException(); }
////ctor: 
//public ConsoleCancelEventHandler (object object, IntPtr method) {}
//   public Reflection.MethodInfo Method { get; }
//   public object Target { get; }
//  }


// Source:  d:/Beta/dotData/System.Console.dll  Build 4.6.24027.00
[Guid("81bef2e8-a82b-342e-acee-6adf6c1a473d")]
  public sealed class ConsoleCancelEventArgs : EventArgs
{
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
   public bool Cancel { get; set; }
   public ConsoleSpecialKey SpecialKey { get; }
// Field: 
public static readonly EventArgs Empty;
  }


// Source:  d:/Beta/dotData/System.Console.dll  Build 4.6.24027.00
[Guid("5946f667-6faa-3b49-abe8-5be28ad20638")]
  public sealed enum ConsoleColor // : Enum
{
    // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Console.dll  Build 4.6.24027.00
[Guid("beecb933-8672-3711-9204-37aad5f6020c")]
  public sealed enum ConsoleSpecialKey // : Enum
{
    // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Console.dll  Build 4.6.24027.00
[Guid("a3b0af7d-d234-306c-aeec-e6483bf4b98b")]
  public sealed enum ConsoleKey // : Enum
{
    // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Console.dll  Build 4.6.24027.00
[Guid("3645927f-f050-3383-a86a-b0c800288822")]
  public sealed struct ConsoleKeyInfo : ValueType
{
    public override bool Equals(object value) { throw new NotImplementedException(); }
    public bool Equals(ConsoleKeyInfo obj) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public ConsoleKeyInfo (char keyChar, ConsoleKey key, bool shift, bool alt, bool control) {}
   public char KeyChar { get; }
   public ConsoleKey Key { get; }
   public ConsoleModifiers Modifiers { get; }
  }


// Source:  d:/Beta/dotData/System.Console.dll  Build 4.6.24027.00
[Guid("3bec1b45-3e9a-3e62-8d28-2421e4f3aa96")]
  public sealed enum ConsoleModifiers // : Enum
{
    // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }

}