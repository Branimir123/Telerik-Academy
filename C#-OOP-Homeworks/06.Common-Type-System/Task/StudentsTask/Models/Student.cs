using StudentsTask.Enums;
using System;
using System.Text;
namespace StudentsTask.Models
{
    public class Student : ICloneable, IComparable<Student>
    {
        public Student(
            string firstName,
            string middleName,
            string lastName,
            string ssn,
            string permanentAddress,
            string mobilePhone,
            string email,
            ushort course,
            Specialties specialty,
            Faculties faculty,
            Universities university)
        {
            this.FirstName = firstName;
            this.Middlename = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        public string FirstName { get; private set; }
        public string Middlename { get; private set; }
        public string LastName { get; private set; }
        public string Ssn { get; private set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public ushort Course { get; set; }
        public Specialties Specialty { get; set; }
        public Faculties Faculty { get; set; }
        public Universities University { get; set; }

        public override bool Equals(object obj)
        {
            //Assuming that every student has unique SSN, we don't need to check anything else
            Student student = (Student)obj;
            if (this.Ssn == student.Ssn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            var strBld = new StringBuilder();
            strBld.AppendLine(String.Format("First Name: {0};", this.FirstName));
            strBld.AppendLine(String.Format("Middle Name: {0};", this.Middlename));
            strBld.AppendLine(String.Format("Last Name: {0};", this.LastName));
            strBld.AppendLine(String.Format("SSN: {0};", this.Ssn));
            strBld.AppendLine(String.Format("Permanent Address: {0};", this.PermanentAddress));
            strBld.AppendLine(String.Format("Mobile Phone: {0};", this.MobilePhone));
            strBld.AppendLine(String.Format("Email: {0};", this.Email));
            strBld.AppendLine(String.Format("Course: {0};", this.Course));
            strBld.AppendLine(String.Format("Specialty: {0};", this.Specialty));
            strBld.AppendLine(String.Format("Faculty: {0};", this.Faculty));
            strBld.AppendLine(String.Format("University: {0};", this.University));
            return strBld.ToString();
        }

        public override int GetHashCode()
        {
            return this.Ssn.GetHashCode();
        }
        public static bool operator ==(Student obj1, Student obj2)
        {
            return (obj1.Ssn == obj2.Ssn) ? true : false;
        }

        public static bool operator !=(Student obj1, Student obj2)
        {
            return (obj1.Ssn != obj2.Ssn) ? true : false;
        }

        public object Clone()
        {
            Student student = new Student(
                this.FirstName,
                this.Middlename,
                this.LastName,
                this.Ssn,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                this.Course,
                this.Specialty,
                this.Faculty,
                this.University);
            return (object)student;
        }

        public int CompareTo(Student obj)
        {
            int firstNameCode = this.FirstName.CompareTo(obj.FirstName);
            int middleNameCode = this.Middlename.CompareTo(obj.Middlename);
            int lastNameCode = this.LastName.CompareTo(obj.LastName);

            if (firstNameCode== 0){
                if(middleNameCode == 0){
                    if(lastNameCode == 0){
                       return this.Ssn.CompareTo(obj.Ssn);  //All names the same, ssn decides 
                    }
                    else
                    {
                        return lastNameCode; //Last name different
                    }
                }
                else
                {
                    return middleNameCode; //Middle name different
                }
            }
            else
            {
                return firstNameCode; //First name different
            }
        }
    }
}
