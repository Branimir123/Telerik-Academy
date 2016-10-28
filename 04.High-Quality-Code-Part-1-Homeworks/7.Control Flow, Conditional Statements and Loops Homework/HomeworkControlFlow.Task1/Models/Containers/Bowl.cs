using HomeworkControlFlow.Models.AbstractClasses;
using System.Collections.Generic;

namespace HomeworkControlFlow.Models
{
    public class Bowl
    {
        private ICollection<Vegetable> vegetables;

        public Bowl()
        {
            this.vegetables = new List<Vegetable>();
        }

        public void Add(Vegetable vegetable)
        {
            this.vegetables.Add(vegetable);
        }
    }
}
