using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shape = new IShape[]
            {
                new Triangle(2,7),
                new Rectangle(4,9),
                new Square(9)
            };

            foreach (IShape elem in shape)
            {
                Console.WriteLine(elem.CalculateSurface());
            }


            Console.ReadLine();
        }
    }
}
