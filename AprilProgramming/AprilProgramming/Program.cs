using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Dominika", 20);
            person.IntroduceYourself();

            Person person2 = new Person("Arek", 31);
            person2.IntroduceYourself();

            FirstPerson.SayHello();

            Console.ReadKey();
        }
    }
    class FirstPerson
    {
        static string name = "Paulina";
        static int age = 22;

        public static void SayHello()
        {
            Console.WriteLine($"I am {name} and I am {age} years old.");
        }
    }
    class Person
    {
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
            _count++;
        }
        int _age = 20;
        string _name = "Dominika";
        static int _count;

        public void IntroduceYourself()
        {
            Console.WriteLine($"I am {_name} and I am {_age} years old.");
            Console.WriteLine($"There are {_count} person.");
        }
    }
}
