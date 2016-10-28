using System;
using System.Linq;

namespace HomeworkVariables
{
    class StatisticsPrinter
    {
        private void PrintMax(double max)
        {
            throw new NotImplementedException();
        }

        private void PrintAvg(double d)
        {
            throw new NotImplementedException();
        }

        private void PrintMin(double max)
        {
            throw new NotImplementedException();
        }

        public void PrintStatistics(double[] arr, int count)
        {
            double max = arr.Max();
            PrintMax(max);

            double min = arr.Min();
            PrintMin(max);

            double avg = arr.Average();
            PrintAvg(avg);
        }
    }
}
