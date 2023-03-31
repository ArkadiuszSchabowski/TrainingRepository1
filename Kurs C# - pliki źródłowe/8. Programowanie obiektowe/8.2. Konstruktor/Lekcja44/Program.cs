using System;

namespace Lekcja44
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Adrian", 20);
            p1.Hello();

            Person p2 = new Person("Ania");
            p2.Hello();
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name)
        {
            this.name = name;
            age = 1;
        }

        public string name;
        public int age;

        public void Hello()
        {
            Console.WriteLine($"Cześć, jestem {name} i mam {age} lat.");
        }
    }
}
