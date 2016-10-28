namespace StudentsTask
{
    using System;
    using StudentsTask.Models;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            //Some Tests
            Student student1 = new Student("Ivan", "Georgiev", "Ivanov", "098463527", "Sofia, Bulgaria, Nowhere", "0896349480", "student@studentSystem.org", 2, Enums.Specialties.ComputerScience, Enums.Faculties.FacultyOfInformatics, Enums.Universities.SoftwareUniversity);
            Student student2 = new Student("Ivan", "Peshev", "Ivanov", "0983463527", "Sofia, Bulgaria, Nowhere", "0896109480", "student@studentSystem.org", 2, Enums.Specialties.ComputerScience, Enums.Faculties.FacultyOfInformatics, Enums.Universities.SoftwareUniversity);
            //Equals()
            Console.WriteLine(student1.Equals(student2));
            //Operatr ==
            Console.WriteLine(student1 == student2);
            //Operator !=
            Console.WriteLine(student1 != student2);
            //GetHashCode()
            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine(student2.GetHashCode());
            //ToString()
            Console.WriteLine(student1);
            //Clone()
            Student student3 = (Student)student1.Clone();
            Console.WriteLine(student3);
            //CompareTo()
            Console.WriteLine(student1.CompareTo(student2));
        }
    }
}
