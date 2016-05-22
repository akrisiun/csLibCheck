
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.Immutable.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Collections.Immutable
{  

   [Guid("01e4b531-0fac-3ea6-95a7-32b1312ba63e")]
   public static class ImmutableDictionary
   {
       public static Create() { throw new NotImplementedException(); }
       public static Create(this System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TKey> keyComparer) { throw new NotImplementedException(); }
       public static Create(this System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TKey> keyComparer, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TValue> valueComparer) { throw new NotImplementedException(); }
       public static CreateRange(this System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair> items) { throw new NotImplementedException(); }
       public static CreateRange(this System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TKey> keyComparer, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair> items) { throw new NotImplementedException(); }
       public static CreateRange(this System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TKey> keyComparer, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TValue> valueComparer, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair> items) { throw new NotImplementedException(); }
       public static CreateBuilder() { throw new NotImplementedException(); }
       public static CreateBuilder(this System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TKey> keyComparer) { throw new NotImplementedException(); }
       public static CreateBuilder(this System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TKey> keyComparer, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TValue> valueComparer) { throw new NotImplementedException(); }
       public static ToImmutableDictionary(this System.Collections.Generic.IEnumerable<System.Collections.Immutable.TSource> source, Func<System.Collections.Immutable.TSource,System.Collections.Immutable.TKey> keySelector, Func<System.Collections.Immutable.TSource,System.Collections.Immutable.TValue> elementSelector, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TKey> keyComparer, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TValue> valueComparer) { throw new NotImplementedException(); }
       public static ToImmutableDictionary(this System.Collections.Generic.IEnumerable<System.Collections.Immutable.TSource> source, Func<System.Collections.Immutable.TSource,System.Collections.Immutable.TKey> keySelector, Func<System.Collections.Immutable.TSource,System.Collections.Immutable.TValue> elementSelector, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TKey> keyComparer) { throw new NotImplementedException(); }
       public static ToImmutableDictionary(this System.Collections.Generic.IEnumerable<System.Collections.Immutable.TSource> source, Func<System.Collections.Immutable.TSource,System.Collections.Immutable.TKey> keySelector) { throw new NotImplementedException(); }
       public static ToImmutableDictionary(this System.Collections.Generic.IEnumerable<System.Collections.Immutable.TSource> source, Func<System.Collections.Immutable.TSource,System.Collections.Immutable.TKey> keySelector, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TKey> keyComparer) { throw new NotImplementedException(); }
       public static ToImmutableDictionary(this System.Collections.Generic.IEnumerable<System.Collections.Immutable.TSource> source, Func<System.Collections.Immutable.TSource,System.Collections.Immutable.TKey> keySelector, Func<System.Collections.Immutable.TSource,System.Collections.Immutable.TValue> elementSelector) { throw new NotImplementedException(); }
       public static ToImmutableDictionary(this System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair> source, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TKey> keyComparer, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TValue> valueComparer) { throw new NotImplementedException(); }
       public static ToImmutableDictionary(this System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair> source, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.TKey> keyComparer) { throw new NotImplementedException(); }
       public static ToImmutableDictionary(this System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair> source) { throw new NotImplementedException(); }
       public static bool Contains(this IImmutableDictionary<System.Collections.Immutable.TKey,System.Collections.Immutable.TValue> map, TKey key, TValue value) { throw new NotImplementedException(); }
       public static GetValueOrDefault(this IImmutableDictionary<System.Collections.Immutable.TKey,System.Collections.Immutable.TValue> dictionary, TKey key) { throw new NotImplementedException(); }
       public static GetValueOrDefault(this IImmutableDictionary<System.Collections.Immutable.TKey,System.Collections.Immutable.TValue> dictionary, TKey key, TValue defaultValue) { throw new NotImplementedException(); }
   }
}
