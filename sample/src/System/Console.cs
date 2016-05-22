
// Source:  /webstack/WPF/LibCheck/dnx/System.Console.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System
{  

   [Guid("b2cf826e-d080-3aff-9ce2-c79086c378b6")]
   public static class Console
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
      public static IO.TextReader In { get { throw new NotImplementedException(); } }
      public static Text.Encoding InputEncoding { get; set; }
      public static Text.Encoding OutputEncoding { get; set; }
      public static bool KeyAvailable { get { throw new NotImplementedException(); } }
      public static IO.TextWriter Out { get { throw new NotImplementedException(); } }
      public static IO.TextWriter Error { get { throw new NotImplementedException(); } }
      public static bool IsInputRedirected { get { throw new NotImplementedException(); } }
      public static bool IsOutputRedirected { get { throw new NotImplementedException(); } }
      public static bool IsErrorRedirected { get { throw new NotImplementedException(); } }
      public static int CursorSize { get; set; }
      public static bool NumberLock { get { throw new NotImplementedException(); } }
      public static bool CapsLock { get { throw new NotImplementedException(); } }
      public static ConsoleColor BackgroundColor { get; set; }
      public static ConsoleColor ForegroundColor { get; set; }
      public static int BufferWidth { get; set; }
      public static int BufferHeight { get; set; }
      public static int WindowLeft { get; set; }
      public static int WindowTop { get; set; }
      public static int WindowWidth { get; set; }
      public static int WindowHeight { get; set; }
      public static int LargestWindowWidth { get { throw new NotImplementedException(); } }
      public static int LargestWindowHeight { get { throw new NotImplementedException(); } }
      public static bool CursorVisible { get; set; }
      public static int CursorLeft { get; set; }
      public static int CursorTop { get; set; }
      public static string Title { get; set; }
      public static bool TreatControlCAsInput { get; set; }
      // Event: 
   // public event ConsoleCancelEventHandler CancelKeyPress;
   }
}
