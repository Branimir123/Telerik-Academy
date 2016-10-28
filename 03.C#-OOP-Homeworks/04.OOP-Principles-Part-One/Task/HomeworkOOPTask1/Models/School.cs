namespace HomeworkOOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        public School(string name, List<ClassOfStudents> classes)
        {
            this.Name = name;
            this.Classes = classes;
        }
        public string Name { get; set; }
        public List<ClassOfStudents> Classes { get; set; }
       
    }
}
