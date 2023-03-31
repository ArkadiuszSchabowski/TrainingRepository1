using System;
using System.Diagnostics.CodeAnalysis;

namespace Lekcja55
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 3);
            rectangle.Draw();
            Circle circle = new Circle(4);
            circle.Draw();

            rectangle.Area();
            circle.Area();

            //((IArea)circle).Other();
            IArea.Other();
            Console.WriteLine(circle.Equals(new Circle(2)));
            Console.WriteLine(rectangle.Equals(new Rectangle(10, 3)));
        }
    }

    abstract class Shape
    {
        public abstract void Draw();
    }

    class Rectangle : Shape, IArea
    {
        public Rectangle(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public float a;
        public float b;

        public override void Draw()
        {
            Console.WriteLine($"Prostokąt: a = {a}, b = {b}");
        }

        public void Area()
        {
            Console.WriteLine($"Pole prostokąta = {Math.Round(a * b, 2)}");
        }
    }

    class Circle : Shape, IArea, IEquatable<Circle>
    {
        public Circle(float r)
        {
            this.r = r;
        }
        public float r;

        public override void Draw()
        {
            Console.WriteLine($"Koło: r = {r}");
        }

        public void Area()
        {
            Console.WriteLine($"Pole koła = {Math.Round(Math.PI * r * r, 2)}");
        }

        public bool Equals([AllowNull] Circle other)
        {
            return r == other.r;
        }
    }

    interface IArea
    {
        const int num = 1;

        void Area();
        public static void Other()
        {
            Console.WriteLine("Mam domyślne działanie.");
        }
    }
}
