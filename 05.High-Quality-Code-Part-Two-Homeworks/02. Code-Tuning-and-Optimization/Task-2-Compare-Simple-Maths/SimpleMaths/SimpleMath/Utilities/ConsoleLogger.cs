using System;
using SimpleMath.Contracts;

namespace SimpleMath.Utilities 
{
    public class ConsoleLogger : ILogger
    {
        public void Log(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
