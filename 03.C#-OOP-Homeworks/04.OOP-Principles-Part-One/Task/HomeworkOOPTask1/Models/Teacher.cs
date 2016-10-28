namespace HomeworkOOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

     public class Teacher : IHuman
    {
        public Teacher(string name, string comment, List<Discipline> disciplines)
        {
            this.Name = name;
            this.Comment = comment;
            this.Disciplines = disciplines;
        }
        public string Name { get; set; }
        public string Comment { get; set; }
        public List<Discipline> Disciplines { get; set; }
    }
}
