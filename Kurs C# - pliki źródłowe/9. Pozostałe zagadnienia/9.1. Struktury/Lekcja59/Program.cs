using System;
using System.Diagnostics.CodeAnalysis;

namespace Lekcja59
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt2D p1 = new Punkt2D(2, 3);
            //p1.x = 2;
            //p1.y = 3;
            p1.Show();

            Punkt2D p2;
            p2 = p1;
            p2.x = 20;
            p2.y = 30;
            p2.Show();
            p1.Show();
            Console.WriteLine("---------");
            Punkt3D p3 = new Punkt3D(2, 3, 4);
            Punkt3D p4;
            p4 = p3;
            p4.x = 20;
            p4.y = 30;
            p4.z = 40;
            p4.Show();
            p3.Show();
        }
    }

    struct Punkt2D
    {
        public Punkt2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float x;
        public float y;

        public void Show()
        {
            Console.WriteLine($"x = {x}, y = {y}");
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

        public void Show()
        {
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
        }
    }
}
