using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingParadigms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hermetyzacja - Ukrywanie pól publicznych, tak aby były dostępne tylko wewnątrz danej klasy, a wystawianie ich poza klasę metodami lub właściwościami. Jest stosowana po to, aby można w metodach lub właściwościach nadać logikę biznesową i ograniczyć możliwość wpisania niepoprawnych danych.
             * */

            //Hermetyzacja
            Shape.Test();

            //Abstrakcja - Jeśli klasa jest oznaczona słówkiem kluczowym abstract to na bazie takiej klasy nie możemy stworzyć obiektu. Jednak możemy zrobić to w klasie pochodnej, która nie jest już abstrakcyjna. Nie możemy zwizualizować jak będzie wyglądał, np. samochód, osoba czy kształt. To stwierdzenie ogólnie. Jednak na bazie takiej klasy możemy stworzyć klasę pochodną, która już nie będzie abstrakcyjna. Następnie utworzyć w niej obiekt, np. Arek, Mazda, Kwadrat.

            //Abstrakcja
            Arek.IntroduceYourself();

            //Dziedziczenie - W języku C# zawsze powinniśmy przesztrzegać zasady DRY - Don't repeat yourself. W hierarchii dziedziczenia w klasie bazowej możemy stworzyć pewne metody, właściwośći czy pola, które będziemy wykorzystywać w klasie pochodnej.

            //Dziedziczenie
            Mazda.ShowThisMazda();
        }
    }
    //Dziedziczenie
    public abstract class Car
    {
        public string name;
        public int countDoors;
        public int maxSpeed;
    }
    public class Mazda : Car
    {
        public Mazda()
        {
            name = "Mazda 6";
            countDoors = 5;
            maxSpeed = 240;
        }
        public static void ShowThisMazda()
        {
            Mazda mazda = new Mazda();

            Console.WriteLine($"Paramters: {mazda.name + mazda.countDoors + mazda.maxSpeed}");
            Console.ReadLine();
        }
    }

    //Abstrakcja
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }

    public class Arek : Person
    {
        public Arek()
        {
            Name = "Arek";
            Age = 32;
            Sex = "Male";
        }
        public static void IntroduceYourself()
        {
            Arek arek = new Arek();
            Console.WriteLine($"I'm {arek.Name}, I'm {arek.Age}. My sex is a {arek.Sex}");
        }
    }

    //Hermetyzacja
    internal class Shape
    {
        public static void Test()
        {
            Triangle triangle = new Triangle();
            triangle.SideLenght = 100;
            triangle.SideLenght = -1;
            Console.WriteLine(triangle.SideLenght);

            triangle.Color = "Red";
            triangle.Color = "A";
            Console.WriteLine(triangle.Color);
            Console.ReadKey();
        }
    }

    internal class Triangle
    {
        private int sideLenght;
        private string color;

        public int SideLenght
        {
            get
            {
                return sideLenght;
            }

            set
            {
                if (value > 0)
                {
                    sideLenght = value;
                }
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value.Length > 2)
                    color = value;
            }
        }
    }
}
