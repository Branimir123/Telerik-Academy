using System;
using System.Diagnostics;
using AdvancedMaths.Contracts;

namespace AdvancedMaths.Utilities
{
    public class TimerUtils
    {
        public const int ExecutionsCount = 100000;

        public static void ShowExecutionTime(Action action, ILogger logger)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            action();

            stopWatch.Stop();
            logger.Log(stopWatch.Elapsed);
        }
    }
}
