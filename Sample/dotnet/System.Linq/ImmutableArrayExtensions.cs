
// Source:  \/Program Files (x86)/dotnet/bin/System.Collections.Immutable.dll  Build 4.6.24027.00
using System;
using System.Runtime.InteropServices;

namespace System.Linq
{  

   [Guid("92e3e8c5-8e1b-3e6f-986e-42c9df02baf9")]
   public static class ImmutableArrayExtensions
   {
       public static Select(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,System.Linq.TResult> selector) { throw new NotImplementedException(); }
       public static SelectMany(this System.Collections.Immutable.ImmutableArray<System.Linq.TSource> immutableArray, Func<System.Linq.TSource,System.Collections.Generic.IEnumerable> collectionSelector, Func<System.Linq.TSource,System.Linq.TCollection,System.Linq.TResult> resultSelector) { throw new NotImplementedException(); }
       public static Where(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,bool> predicate) { throw new NotImplementedException(); }
       public static bool Any(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray) { throw new NotImplementedException(); }
       public static bool Any(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,bool> predicate) { throw new NotImplementedException(); }
       public static bool All(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,bool> predicate) { throw new NotImplementedException(); }
       public static bool SequenceEqual(this System.Collections.Immutable.ImmutableArray<System.Linq.TBase> immutableArray, System.Collections.Immutable.ImmutableArray<System.Linq.TDerived> items, System.Collections.Generic.IEqualityComparer<System.Linq.TBase> comparer) { throw new NotImplementedException(); }
       public static bool SequenceEqual(this System.Collections.Immutable.ImmutableArray<System.Linq.TBase> immutableArray, System.Collections.Generic.IEnumerable<System.Linq.TDerived> items, System.Collections.Generic.IEqualityComparer<System.Linq.TBase> comparer) { throw new NotImplementedException(); }
       public static bool SequenceEqual(this System.Collections.Immutable.ImmutableArray<System.Linq.TBase> immutableArray, System.Collections.Immutable.ImmutableArray<System.Linq.TDerived> items, Func<System.Linq.TBase,System.Linq.TBase,bool> predicate) { throw new NotImplementedException(); }
       public static Aggregate(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,System.Linq.T,System.Linq.T> func) { throw new NotImplementedException(); }
       public static Aggregate(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, TAccumulate seed, Func<System.Linq.TAccumulate,System.Linq.T,System.Linq.TAccumulate> func) { throw new NotImplementedException(); }
       public static Aggregate(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, TAccumulate seed, Func<System.Linq.TAccumulate,System.Linq.T,System.Linq.TAccumulate> func, Func<System.Linq.TAccumulate,System.Linq.TResult> resultSelector) { throw new NotImplementedException(); }
       public static ElementAt(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, int index) { throw new NotImplementedException(); }
       public static ElementAtOrDefault(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, int index) { throw new NotImplementedException(); }
       public static First(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,bool> predicate) { throw new NotImplementedException(); }
       public static First(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray) { throw new NotImplementedException(); }
       public static FirstOrDefault(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray) { throw new NotImplementedException(); }
       public static FirstOrDefault(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,bool> predicate) { throw new NotImplementedException(); }
       public static Last(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray) { throw new NotImplementedException(); }
       public static Last(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,bool> predicate) { throw new NotImplementedException(); }
       public static LastOrDefault(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray) { throw new NotImplementedException(); }
       public static LastOrDefault(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,bool> predicate) { throw new NotImplementedException(); }
       public static Single(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray) { throw new NotImplementedException(); }
       public static Single(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,bool> predicate) { throw new NotImplementedException(); }
       public static SingleOrDefault(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray) { throw new NotImplementedException(); }
       public static SingleOrDefault(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,bool> predicate) { throw new NotImplementedException(); }
       public static ToDictionary(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,System.Linq.TKey> keySelector) { throw new NotImplementedException(); }
       public static ToDictionary(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,System.Linq.TKey> keySelector, Func<System.Linq.T,System.Linq.TElement> elementSelector) { throw new NotImplementedException(); }
       public static ToDictionary(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,System.Linq.TKey> keySelector, System.Collections.Generic.IEqualityComparer<System.Linq.TKey> comparer) { throw new NotImplementedException(); }
       public static ToDictionary(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray, Func<System.Linq.T,System.Linq.TKey> keySelector, Func<System.Linq.T,System.Linq.TElement> elementSelector, System.Collections.Generic.IEqualityComparer<System.Linq.TKey> comparer) { throw new NotImplementedException(); }
       public static ToArray(this System.Collections.Immutable.ImmutableArray<System.Linq.T> immutableArray) { throw new NotImplementedException(); }
       public static First(this System.Collections.Immutable.Builder<System.Linq.T> builder) { throw new NotImplementedException(); }
       public static FirstOrDefault(this System.Collections.Immutable.Builder<System.Linq.T> builder) { throw new NotImplementedException(); }
       public static Last(this System.Collections.Immutable.Builder<System.Linq.T> builder) { throw new NotImplementedException(); }
       public static LastOrDefault(this System.Collections.Immutable.Builder<System.Linq.T> builder) { throw new NotImplementedException(); }
       public static bool Any(this System.Collections.Immutable.Builder<System.Linq.T> builder) { throw new NotImplementedException(); }
   }
}
