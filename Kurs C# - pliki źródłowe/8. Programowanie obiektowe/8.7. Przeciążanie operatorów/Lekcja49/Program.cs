using System;

namespace Lekcja49
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt2D p1 = new Punkt2D(2, 5);
            p1.Show();
            Punkt2D p2 = new Punkt2D(5, 7);
            p2.Show();
            Punkt2D p3 = p1 + p2;
            p3.Show();
            Punkt2D p4 = p1 + 10;
            p4.Show();
        }
    }

    class Punkt2D
    {
        public Punkt2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x;
        public int y;

        public static Punkt2D operator +(Punkt2D a, Punkt2D b)
        {
            return new Punkt2D(a.x + b.x, a.y + b.y);
        }

        public static Punkt2D operator +(Punkt2D a, int b)
        {
            return new Punkt2D(a.x + b, a.y + b);
        }

        public void Show()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}
