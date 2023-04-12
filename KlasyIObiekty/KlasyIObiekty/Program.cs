using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KlasyIObiekty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetName("Dominika");
            person.SetName("-");
            Console.WriteLine(person.GetName());
            person.setWiek(19);
            person.setWiek(101);
            Console.WriteLine(person.getWiek());
            Console.ReadKey();
        }
    }
    public class Person
    {

        //public Person(string name, int age)
        //{
        //    //_name = name;
        //    //_age = age;
        //}

        private string _name;
        private int _age;


        public string GetName()
        {
            return _name;
        }
        public void SetName(string value)
        {
            if (value.Length > 3)
            {
                _name = value;
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"I'm {_name} and I am {_age} years old.");
        }
        public int getWiek()
        {
            return _age;
        }
        public void setWiek(int value)
        {
            if (value > 0 && value < 100)
            {
                _age = value;
            }

        }
    }
}
