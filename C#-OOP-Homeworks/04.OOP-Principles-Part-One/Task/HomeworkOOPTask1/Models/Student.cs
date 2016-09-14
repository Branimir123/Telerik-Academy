namespace HomeworkOOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : IHuman 
    {
        public Student(string name, string comment)
        {
            this.Name = name;
            this.Comment = comment;
        }
        public string Name { get; set; }
        public string Comment { get; set; }

    }
}
