using System;

namespace Lekcja51
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Milka", 10, "biały");
            cat.Show();
        }
    }

    class Animal
    {
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name;
        public int age;

        public void Show()
        {
            Console.Write($"Imie: {name}, wiek: {age}");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age, string color) : base(name, age)
        {
            this.color = color;
        }

        public string color;

        public void Show()
        {
            base.Show();
            Console.WriteLine($", kolor: {color}");
        }
    }
}
