using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class LottoGame
    {
        public static int numberOne, numberTwo, numberThree, numberFour, numberFive, numberSix;
        static void Main(string[] args)
        {
            int iloscKuponow;
            int dzien = 0;
            int start = 40;
            int kumulacja;
            int iloscPieniedzy = start;

            Random price = new Random();
            kumulacja = price.Next(1, 40);

            Console.WriteLine($"Twój początkowy stan portfela wynosi: {start}");
            Console.WriteLine("Stawka za kupon to 3 zł");
            Console.WriteLine("\nPodaj ile kuponów chcesz postawić. Maksymalnie możesz postawić 5 kuponów.");
            iloscKuponow = int.Parse(Console.ReadLine());
            iloscPieniedzy = iloscPieniedzy - (iloscKuponow * 3);
            Console.WriteLine($"Twój stan konta po postawieniu kuponów wynosi: {iloscPieniedzy}zł");
            Console.WriteLine($"Ilość kuponów w grze to: {iloscKuponow}");
            Console.WriteLine("\nPodaj 6 wytypowanych liczb z zakresu 1-50 - Duży Lotek");

            int[] kupon = new int[6];
            kupon[0] = int.Parse(Console.ReadLine());
            kupon[1] = int.Parse(Console.ReadLine());
            kupon[2] = int.Parse(Console.ReadLine());
            kupon[3] = int.Parse(Console.ReadLine());
            kupon[4] = int.Parse(Console.ReadLine());
            kupon[5] = int.Parse(Console.ReadLine());

            Console.WriteLine("Następuje zwolnienie blokady i zaczynamy losowanie 6 liczb");
            Random rnd = new Random();
            numberOne = rnd.Next(1, 51);
            numberTwo = rnd.Next(1, 51);
            numberThree = rnd.Next(1, 51);
            numberFour = rnd.Next(1, 51);
            numberFive = rnd.Next(1, 51);
            numberSix = rnd.Next(1, 51);

            Console.WriteLine($"Liczby wylosowane przez komputer to: {numberOne},{numberTwo},{numberThree},{numberFour},{numberFive},{numberSix}");

            foreach (var item in kupon)
            {
                Console.Write(item + ",");
            }

            while (dzien < 30 || iloscPieniedzy <= 3)
            {
                dzien++;
                Console.WriteLine($"To Twój {dzien} dzień gry");
                Console.WriteLine($"Twój stan konta wynosi: {iloscPieniedzy}zł");
                Console.WriteLine($"Dzisiejsza kumulacja wynosi:{kumulacja} mln");
                Console.ReadKey();
            }
        }
    }
}