using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOPTask2.Models
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, double weekSalary, double workHours)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHours;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }
        public double MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay;
        }
    }
}
