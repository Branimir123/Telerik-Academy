using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Defining_Classes_part1
{
    class Battery
    {
        public enum Battery_Type
        {
            Li_Ion,
            NiMH,
            NiCd            
        };

        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public string Model { get; set; }
        public double HoursIdle { get; set; }
        public double HoursTalk { get; set; }
        public Battery_Type BatteryType { get; set; }

        public override string ToString()
        {
            var strBld = new StringBuilder();
            strBld.Append("{" + this.Model + ", ");
            strBld.Append(this.HoursIdle + ", ");
            strBld.Append(this.HoursTalk + ", ");
            strBld.Append(this.BatteryType + "} ");
            return strBld.ToString();
        }
    }
}
