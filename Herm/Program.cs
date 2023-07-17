using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Dominika";
            person.Name = "-";
            Console.WriteLine(person.Name);

            person.Age = 21;
            person.Age = -5;
            person.Age = 205;
            Console.WriteLine(person.Age);
            Console.ReadLine();
        }
    }
    public class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return "Imie uzytkownika to " + name;
            }
            set
            {
                if (value.Length > 2)
                    name = value;
            }
        }

        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 200)
                age = value;
            }
        }

    }
}
