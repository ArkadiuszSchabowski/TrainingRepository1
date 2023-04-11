using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyIObiekty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Arek", 31);
            person.IntroduceYourself();
            Person person2 = new Person("Ania", 24);
            person2.IntroduceYourself();
            Console.ReadKey();
        }
    }
    public class Person
    {
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public string _name;
        public int _age;
        public void IntroduceYourself()
        {
            Console.WriteLine($"I'm {_name} and I am {_age} years old");
        }
    }
}
