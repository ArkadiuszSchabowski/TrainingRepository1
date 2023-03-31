using System;

namespace Lekcja43
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.name = "Adrian";
            p1.age = 20;

            Person p2 = new Person();
            p2.name = "Ania";
            p2.age = 24;
            p2.Hello();
            p1.Hello();
        }
    }
}
