using System;
using High.Quality.Code.Task1.Bunnies.Contracts;

namespace High.Quality.Code.Task1.Bunnies
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
