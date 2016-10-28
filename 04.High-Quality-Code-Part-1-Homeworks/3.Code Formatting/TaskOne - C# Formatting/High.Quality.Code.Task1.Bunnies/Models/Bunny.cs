using High.Quality.Code.Task1.Bunnies.Contracts;
using High.Quality.Code.Task1.Bunnies.Enumerations;
using High.Quality.Code.Task1.Bunnies.Helpers;
using System;
using System.Text;

namespace High.Quality.Code.Task1.Bunnies.Models
{
    [Serializable]
    public class Bunny
    {
        private int age;
        private string name;

        public Bunny(string name, int age, FurType furType)
        {
            this.Name = name;
            this.Age = age;
            this.FurType = FurType;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value.Length > 50)
                {
                    throw new ArgumentNullException("Name cannot be null or more than 50 symbols");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 30)
                {
                    throw new ArgumentOutOfRangeException("Age is not valid");
                }
                this.age = value;
            }
        }

        public FurType FurType { get; set; }

        public void Introduce(IWriter writer)
        {
            writer.WriteLine($"{this.Name} - \"I am {this.Age} years old!\"");
            writer.WriteLine($"{this.Name} - \"And I am {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");
        }

        public override string ToString()
        {
            var builderSize = 200;
            var builder = new StringBuilder(builderSize);

            builder.AppendLine($"Bunny name: {this.Name}");
            builder.AppendLine($"Bunny age: {this.Age}");
            builder.AppendLine($"Bunny fur: {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");

            return builder.ToString();
        }
    }
}
