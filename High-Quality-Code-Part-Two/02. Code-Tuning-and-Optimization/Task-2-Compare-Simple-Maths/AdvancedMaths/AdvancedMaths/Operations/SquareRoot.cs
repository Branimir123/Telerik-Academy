using System;
using AdvancedMaths.Contracts;
using AdvancedMaths.Utilities;

namespace AdvancedMaths.Operations
{
    public static class SquareRoot
    {
        public static void DisplayAll(ILogger logger)
        {
            logger.Log("Sqrt float: ");
            TimerUtils.ShowExecutionTime(SqrtFloat, logger);

            logger.Log("Sqrt double: ");
            TimerUtils.ShowExecutionTime(SqrtDouble, logger);

            logger.Log("Sqrt decimal: ");
            TimerUtils.ShowExecutionTime(SqrtDecimal, logger);
        }

        public static void SqrtFloat()
        {
            var result = 2f;
            for (var i = 0f; i < TimerUtils.ExecutionsCount; i++)
            {
                result = (float)Math.Sqrt((double)result);
            }
        }

        public static void SqrtDouble()
        {
            var result = 2d;
            for (var i = 0d; i < TimerUtils.ExecutionsCount; i++)
            {
                result = Math.Sqrt(result);
            }
        }

        public static void SqrtDecimal()
        {
            var result = 2m;
            for (var i = 0m; i < TimerUtils.ExecutionsCount; i++)
            {
                result = (decimal)Math.Sqrt((double)result);
            }
        }
    }
}
