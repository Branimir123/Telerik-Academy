using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Defining_Classes_part1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Test 1:");
            Console.WriteLine();

                //Note that the two test classes work differently one has
                //and the other does everything in the constructor

            //Test of phone
            var test = new GSMTest();
            test.showArray();
            test.showIphoneInfo();

            Console.WriteLine();
            Console.WriteLine("Test 2:");
            Console.WriteLine();
            
            //Test of history 
            var callhistorytest = new CallHistoryTest();
        }
    }
}
