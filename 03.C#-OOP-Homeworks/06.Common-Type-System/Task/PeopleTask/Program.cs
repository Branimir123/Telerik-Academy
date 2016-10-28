namespace PeopleTask
{
    using PeopleTask.Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            //Person class test
            Person person = new Person("Pesho");
            Person person2 = new Person("Ivan", 25);

            Console.WriteLine("{0} \n{1}", person, person2);
        }
    }
}
