using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            //WithoutPolymorphism.WithoutPol();
        }
    }
    public class WithoutPolymorphism
    {
        public static void WithoutPol()
        {
            var shapes = new List<Shape>()
            {
                new Square(),
                new Triangle()
            };

            foreach (var shape in shapes)
            {
                if (shape is Square)
                {
                    (shape as Square).DrawSquare();
                }
                else if (shape is Triangle)
                {
                    (shape as Triangle).DrawTriangle();
                }
            }

            Console.ReadKey();
        }

        public class Shape
        {

        }
        public class Square : Shape
        {
            public void DrawSquare()
            {
                Console.WriteLine("Draw square");
            }
        }
        public class Triangle : Shape
        {
            public void DrawTriangle()
            {
                Console.WriteLine("Draw triangle");
            }
        }
    }
}
