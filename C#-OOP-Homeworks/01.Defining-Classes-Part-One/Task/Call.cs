using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Defining_Classes_part1
{
    class Call
    {
        public Call(string date, string time, string dp, int duratioin)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhone = dp;
            this.Duration = duratioin;
        }
        public string Date { get; set; }
        public string Time { get; set; }
        public string DialedPhone { get; set; }
        public int Duration { get; set; }

        public override string ToString()
        {
            var strBld = new StringBuilder();
            strBld.Append("Date: ").Append(this.Date).Append(", Time: ").Append(this.Time).Append("; Dialed Phone: ").Append(this.DialedPhone).Append("; Duration: ").Append(this.Duration);
            return strBld.ToString();
        }
    }
}
