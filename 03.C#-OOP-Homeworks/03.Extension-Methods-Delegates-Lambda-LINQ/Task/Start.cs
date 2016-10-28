using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkOOP.ExtentionMethods;
using HomeworkOOP.Models;
using HomeworkOOP.Utilities;

namespace HomeworkOOP
{
    class Start
    {
        public static int[] devisibleBy(int[] array)
        {
            return array.Where(s => s % 3 == 0 || s % 7 == 0).Select(s => s).ToArray();
        }

        static void Main()
        {

            var strBld = new StringBuilder();
            strBld.AppendLine("sdgijdfigjdfigjdf gijdf gdfgdfg ");
            string subs = strBld.Substring(1, 5).ToString();
            Console.WriteLine(subs);

            var myList = new List<int> { 1, 22, 678, 56 };
            Console.WriteLine(myList.Product());
            
            //Initializing random list of students and some marks
            var someMarks = new List<double> { 2, 2, 6, 3, 5 };
            var listOfStudents = new List<Student>{
                new Student("Ivan", "Andonov", 17, 61908, "0893464468", "djf@abv.bg", someMarks, 3),
                new Student("Petur", "Sotirov", 16, 61903, "0834346468", "djf@gmail.com", someMarks, 3),
                new Student("Georgi", "Minchev", 22, 61904, "0894356468", "djf@abv.bg", someMarks, 3),
                new Student("Andrei", "Sotirov", 23, 61902, "0893446468", "djf@yahoo.com", someMarks, 3)
            };

            Console.WriteLine(HomeworkOOP.Utilities.Values.separator);
            // First before last test
            var fbl = listOfStudents.firstNameBeforeLast();
            foreach (var col in fbl)
            {
                Console.WriteLine(col.FN);
            }
            Console.WriteLine(HomeworkOOP.Utilities.Values.separator);
            // Age range test
            var age = listOfStudents.ageRange();
            foreach (var col in age)
            {
                Console.WriteLine("{0} {1}", col.FirstName, col.LastName);
            }
            Console.WriteLine(HomeworkOOP.Utilities.Values.separator);
            // Sorting test
            listOfStudents.sortStudents();
            foreach (var col in listOfStudents)
            {
                Console.WriteLine("{0} {1}", col.FirstName, col.LastName);
            }
            Console.WriteLine(HomeworkOOP.Utilities.Values.separator);
            // Extracting by email test
            Console.WriteLine("Emails");
            var extractedByEmail = listOfStudents.extractByMail("abv.bg");
            foreach (var col in extractedByEmail)
            {
                Console.WriteLine("{0} {1}", col.FirstName, col.LastName);
            }
            Console.WriteLine(HomeworkOOP.Utilities.Values.separator);
            //Extract by marks and return anonymous type test
            var extractedByMarks = listOfStudents.Where(s => s.Marks.Contains(6))
                .Select(s =>
                    new
                    {
                        FullName = string.Format("{0} {1}", s.FirstName, s.LastName),
                        Marks = string.Join(" ", s.Marks.ToArray())
                    });

            foreach (var col in extractedByMarks)
            {
                Console.WriteLine("{0} {1}", col.FullName, col.Marks.ToString());
            }
            Console.WriteLine(HomeworkOOP.Utilities.Values.separator);
            //Extract by two marks 2 
            var extractByTwo = listOfStudents.Where(s => s.Marks.Where(m => m == 2).ToList().Count == 2).Select(s=>
                 new
                 {
                     FullName = string.Format("{0} {1}", s.FirstName, s.LastName),
                     Marks = string.Join(" ", s.Marks.ToArray())
                 });
            foreach (var col in extractByTwo)
            {
                Console.WriteLine("{0} {1}", col.FullName, col.Marks.ToString());
            }
            Console.WriteLine(HomeworkOOP.Utilities.Values.separator);
            // Devisible by 7 or 3 test 
            int[] numbers = new int[]{1,2,3,4,5,6,7,8,9,10};
            numbers = devisibleBy(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(HomeworkOOP.Utilities.Values.separator);
            // Initializing timer
            var timer = new Timer(2000, 5);
            // Timer test
            timer.Start();

        }


    }
}
