namespace Range_Exceptions.CustomExceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InvalidRangeException<T> : ArgumentException
    {
        public InvalidRangeException()
            : base()
        { }
        public InvalidRangeException(string msg)
            : base(msg)
        { }
        public InvalidRangeException(T start, T end, string msg):
            base(msg)
        {
            Console.WriteLine("{0}. Range is [{1} , {2}]", msg, start.ToString(), end.ToString());
        }

    }
}
