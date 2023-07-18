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

            MainClass.Test();
        }
    }
    //Hermetyzacja
    internal class MainClass
    {
        public static void Test()
        {


            //Hermetyzacja

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



    //Hermetyzacja
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
