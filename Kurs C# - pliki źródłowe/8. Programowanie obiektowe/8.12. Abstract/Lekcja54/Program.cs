using System;

namespace Lekcja54
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape shape = new Shape(); - błąd
            //Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            // shape.Draw();
            //rectangle.Draw();
            circle.Draw();
            //rectangle.Hello();
        }
    }

    abstract class Shape
    {
        public abstract void Draw();
        public void Hello()
        {
            Console.WriteLine("Mam jakieś działanie");
        }
    }

    abstract class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Prostokąt");
        }
    }

    class Square : Rectangle
    {

    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Koło");
        }
    }
}
