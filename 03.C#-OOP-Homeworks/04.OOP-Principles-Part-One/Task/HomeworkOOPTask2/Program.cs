using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkOOPTask2.Models;

namespace HomeworkOOPTask2
{
    class Program
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>{
                new Student("Ivan", "Ivanov", 5.54),
                new Student("Pesho", "Petrov", 6.00),
                new Student("Harry", "Potter", 5.34),
                new Student("John", "Snow", 3.33),
                new Student("Sansa", "Stark", 5.00),
                new Student("Daenerys ", "Targaryen", 3.00), 
                new Student("Theon", "Ivanov", 4.5),
                new Student("Valeri", "Bojinov", -2.00), //lol
                new Student("James", "Cameron", 2.00),
                new Student("Donald", "Trump", 2.00)
            };

            listOfStudents = listOfStudents.OrderBy(s => s.Grade).ToList();

            foreach (var student in listOfStudents)
            {
                Console.WriteLine(student.Grade);
            }

            List<Worker> listOfWorkers = new List<Worker>{
                new Worker("John", "Snow", 345.4, 4),
                new Worker("sdf", "sdf", 34, 56),
                new Worker("df", "sd", 312245.4, 56),
                new Worker("df", "df", 34235.2324, 3456),
                new Worker("sdfsdf", "Snow", 312345.4, 56),
                new Worker("sdf", "Snow", 356745.4, 34),
                new Worker("sdf", "sdfsdf", 367845.4, 45),
                new Worker("sdfsdf", "dsfsdfsdf", 678345.4, 78),
                new Worker("sdf", "sdfsfd", 346785.4, 25),
                new Worker("sdfsdf", "sdf", 346785.4, 13) 
            };

            listOfWorkers = listOfWorkers.OrderByDescending(s=>s.MoneyPerHour()).ToList();


            foreach (var worker in listOfWorkers)
            {
                Console.WriteLine(worker.MoneyPerHour());
            }
        }
    }
}
