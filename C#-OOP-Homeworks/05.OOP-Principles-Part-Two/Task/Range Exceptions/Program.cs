namespace Range_Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Range_Exceptions.CustomExceptions;

    class Program
    {
        static DateTime RandomDay(Random gen, DateTime start, int range)
        {
            start = new DateTime(1995, 1, 1);
            range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        static void Main()
        {
            var timer1 = DateTime.Now;

            int rangeStart = 1;
            int rangeEnd = 100;

            DateTime dateStart = new DateTime(1990, 5, 5);
            DateTime dateEnd = new DateTime(2016, 6, 6);

            for (int i = -10; i < 110; i++)
            {
                try
                {
                    if (i < rangeStart || i > rangeEnd)
                    {
                        throw new InvalidRangeException<int>(rangeStart, rangeEnd, "Number is not in the valid range");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Int exception caught!");
                }
            }


            for (int i = 0; i < 10; i++)
            {
                DateTime randomDate = RandomDay(new Random(), new DateTime(1910, 1, 1) , 30);
                try
                {
                    if (randomDate < dateStart || randomDate > dateEnd)
                    {
                        throw new InvalidRangeException<DateTime>(dateStart, dateEnd, "Invalid date");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Date exception caught");
                }
                
            }



            var timer2 = DateTime.Now;
            Console.WriteLine(timer2 - timer1);

        }
    }
}
