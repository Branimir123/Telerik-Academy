using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewotkOOPTask3
{
    public abstract class Animal: ISound
    {
        private int age;
        private string sex;

        public string Sex
        {
            get { return this.sex; }
            set {
                if (!(value.Equals("Male") || value.Equals("Female")) )
                {
                    throw new ArgumentException("What the hell are you?!");
                }
                sex = value; }
        }
        
        public int Age
        {
            get { return this.age; }
            set {
                if (value<1)
                {
                    throw new ArgumentException("Are you sure?");
                }
                age = value; }
        }
        
        public string Name { get; set; }
        public Animal(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }
        public abstract void ProduceSound();

    }
}
