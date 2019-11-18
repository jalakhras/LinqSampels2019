using System;
using System.Collections.Generic;

namespace Queries
{
    public static class MyLinq
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool>predicate)
        {
          
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item; 
                }
            }
          
        }

        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, bool condition, Func<T, bool> predicate)
        {
            var result = condition ? source.Filter(predicate) : source;
            return result;

        }
    }
}
