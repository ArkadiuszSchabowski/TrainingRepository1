using System;

namespace Lekcja53
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            
            shape = (Shape)circle;
            // circle = (Circle)shape; - błąd 1/2
            // circle = rectangle; - błąd
            // circle = (Circle)"Abc"; - błąd
            object obj = shape;
            obj = rectangle;
            obj = circle;

            if (shape is Circle)
            {
                circle = (Circle)shape;
                circle.Draw();
            }
            else
            {
                circle = null;
            }
            shape = rectangle;

            rectangle = shape as Rectangle;
            if (rectangle != null)
                rectangle.Draw();
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
