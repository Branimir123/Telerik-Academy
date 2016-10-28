namespace HomeworkOOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClassOfStudents
    {
        public ClassOfStudents(string name, List<Teacher> teachers, string comment)
        {
            this.Name = name;
            this.Teachers = teachers;
            this.Comment = comment;
        }
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
        public string Comment { get; set; }
    }
}
