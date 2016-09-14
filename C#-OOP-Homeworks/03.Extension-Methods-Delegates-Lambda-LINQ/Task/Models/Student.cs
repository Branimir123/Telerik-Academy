namespace HomeworkOOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Student
    {

        public Student(string firstName, string lastName, short age, int fN, string tel, string email, List<double> marks, short groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<double> Marks { get; set; }
        public short GroupNumber { get; set; }
    }
}
