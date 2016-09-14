using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Defining_Classes_part1
{
    class CallHistoryTest
    {
        //Test Class
        public CallHistoryTest()
        {
            //Create instance of GSM class
            var gsm = new GSM("Nexus4", "Google");
            gsm.addCall(new Call("22/05/34", "13:15", "089765434", 300));
            gsm.addCall(new Call("22/05/34", "13:15", "089765434", 200));
            gsm.addCall(new Call("22/05/34", "13:15", "089765434", 23));
            gsm.addCall(new Call("22/05/34", "13:15", "089765434", 17));
            gsm.addCall(new Call("22/05/34", "13:15", "089765434", 234));

            //Show calls
            gsm.showCalls();
            //Calculate price
            Console.WriteLine("Total price: {0} ", gsm.calculateTotalPrice(0.27));

            //Remove the longest call
            var maxDuration = gsm.CallHistory.Select(c => c.Duration).Max();
            Call call = gsm.CallHistory.FirstOrDefault(c => c.Duration == maxDuration);
            gsm.CallHistory.Remove((Call)call);

            //Show again
            gsm.showCalls();

            //Clear history
            gsm.clearCalls();

            //Show again
            gsm.showCalls();


        }
    }
}
