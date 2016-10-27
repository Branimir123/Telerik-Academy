using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Defining_Classes_part1
{
    class GSMTest
    {
        public GSM[] ArrayofGSM { get; set; }

        public GSMTest()
        {
            Battery bat = new Battery("LG", 25.6, 11.2);
            Display dis = new Display(5.3, 1245322);
            this.ArrayofGSM = new GSM[]{
            new GSM("Samsung Galaxy Y", "Samsung"),
            new GSM("Iphone5S", "Apple", 500),
            new GSM("LG Nexus 4", "Google", 100, bat, dis)
            };
        }
        public void showArray()
        {
            for (int i = 0; i < this.ArrayofGSM.Length; i++)
            {
                Console.WriteLine(this.ArrayofGSM[i]);
            }
        }

        public void showIphoneInfo()
        {
            Console.WriteLine(GSM.Iphone4S);
        }


    }

}
