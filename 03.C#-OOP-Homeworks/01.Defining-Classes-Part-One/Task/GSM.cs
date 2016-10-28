using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Defining_Classes_part1
{
    class GSM
    {
        private List<Call> callHistory = new List<Call>();
        public GSM(string model, string manufacturer, double price, Battery battery, Display display): this(model, manufacturer, price)
        {
            this.Battery = battery;
            this.Display = display;
        }

        public GSM(string model, string manufacturer, double price): this(model, manufacturer)
        {
            this.Price = price;
        }
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = 0.0;
            this.Battery = null;
            this.Display = null;
        }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public List<Call> CallHistory {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }
        
        public static GSM Iphone4S
        {
            get
            {
                var battery = new Battery("Bateriq", 25, 9);
                var display = new Display(4.7, 16000000);
                var iphone = new GSM("Iphone4S", "Apple", 200.0, battery, display);
                return iphone;
            }
        }

        public override string ToString()
        {
            var strBld = new StringBuilder();
            strBld.Append("{" + this.Model + ", ");
            strBld.Append(this.Manufacturer + ", ");
            strBld.Append((this.Price > 0.0)? this.Price + ", " : "");
            strBld.Append((this.Battery != null) ? this.Battery + ", " : "");
            strBld.Append((this.Display != null)? this.Display + "}" : "}");
            return strBld.ToString();
        }

        public void showCalls()
        {
            foreach (Call c in this.CallHistory)
            {
                Console.WriteLine(c);
            }
        }

        public void clearCalls()
        {
            Console.WriteLine("Cleared");
            this.CallHistory = new List<Call>();
        }

        public void addCall(Call call){
            this.CallHistory.Add(call);
        }

        public void deleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public double calculateTotalPrice(double price)
        {
            double totalPrice = 0;
            totalPrice += this.CallHistory.Select(c => c.Duration * price).Sum();
            return totalPrice;
        }
    }
}
