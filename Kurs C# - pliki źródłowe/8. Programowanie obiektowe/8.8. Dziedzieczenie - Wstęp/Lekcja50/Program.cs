using System;

namespace Lekcja50
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.age = 10;
            cat.name = "Milka";
            cat.Show();
            cat.GetVoice();

            Animal animal = new Animal();

            Dog dog = new Dog();
            dog.Voice();

            Tiger tiger = new Tiger();
            tiger.Show();
            tiger.GetVoice();
        }
    }

    class Animal
    {
        public string name;
        public int age;

        public void Show()
        {
            Console.WriteLine("I'm Animal");
        }
    }

    class Cat : Animal
    {
        public void GetVoice()
        {
            Console.WriteLine("Meow meow!");
        }
    }

    class Tiger : Cat
    {

    }

    class Dog : Animal
    {
        public void Voice()
        {
            Console.WriteLine("How how!");
        }
    }
}
