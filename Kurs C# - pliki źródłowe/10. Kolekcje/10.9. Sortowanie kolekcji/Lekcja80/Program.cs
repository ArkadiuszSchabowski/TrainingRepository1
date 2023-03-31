using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Lekcja80
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Maciej", 19);
            Person p2 = new Person("Ola", 18);
            Person p3 = new Person("Sebastian", 26);
            Person p4 = new Person("Asia", 19);
            Person p5 = new Person("Marcin", 22);
            Person p6 = new Person("Ania", 18);
            Person p7 = new Person("Łukasz", 24);
            Person p8 = new Person("Bartek", 18);

            List<Person> list = new List<Person>();

            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(p5);
            list.Add(p6);
            list.Add(p7);
            list.Add(p8); 

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

            //Console.WriteLine(6.CompareTo(6));
            //Console.WriteLine("Ula".CompareTo("Ala"));
        }
    }

    class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name;
        public int age;

        public override string ToString()
        {
            return $"{age} - {name}";
        }

        public int CompareTo([AllowNull] Person other)
        {
            return (this.age.CompareTo(other.age) * 10) + this.name.CompareTo(other.name);
        }
    }
}
