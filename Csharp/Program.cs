using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinskiTest
{
    class Program
    {
        static void Main(string[] args)
        {

            string answerOne, answerTwo;

            Console.WriteLine("Test o świnkach morskich");
            Console.WriteLine(" ");
            Console.WriteLine("Pytanie 1. Na czym najbardziej zetrze zęby świnka morska?");
            Console.WriteLine(" ");
            Console.WriteLine("A - jedząc ogórek");
            Console.WriteLine("B - delektując się sianem");
            Console.WriteLine("C - pijąc z poidełka");
            Console.WriteLine("D - jedząc trawę");
            Console.WriteLine(" ");

            answerOne = Console.ReadLine();

            if (answerOne == "B")
            {
                Console.WriteLine("Gratulacje. Dobra odpowiedź.");
                Console.WriteLine(" ");

                Console.WriteLine("Pytanie 2. Jak Inaczej kiedyś nazywano świnkę morską?");

                Console.WriteLine("A - świnką miniaturową");
                Console.WriteLine("B - powiększonym chomikiem");
                Console.WriteLine("C - uszatniczką");
                Console.WriteLine("D - świnką nadmorską");
                Console.WriteLine(" ");

                answerTwo = Console.ReadLine();

                if (answerTwo == "D")

                {
                    Console.WriteLine("Gratulacje. Dobra odpowiedź.Jesteś znawcą świnek!");
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Console.WriteLine("Niestety to zła odpowiedź");
            }
            Console.ReadKey();
        }
    }
}