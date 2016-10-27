namespace HomeworkOOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Discipline
    {
        public Discipline(string name, double lectures, int numOfEx)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.NumberOfExercises = numOfEx;
        }
        public string Name { get; set; }
        public double Lectures { get; set; }
        public int NumberOfExercises { get; set; }
    }
}
