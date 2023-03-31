using System;

namespace Lekcja61
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt3D p1 = new Punkt3D(2, 5, 10);
            Console.WriteLine(p1);
        }
    }

    class Punkt3D
    {
        public Punkt3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float x, y, z;

        public override string ToString()
        {
            return $"x = {x}, y = {y}, z = {z}";
        }
    }
}
