using SimpleMath.Contracts;
using SimpleMath.Utilities;

namespace SimpleMath.Operations
{
    public static class Increment
    {
        public static void DisplayAll(ILogger logger)
        {
            logger.Log("Increment integers: ");
            TimerUtils.ShowExecutionTime(IncrementIntegers, logger);

            logger.Log("Increment long: ");
            TimerUtils.ShowExecutionTime(IncrementLong, logger);

            logger.Log("Increment float: ");
            TimerUtils.ShowExecutionTime(IncrementFloat, logger);

            logger.Log("Increment double: ");
            TimerUtils.ShowExecutionTime(IncrementDouble, logger);

            logger.Log("Increment decimal: ");
            TimerUtils.ShowExecutionTime(IncrementDecimal, logger);
        }

        public static void IncrementIntegers()
        {
            var result = 0;
            for (int i = 0; i < TimerUtils.ExecutionsCount; i++)
            {
                result++;
            }
        }

        public static void IncrementLong()
        {
            var result = 0l;
            for (var i = 0l; i < TimerUtils.ExecutionsCount; i++)
            {
                result++;
            }
        }

        public static void IncrementFloat()
        {
            var result = 0f;
            for (var i = 0f; i < TimerUtils.ExecutionsCount; i++)
            {
                result++;
            }
        }

        public static void IncrementDouble()
        {
            var result = 0d;
            for (var i = 0d; i < TimerUtils.ExecutionsCount; i++)
            {
                result++;
            }
        }

        public static void IncrementDecimal()
        {
            var result = 0m;
            for (var i = 0m; i < TimerUtils.ExecutionsCount; i++)
            {
                result++;
            }
        }
    }
}
