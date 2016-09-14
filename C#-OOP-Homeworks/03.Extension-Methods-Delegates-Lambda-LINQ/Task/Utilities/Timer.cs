namespace HomeworkOOP.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Timer 
    {
        private int seconds;
        private int times;
        public delegate void Delegate();

        public Timer(int seconds, int times)
        {
            this.seconds = seconds;
            this.times = times;

            var name = new Delegate(MethodToBeExecuted);
            name.Invoke();
        }

      
        
        public void Start()
        {
            var del = new Delegate(MethodToBeExecuted);
            int interval = this.seconds;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            do
            {
                long t1 = sw.ElapsedMilliseconds;
                long t2 = sw.ElapsedMilliseconds;

                int temp = Convert.ToInt32(Math.Max(interval - (t2 - t1), 0));
                sw.Reset();
                if (temp > 0)
                {
                    System.Threading.Thread.Sleep(temp);
                }
                sw.Start();
                this.times--;
                del.Invoke();
            } while (this.times > 0);
        }

        public void MethodToBeExecuted()
        {
            Console.WriteLine(" Executing Method ");
        }

    }
}
