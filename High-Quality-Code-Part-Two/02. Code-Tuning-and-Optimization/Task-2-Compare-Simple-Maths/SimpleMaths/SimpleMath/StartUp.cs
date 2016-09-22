using SimpleMath.Operations;
using SimpleMath.Utilities;

namespace SimpleMath
{
    class StartUp
    {
        static void Main()
        {
            var consoleLogger = new ConsoleLogger();
            var separator = "*******************\n";

            consoleLogger.Log("Add: ");
            Add.DisplayAll(consoleLogger);
            consoleLogger.Log(separator);

            consoleLogger.Log("Subtract: ");
            Subtract.DisplayAll(consoleLogger);
            consoleLogger.Log(separator);

            consoleLogger.Log("Multiply: ");
            Multiply.DisplayAll(consoleLogger);
            consoleLogger.Log(separator);

            consoleLogger.Log("Divide:");
            Divide.DisplayAll(consoleLogger);
            consoleLogger.Log(separator);

            consoleLogger.Log("Increment:");
            Increment.DisplayAll(consoleLogger);
            consoleLogger.Log(separator);

        }
    }
}
