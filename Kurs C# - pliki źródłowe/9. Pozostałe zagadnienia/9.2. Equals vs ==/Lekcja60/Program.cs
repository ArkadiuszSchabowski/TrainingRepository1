using System;
using System.Diagnostics.CodeAnalysis;

namespace Lekcja60
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "Kurs C#";
            object t2 = new string("Kurs C#");

            Console.WriteLine("String:");
            Console.WriteLine($"== : {t1 == t2}");
            Console.WriteLine($"Equals : {t1.Equals(t2)}");

            Punkt2D p1 = new Punkt2D(2, 5);
            Punkt2D p2 = new Punkt2D(2, 5);
            
            Console.WriteLine("\nPunkt 2D:");
            Console.WriteLine($"== : {p1 == p2}");
            Console.WriteLine($"Equals : {p1.Equals(p2)}");
        }
    }

    class Punkt2D : IEquatable<Punkt2D>
    {
        public Punkt2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float x;
        public float y;

        public bool Equals([AllowNull] Punkt2D other)
        {
            return x == other.x && y == other.y;
        }
    }
}
