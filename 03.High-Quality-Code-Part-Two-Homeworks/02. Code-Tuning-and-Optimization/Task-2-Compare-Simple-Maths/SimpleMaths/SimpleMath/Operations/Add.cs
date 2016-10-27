using SimpleMath.Contracts;
using SimpleMath.Utilities;

namespace SimpleMath.Operations
{
    public static class Add
    {
        public static void DisplayAll(ILogger logger)
        {
            logger.Log("Adding integers: ");
            TimerUtils.ShowExecutionTime(AddIntegers, logger);

            logger.Log("Adding long: ");
            TimerUtils.ShowExecutionTime(AddLong, logger);

            logger.Log("Adding float: ");
            TimerUtils.ShowExecutionTime(AddFloat, logger);

            logger.Log("Adding double: ");
            TimerUtils.ShowExecutionTime(AddDouble, logger);

            logger.Log("Adding decimal: ");
            TimerUtils.ShowExecutionTime(AddDecimal, logger);
        }

        public static void AddIntegers()
        {
            var result = 0;
            for (int i = 0; i < TimerUtils.ExecutionsCount; i++)
            {
                result += i;
            }
        }

        public static void AddLong()
        {
            var result = 0l;
            for (var i = 0l; i < TimerUtils.ExecutionsCount; i++)
            {
                result += i;
            }
        }

        public static void AddFloat()
        {
            var result = 0f;
            for (var i = 0f; i < TimerUtils.ExecutionsCount; i++)
            {
                result += i;
            }
        }

        public static void AddDouble()
        {
            var result = 0d;
            for (var i = 0d; i < TimerUtils.ExecutionsCount; i++)
            {
                result += i;
            }
        }

        public static void AddDecimal()
        {
            var result = 0m;
            for (var i = 0m; i < TimerUtils.ExecutionsCount; i++)
            {
                result += i;
            }
        }
    }
}
