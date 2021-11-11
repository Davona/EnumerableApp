using Microsoft.Build.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableApp
{
    public static class _Enumerable
    {
        public static TSource _FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {

            foreach (TSource element in source)
            {
                if (predicate(element)) return element;
            }
            return default(TSource);
        }
        public static TSource _LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {

            TSource result = default(TSource);
            foreach (TSource element in source)
            {
                if (predicate(element))
                {
                    result = element;
                }
            }
            return result;
        }
        public static bool _Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource element in source)
            {
                if (predicate(element)) return true;
            }
            return false;
        }
        public static int _Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            int count = 0;
            foreach (TSource element in source)
            {
                checked
                {
                    if (predicate(element)) count++;
                }
            }
            return count;
        }
        public static bool _All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {

            foreach (TSource element in source)
            {
                if (!predicate(element)) return false;
            }
            return true;
        }
        public static int _Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            return Enumerable.Sum(Enumerable.Select(source, selector));
        }
        public static IEnumerable<TResult> _Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        {
            
            return SelectIterator<TSource, TResult>(source, selector);
        }

        static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        {
            int index = -1;
            foreach (TSource element in source)
            {
                checked { index++; }
                yield return selector(element, index);
            }
        }
        public static int _Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            return Enumerable.Min(Enumerable.Select(source, selector));
        }
        public static int _Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            return Enumerable.Max(Enumerable.Select(source, selector));
        }
        public static double _Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            return Enumerable.Average(Enumerable.Select(source, selector));
        }
    }
}
