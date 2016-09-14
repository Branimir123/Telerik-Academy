namespace HomeworkOOP.ExtentionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    static class IEnumerableExtensions
    {
        public static T Sum<T> (this IEnumerable<T> en)
        {
            return en.Sum();
        }

        public static T Product<T>(this IEnumerable<T> en)
        {
            dynamic product = 1;
            foreach (dynamic p in en)
            {
                product *= p;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> en)
        {
            return en.Min();
        }

        public static T Max<T>(this IEnumerable<T> en)
        {
            return en.Max();
        }

        public static T Average<T>(this IEnumerable<T> en)
        {
            return en.Average();
        }




    }
}
