using SimpleMath.Contracts;
using SimpleMath.Utilities;

namespace SimpleMath.Operations
{
    public class Multiply
    {
        public static void DisplayAll(ILogger logger)
        {
            logger.Log("Multiply integers: ");
            TimerUtils.ShowExecutionTime(MultiplyIntegers, logger);

            logger.Log("Multiply long: ");
            TimerUtils.ShowExecutionTime(MultiplyLong, logger);

            logger.Log("Multiply float: ");
            TimerUtils.ShowExecutionTime(MultiplyFloat, logger);

            logger.Log("Multiply double: ");
            TimerUtils.ShowExecutionTime(MultiplyDouble, logger);

            logger.Log("Multiply decimal: ");
            TimerUtils.ShowExecutionTime(MultiplyDecimal, logger);
        }

        public static void MultiplyIntegers()
        {
            var result = 0;
            for (int i = 0; i < TimerUtils.ExecutionsCount; i++)
            {
                result *= i;
            }
        }

        public static void MultiplyLong()
        {
            var result = 0l;
            for (var i = 0l; i < TimerUtils.ExecutionsCount; i++)
            {
                result *= i;
            }
        }

        public static void MultiplyFloat()
        {
            var result = 0f;
            for (var i = 0f; i < TimerUtils.ExecutionsCount; i++)
            {
                result *= i;
            }
        }

        public static void MultiplyDouble()
        {
            var result = 0d;
            for (var i = 0d; i < TimerUtils.ExecutionsCount; i++)
            {
                result *= i;
            }
        }

        public static void MultiplyDecimal()
        {
            var result = 0m;
            for (var i = 0m; i < TimerUtils.ExecutionsCount; i++)
            {
                result *= i;
            }
        }
    }
}
