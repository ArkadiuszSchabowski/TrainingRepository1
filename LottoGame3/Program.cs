using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    internal class Program
    {
        //Gracz skreśla 5 liczb z zakresu od 1-50.
        //Otrzymuje określoną wygraną za ilości trafień.
        static void Main(string[] args)
        {
            int kumulacja;
            int pieniadze;
            int start = 30;
            int dzien = 0;
            Random rnd = new Random();
            //Głowna pętla - cała rozgrywka
            do
            {
                pieniadze = start;
                dzien = 0;
                ConsoleKey wybor;
                //jedna kumulacja - kolejny dzień
                do
                {
                    kumulacja = rnd.Next(2, 37) * 1000000;
                    dzien++;
                    int losow = 0;
                    List<int[]> kupon = new List<int[]>();
                    //Kolejny wybór w danym dniu
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Dzień {0}", dzien);
                        Console.WriteLine("Witaj w grze Lotto dziś do wygrania aż {0}zł!", kumulacja);
                        Console.WriteLine("Stan konta {0}zł", pieniadze);
                        WyswietlKupon();
                        //Menu
                        if (pieniadze >= 3 && losow <= 8)
                        {
                            Console.WriteLine("1 - Postaw los - 3zł [0/8]", losow + 1);
                            Console.WriteLine("2 - Sprawdz kupon - losowanie");
                            Console.WriteLine("3 - Zakończ grę");
                        }
                        // Menu
                        wybor = Console.ReadKey().Key;
                        if (wybor == ConsoleKey.D1 && pieniadze >= 3 && losow < 8)
                        {
                            kupon.Add(PostawLos());
                            pieniadze -= 3;
                            losow++;
                        }
                        else if (wybor == ConsoleKey.D2)
                        {
                            SprawdzKupon();
                        }
                        else if (wybor == ConsoleKey.D3 || wybor == ConsoleKey.Escape)
                        {

                        }
                    } while (wybor == ConsoleKey.D1);
                    Console.Clear();
                    if (kupon.Count > 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Nie miałeś losów w tym losowaniu!");
                    }
                    Console.WriteLine("Enter - kontynuuj");
                    Console.ReadKey();
                } while (pieniadze >= 3 && wybor != ConsoleKey.D3);
                Console.Clear();
                Console.WriteLine("Zakończyłeś swoją grę w {0}, Twój wynik to {1}.", dzien, pieniadze - start);
                Console.WriteLine("Enter - graj od nowa.");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        private static void SprawdzKupon()
        {
            throw new NotImplementedException();
        }

        private static int[] PostawLos()
        {
            throw new NotImplementedException();
        }

        private static void WyswietlKupon()
        {
            throw new NotImplementedException();
        }
    }
}
