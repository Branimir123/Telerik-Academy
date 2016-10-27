namespace PeopleTask.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        private string name;
        private ushort? age = null;

        public Person(string name, ushort? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public ushort? Age {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            var strBld = new StringBuilder();
            strBld.Append((this.age != null) ? String.Format("{0}, {1}", this.Name, this.Age) : String.Format("{0}, Age is not specified", this.Name));
            return strBld.ToString();
        }
    }
}
