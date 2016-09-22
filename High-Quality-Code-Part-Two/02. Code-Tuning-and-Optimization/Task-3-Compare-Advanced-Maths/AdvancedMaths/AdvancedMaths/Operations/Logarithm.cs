using System;
using AdvancedMaths.Contracts;
using AdvancedMaths.Utilities;

namespace AdvancedMaths.Operations
{
    public static class Logarithm
    {
        public static void DisplayAll(ILogger logger)
        {
            
                logger.Log("Loging float: ");
                TimerUtils.ShowExecutionTime(LogFloat, logger);

                logger.Log("Loging double: ");
                TimerUtils.ShowExecutionTime(LogDouble, logger);

                logger.Log("Loging decimal: ");
                TimerUtils.ShowExecutionTime(LogDecimal, logger);
           
        }

        public static void LogFloat()
        {
            var result = 100000f;
            for (var i = 0f; i < TimerUtils.ExecutionsCount; i++)
            {
                result = (float)Math.Log((double)result);
            }
        }

        public static void LogDouble()
        {
            var result = 100000d;
            for (var i = 0d; i < TimerUtils.ExecutionsCount; i++)
            {
                result = Math.Log(result);
            }
        }

        public static void LogDecimal()
        {
            var result = 100000m;
            for (var i = 0m; i < TimerUtils.ExecutionsCount; i++)
            {
                result = (decimal)Math.Log((double)result);
            }
        }
    }
}
