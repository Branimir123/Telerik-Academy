using SimpleMath.Contracts;
using SimpleMath.Utilities;

namespace SimpleMath.Operations
{
    public static class Divide
    {
        public static void DisplayAll(ILogger logger)
        {
            logger.Log("Divide integers: ");
            TimerUtils.ShowExecutionTime(DivideIntegers, logger);

            logger.Log("Divide long: ");
            TimerUtils.ShowExecutionTime(DivideLong, logger);

            logger.Log("Divide float: ");
            TimerUtils.ShowExecutionTime(DivideFloat, logger);

            logger.Log("Divide double: ");
            TimerUtils.ShowExecutionTime(DivideDouble, logger);

            logger.Log("Divide decimal: ");
            TimerUtils.ShowExecutionTime(DivideDecimal, logger);
        }

        public static void DivideIntegers()
        {
            var result = 0;
            for (int i = 0; i < TimerUtils.ExecutionsCount; i++)
            {
                result /= 1;
            }
        }

        public static void DivideLong()
        {
            var result = 0l;
            for (var i = 0l; i < TimerUtils.ExecutionsCount; i++)
            {
                result /= 1;
            }
        }

        public static void DivideFloat()
        {
            var result = 0f;
            for (var i = 0f; i < TimerUtils.ExecutionsCount; i++)
            {
                result /= 1;
            }
        }

        public static void DivideDouble()
        {
            var result = 0d;
            for (var i = 0d; i < TimerUtils.ExecutionsCount; i++)
            {
                result /= 1;
            }
        }

        public static void DivideDecimal()
        {
            var result = 0m;
            for (var i = 0m; i < TimerUtils.ExecutionsCount; i++)
            {
                result /= 1;
            }
        }
    }
}
