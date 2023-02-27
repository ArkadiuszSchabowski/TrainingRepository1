using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisielec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gra w wisielca
            //Po otrzymaniu podpowiedzi użytkownik podaje słowo, jeśli nie potrafi odgadnać
            //użytkownik podaje litere, jeśli jej nie ma w słowie to rysuje się kreska na szubienicy.

            string answer = "Frost Dragon";
            answer = answer.ToLower();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GRA WISIELEC - kategoria Tibia - odgadnij hasło!");
            Console.WriteLine("Podpowiedź: Spotkasz go na wyspie okolnir!\n");

            Console.ForegroundColor = ConsoleColor.White;
            string firstTry = Console.ReadLine();
            firstTry = firstTry.ToLower();

            if (firstTry == answer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nBrawo udało Ci się zgadnąć za 1 razem!");
                goto koniec;

            }
            else if (firstTry != answer)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTwoja odpowiedź jest błędna");
            }
            Console.WriteLine("                                                   /|");

            Console.ForegroundColor = ConsoleColor.White;
            string secondTry = Console.ReadLine();

            if (secondTry == answer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nBrawo udało Ci się zgadnąć za 2 razem!");
                goto koniec;

            }
            else if (secondTry != answer)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTwoja odpowiedź jest błędna");
            }
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                   /|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            string thirdTry = Console.ReadLine();

            if (thirdTry == answer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nBrawo udało Ci się zgadnąć za 3 razem!");
                goto koniec;

            }
            else if (thirdTry != answer)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTwoja odpowiedź jest błędna");
            }
            Console.WriteLine("                                                     ________");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                   /|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            string fourthTry = Console.ReadLine();

            if (fourthTry == answer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nBrawo udało Ci się zgadnąć za 4 razem!");
                goto koniec;

            }
            else if (fourthTry != answer)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTwoja odpowiedź jest błędna");
            }
            Console.WriteLine("                                                     ________");
            Console.WriteLine("                                                    |        |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                    |");
            Console.WriteLine("                                                   /|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("OSTATNIA SZANSA!!!\n");

            Console.ForegroundColor = ConsoleColor.White;
            string fifthTry = Console.ReadLine();

            if (fifthTry == answer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nBrawo udało Ci się zgadnąć za 5 razem!");
                goto koniec;

            }
            else if (fifthTry != answer)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTwoja odpowiedź jest błędna");
            }
            Console.WriteLine("                                                     ________");
            Console.WriteLine("                                                    |        |");
            Console.WriteLine("                                                    |        O");
            Console.WriteLine("                                                    |      --|--");
            Console.WriteLine("                                                    |       /|");
            Console.WriteLine("                                                    |      / |");
            Console.WriteLine("                                                   /|");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tym razem przegrałeś - spróbuj jeszcze raz!");
            Console.ReadKey();

        koniec:
            Console.ReadKey();
        }
    }
}
