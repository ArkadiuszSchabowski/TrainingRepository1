using System;

namespace Lekcja58
{
    public enum Color
    {
        Black = 3, White, Brown
    }

    class Program
    {

        static void Main(string[] args)
        {
            Dog reks = new Dog("Reks", 10, Color.Black);
            Dog azor = new Dog("Azor", 5, Color.Black);
            Console.WriteLine(reks.color.Equals(azor.color));

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Color.Black + " - " + (int)Color.Black);
            Console.WriteLine(Color.White + " - " + (int)Color.White);
            Console.WriteLine(Color.Brown + " - " + (int)Color.Brown);
        }
    }

    class Dog
    {
        public Dog(string name, int age, Color color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }

        public string name;
        public int age;
        public Color color;
    }
}
