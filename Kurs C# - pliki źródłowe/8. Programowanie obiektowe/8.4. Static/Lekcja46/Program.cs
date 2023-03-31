using System;

namespace Lekcja46
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.Count();

            Person p1 = new Person("Adrian", 20);
            p1.Hello();
            Person.Count();

            Person p2 = new Person("Ania", 24);
            p2.Hello();
            Person.Count();
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            count++;
        }

        public string name;
        public int age;
        public static int count = 0;

        public void Hello()
        {
            Console.WriteLine($"Cześć, jestem {name} i mam {age} lat. Jest nas: {count}");
            Count();
        }

        public static void Count()
        {
            Console.WriteLine($"Jest nas: {count}");
            // Hello(); - BŁĄD
        }
    }
}
