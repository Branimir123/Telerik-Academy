using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkOOP.Models;

namespace HomeworkOOP.ExtentionMethods
{
    static class StudentListExtensions
    {
        public static List<Student> ageRange(this IList<Student> list)
        {
            return list.Where(s => s.Age > HomeworkOOP.Utilities.Values.ageRangeMin && s.Age < HomeworkOOP.Utilities.Values.ageRangeMax).Select(s => s).ToList();
        }
        public static List<Student> firstNameBeforeLast(this IList<Student> list)
        {
            return list.Select(s => s).Where(s => s.FirstName.CompareTo(s.LastName) < 0).ToList();
        }

        public static void sortStudents(this IList<Student> list)
        {
            list = list.OrderBy(s => s.FirstName).ThenBy(s => s.LastName).ToList();
        }

        public static List<Student> extractByMail(this IList<Student> list, string mailService)
        {
            return list.Select(s => s).Where(s => s.Email.Contains(mailService) == true).ToList();
        }


    }
}
