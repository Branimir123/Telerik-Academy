using System;
using AdvancedMaths.Contracts;
using AdvancedMaths.Utilities;

namespace AdvancedMaths.Operations
{
    public static class Sinus
    {
        public static void DisplayAll(ILogger logger)
        {
            logger.Log("Sinus float: ");
            TimerUtils.ShowExecutionTime(SinusFloat, logger);

            logger.Log("Sinus double: ");
            TimerUtils.ShowExecutionTime(SinusDouble, logger);

            logger.Log("Sinus decimal: ");
            TimerUtils.ShowExecutionTime(SinusDecimal, logger);
        }

        public static void SinusFloat()
        {
            var result = 20000f;
            for (var i = 0f; i < TimerUtils.ExecutionsCount; i++)
            {
                result = (float)Math.Sin((double)result);
            }
        }

        public static void SinusDouble()
        {
            var result = 20000d;
            for (var i = 0d; i < TimerUtils.ExecutionsCount; i++)
            {
                result = Math.Sin(result);
            }
        }

        public static void SinusDecimal()
        {
            var result = 20000m;
            for (var i = 0m; i < TimerUtils.ExecutionsCount; i++)
            {
                result = (decimal)Math.Sin((double)result);
            }
        }
    }
}
