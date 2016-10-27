using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Defining_Classes_part1
{
    class Display
    {
        public Display(double size, int numOfColors)
        {
            this.Size = size;
            this.NumOfColors = numOfColors;
        }
        public double Size { get; set; }
        public int NumOfColors { get; set; }
        public override string ToString()
        {
            var strBld = new StringBuilder();
            strBld.Append("{" + this.Size + ", ");
            strBld.Append(this.NumOfColors + "} ");
            return strBld.ToString();
        }
    }
}
