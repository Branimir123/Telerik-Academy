using SimpleMath.Contracts;
using SimpleMath.Utilities;

namespace SimpleMath.Operations
{
    public class Subtract
    {
        public static void DisplayAll(ILogger logger)
        {
            logger.Log("Subtracting integers: ");
            TimerUtils.ShowExecutionTime(SubtractIntegers, logger);

            logger.Log("Subtracting long: ");
            TimerUtils.ShowExecutionTime(SubtractLong, logger);

            logger.Log("Subtracting float: ");
            TimerUtils.ShowExecutionTime(SubtractFloat, logger);

            logger.Log("Subtracting double: ");
            TimerUtils.ShowExecutionTime(SubtractDouble, logger);

            logger.Log("Subtracting decimal: ");
            TimerUtils.ShowExecutionTime(SubtractDecimal, logger);
        }

        public static void SubtractIntegers()
        {
            var result = 0;
            for (int i = 0; i < TimerUtils.ExecutionsCount; i++)
            {
                result -= i;
            }
        }

        public static void SubtractLong()
        {
            var result = 0l;
            for (var i = 0l; i < TimerUtils.ExecutionsCount; i++)
            {
                result -= i;
            }
        }

        public static void SubtractFloat()
        {
            var result = 0f;
            for (var i = 0f; i < TimerUtils.ExecutionsCount; i++)
            {
                result -= i;
            }
        }

        public static void SubtractDouble()
        {
            var result = 0d;
            for (var i = 0d; i < TimerUtils.ExecutionsCount; i++)
            {
                result -= i;
            }
        }

        public static void SubtractDecimal()
        {
            var result = 0m;
            for (var i = 0m; i < TimerUtils.ExecutionsCount; i++)
            {
                result -= i;
            }
        }
    }
}
