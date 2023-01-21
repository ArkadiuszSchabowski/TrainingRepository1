using System;

namespace SwinskiTest
{
    class Program
    {
        static void Main(string[] args)
        {

            string operation1, operation2;

            Console.WriteLine("Test o świnkach morskich");
            Console.WriteLine(" ");
            Console.WriteLine("Pytanie 1. Na czym najbardziej zetrze zęby świnka morska?");
            Console.WriteLine(" ");
            Console.WriteLine("A - jedząc ogórek");
            Console.WriteLine("B - delektując się sianem");
            Console.WriteLine("C - pijąc z poidełka");
            Console.WriteLine("D - jedząc trawę");
            Console.WriteLine(" ");

            operation1 = Console.ReadLine();

            if (operation1 == "B")
            {
                Console.WriteLine("Gratulacje. Dobra odpowiedź.");
                Console.WriteLine(" ");
                Console.WriteLine("Pytanie 2. Jak Inaczej kiedyś nazywano świnkę morską?");
                Console.WriteLine("A - świnką miniaturową");
                Console.WriteLine("B - powiększonym chomikiem");
                Console.WriteLine("C - uszatniczką");
                Console.WriteLine("D - świnką nadmorską");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Niestety poległeś na pierwszym pytaniu");
            }

            operation2 = Console.ReadLine();



            if (operation2 == "D")


            {
                Console.WriteLine("Gratulacje. Dobra odpowiedź.Jesteś znawcą świnek!");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Niestety poległeś na drugim pytaniu");
            }

        }

    }
}