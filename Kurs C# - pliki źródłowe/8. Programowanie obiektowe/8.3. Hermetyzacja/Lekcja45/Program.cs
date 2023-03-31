using System;

namespace Lekcja45
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Adrian", 20);
            p1.Name = "Adam";
            p1.Name = "-";
            Console.WriteLine(p1.Name);
            
            p1.Age = 21;
            p1.Age = -5;
            Console.WriteLine(p1.Age);

            //p1.Country = "Polska";
            Console.WriteLine(p1.Country);

            p1.Hello();
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Country = "Polska";
        }

        private string name;

        public string Name
        {
            get 
            { 
                return "Imie: " + name; 
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
                if (value >= 0 && value <= 200)
                    age = value;
            }
        }

        public string Country { get; private set; }


        public void Hello()
        {
            Console.WriteLine($"Cześć, jestem {name} i mam {age} lat.");
        }
    }
}
