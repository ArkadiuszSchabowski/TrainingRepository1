using System;

namespace Lekcja52
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            shape.Draw();
            rectangle.Draw();
            circle.Draw();
            Console.WriteLine("--------");
            ((Shape)rectangle).Draw();
            ((Shape)circle).Draw();

            Shape[] shapes = new Shape[2];
            shapes[0] = rectangle;
            shapes[1] = circle;

            Console.WriteLine("\nFor each:");
            foreach (Shape item in shapes)
            {
                item.Draw();
            }

            Console.WriteLine("--------");

            shape = rectangle;
            shape.Draw();
            Rectangle rectangle1 = (Rectangle)shape;
            rectangle1.Draw();
        }
    }

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Kształt");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Prostokąt");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Koło");
        }
    }
}
