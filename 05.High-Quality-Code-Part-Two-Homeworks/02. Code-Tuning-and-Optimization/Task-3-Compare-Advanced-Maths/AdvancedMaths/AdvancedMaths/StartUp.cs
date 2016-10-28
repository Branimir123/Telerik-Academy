using System;
using AdvancedMaths.Operations;
using AdvancedMaths.Utilities;

namespace AdvancedMaths
{
    public class StartUp
    {
        static void Main()
        {
            var consoleLogger = new ConsoleLogger();
            var separator = "*******************\n";

            try
            {
                SquareRoot.DisplayAll(consoleLogger);
                consoleLogger.Log(separator);

                Logarithm.DisplayAll(consoleLogger);
                consoleLogger.Log(separator);

                Sinus.DisplayAll(consoleLogger);
                consoleLogger.Log(separator);
            }

            catch (Exception ex)
            {
                consoleLogger.Log(ex.Message);
            }
        }
    }
}
