namespace HomeworkOOP.ExtentionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder strBld, int start, int stop)
        {
            var str = new StringBuilder();
            for (int i = start; i < stop; i++)
            {
                str.Append(strBld[i]);
            }
            return str;
        }
    }
}
