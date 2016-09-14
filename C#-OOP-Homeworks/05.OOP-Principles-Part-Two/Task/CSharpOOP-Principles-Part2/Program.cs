using Shapes.Models;
using Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            //Creating List Of Shapes
            var shapes = new List<Shape>{
                new Triangle(10, 10),
                new Rectangle(6, 5),
                new Square(5.5)
            };
            //Writing the results on the console
            Console.WriteLine(shapes[0].CalculateSurface());
            Console.WriteLine(shapes[1].CalculateSurface());
            Console.WriteLine(shapes[2].CalculateSurface());
        }
    }
}
