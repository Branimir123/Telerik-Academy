using HomeworkControlFlow.Models.AbstractClasses;

namespace HomeworkControlFlow.Models
{
    public class Potato : Vegetable
    {
        public Potato()
        {

        }

        public bool isPeeled()
        {
            return true;
        }

        public bool isRotten()
        {
            return false;
        }
    }
}
