using System;
using AdvancedMaths.Contracts;

namespace AdvancedMaths.Utilities 
{
    public class ConsoleLogger : ILogger
    {
        public void Log(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
