using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class LottoGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość pieniędzy jaką chcesz wpłacić. Minimum 3zł(stawka jednego losu), Max10000zł.");
            int iloscPieniedzy = int.Parse(Console.ReadLine());
            if (iloscPieniedzy < 3)
            {
                Console.WriteLine("Wpłaciłeś za mało pieniędzy, by kupić los!");
                Console.ReadKey();
            }
            else if (iloscPieniedzy > 10000)
            {
                Console.WriteLine("Nie możesz jednorazowo wpłacić tak dużej kwoty!");
                Console.ReadKey();
            }
            else
            {
                while (iloscPieniedzy >= 0)
                {
                    Console.ResetColor();
                    Console.Clear();
                    Random price = new Random();
                    Random rnd = new Random();

                    int kumulacja;
                    int iloscKuponow = 0;
                    int dzien = 0;
                    int trafiony = 0;
                    int trafiony2 = 0;

                    int numberOne, numberTwo, numberThree, numberFour, numberFive, numberSix;
                    Console.ResetColor();

                    Console.WriteLine($"Twój stan konta wynosi: {iloscPieniedzy}zł");
                    dzien++;
                    Console.WriteLine($"\nTo Twój {dzien} dzień gry");

                    kumulacja = price.Next(1, 40);
                    Console.WriteLine($"Dzisiejsza kumulacja wynosi: {kumulacja} mln");

                    Console.WriteLine("\nPodaj ile kuponów chcesz postawić. Maksymalnie możesz postawić 2 kupony.");
                    Console.WriteLine("Stawka za kupon to 3 zł\n");
                    iloscKuponow = int.Parse(Console.ReadLine());
                    iloscPieniedzy = iloscPieniedzy - (iloscKuponow * 3);
                    Console.WriteLine($"Twój stan konta po postawieniu kuponów wynosi: {iloscPieniedzy}zł");
                    Console.WriteLine($"Ilość kuponów w grze to: {iloscKuponow}");

                    int[] kupon = new int[6];
                    int[] kupon2 = new int[6];

                    if (iloscKuponow == 1)
                    {
                        Console.WriteLine("\nPodaj wytypowane liczby dla kuponu pierwszego:");
                        kupon[0] = int.Parse(Console.ReadLine());
                        kupon[1] = int.Parse(Console.ReadLine());
                        kupon[2] = int.Parse(Console.ReadLine());
                        kupon[3] = int.Parse(Console.ReadLine());
                        kupon[4] = int.Parse(Console.ReadLine());
                        kupon[5] = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }
                    else if (iloscKuponow == 2)
                    {
                        Console.WriteLine("\nPodaj wytypowane liczby dla kuponu pierwszego:");
                        kupon[0] = int.Parse(Console.ReadLine());
                        kupon[1] = int.Parse(Console.ReadLine());
                        kupon[2] = int.Parse(Console.ReadLine());
                        kupon[3] = int.Parse(Console.ReadLine());
                        kupon[4] = int.Parse(Console.ReadLine());
                        kupon[5] = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nPodaj wytypowane liczby dla kuponu drugiego:");
                        kupon2[0] = int.Parse(Console.ReadLine());
                        kupon2[1] = int.Parse(Console.ReadLine());
                        kupon2[2] = int.Parse(Console.ReadLine());
                        kupon2[3] = int.Parse(Console.ReadLine());
                        kupon2[4] = int.Parse(Console.ReadLine());
                        kupon2[5] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Następuje zwolnienie blokady i zaczynamy losowanie 6 liczb");

                    numberOne = rnd.Next(1, 11);
                    numberTwo = rnd.Next(1, 11);
                    numberThree = rnd.Next(1, 11);
                    numberFour = rnd.Next(1, 11);
                    numberFive = rnd.Next(1, 11);
                    numberSix = rnd.Next(1, 11);

                    int trzyTrafienia = 24;
                    int czteryTrafienia = 205;
                    int piecTrafien = 5997;
                    int szczescTrafien = kumulacja * 1000000;

                    Console.WriteLine($"Liczby wylosowane przez komputer to: {numberOne},{numberTwo},{numberThree},{numberFour},{numberFive},{numberSix}");
                    if (iloscKuponow == 1)
                    {
                        if (kupon[0] == numberOne || kupon[0] == numberTwo || kupon[0] == numberThree || kupon[0] == numberFour || kupon[0] == numberFive || kupon[0] == numberSix)
                        {
                            trafiony++;
                        }
                        if (kupon[1] == numberOne || kupon[1] == numberTwo || kupon[1] == numberThree || kupon[1] == numberFour || kupon[1] == numberFive || kupon[1] == numberSix)
                        {
                            trafiony++;
                        }
                        if (kupon[2] == numberOne || kupon[2] == numberTwo || kupon[2] == numberThree || kupon[2] == numberFour || kupon[2] == numberFive || kupon[2] == numberSix)
                        {
                            trafiony++;
                        }
                        if (kupon[3] == numberOne || kupon[3] == numberTwo || kupon[3] == numberThree || kupon[3] == numberFour || kupon[3] == numberFive || kupon[3] == numberSix)
                        {
                            trafiony++;
                        }
                        if (kupon[4] == numberOne || kupon[4] == numberTwo || kupon[4] == numberThree || kupon[4] == numberFour || kupon[4] == numberFive || kupon[4] == numberSix)
                        {
                            trafiony++;
                        }
                        if (kupon[5] == numberOne || kupon[5] == numberTwo || kupon[5] == numberThree || kupon[5] == numberFour || kupon[5] == numberFive || kupon[5] == numberSix)
                        {
                            trafiony++;
                        }
                        if (trafiony == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nUdało Ci się trafić 6 liczb z kuponu pierwszego! Twoja wygrana to {szczescTrafien}");
                            Console.ResetColor();
                            iloscPieniedzy += szczescTrafien;
                        }
                        else if (trafiony == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nUdało Ci się trafić 5 liczb z z kuponu pierwszego! Twoja wygrana to {piecTrafien}");
                            Console.ResetColor();
                            iloscPieniedzy += piecTrafien;
                        }
                        else if (trafiony == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nUdało Ci się trafić 4 liczby z z kuponu pierwszego! Twoja wygrana to {czteryTrafienia}");
                            Console.ResetColor();
                            iloscPieniedzy += czteryTrafienia;
                        }
                        else if (trafiony == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nUdało Ci się trafić 3 liczb z z kuponu pierwszego! Twoja wygrana to {trzyTrafienia}");
                            Console.ResetColor();
                            iloscPieniedzy += trzyTrafienia;
                        }
                        else if (trafiony == 2)
                        {
                            Console.WriteLine($"\nTrafiłeś tylko dwie liczby z z kuponu pierwszego!, niestety nie przewidujemy za to wygranej");
                        }
                        else if (trafiony == 1)
                        {
                            Console.WriteLine($"\nTrafiłeś jedną liczbę z z kuponu pierwszego!, niestety nie przewidujemy za to wygranej");
                        }
                        else
                        {
                            Console.WriteLine("\nTym razem nie wygrałeś nic, spróbuj jeszcze raz");
                        }

                    }
                    else if (iloscKuponow == 2)
                    {
                        if (kupon[0] == numberOne || kupon[0] == numberTwo || kupon[0] == numberThree || kupon[0] == numberFour || kupon[0] == numberFive || kupon[0] == numberSix)
                        {
                            trafiony++;
                        }
                        if (kupon[1] == numberOne || kupon[1] == numberTwo || kupon[1] == numberThree || kupon[1] == numberFour || kupon[1] == numberFive || kupon[1] == numberSix)
                        {
                            trafiony++;
                        }
                        if (kupon[2] == numberOne || kupon[2] == numberTwo || kupon[2] == numberThree || kupon[2] == numberFour || kupon[2] == numberFive || kupon[2] == numberSix)
                        {
                            trafiony++;
                        }
                        if (kupon[3] == numberOne || kupon[3] == numberTwo || kupon[3] == numberThree || kupon[3] == numberFour || kupon[3] == numberFive || kupon[3] == numberSix)
                        {
                            trafiony++;
                        }
                        if (kupon[4] == numberOne || kupon[4] == numberTwo || kupon[4] == numberThree || kupon[4] == numberFour || kupon[4] == numberFive || kupon[4] == numberSix)
                        {
                            trafiony++;
                        }
                        if (kupon[5] == numberOne || kupon[5] == numberTwo || kupon[5] == numberThree || kupon[5] == numberFour || kupon[5] == numberFive || kupon[5] == numberSix)
                        {
                            trafiony++;
                        }

                        if (kupon2[0] == numberOne || kupon2[0] == numberTwo || kupon2[0] == numberThree || kupon2[0] == numberFour || kupon2[0] == numberFive || kupon2[0] == numberSix)
                        {
                            trafiony2++;
                        }
                        if (kupon2[1] == numberOne || kupon2[1] == numberTwo || kupon2[1] == numberThree || kupon2[1] == numberFour || kupon2[1] == numberFive || kupon2[1] == numberSix)
                        {
                            trafiony2++;
                        }
                        if (kupon2[2] == numberOne || kupon2[2] == numberTwo || kupon2[2] == numberThree || kupon2[2] == numberFour || kupon2[2] == numberFive || kupon2[2] == numberSix)
                        {
                            trafiony2++;
                        }
                        if (kupon2[3] == numberOne || kupon2[3] == numberTwo || kupon2[3] == numberThree || kupon2[3] == numberFour || kupon2[3] == numberFive || kupon2[3] == numberSix)
                        {
                            trafiony2++;
                        }
                        if (kupon2[4] == numberOne || kupon2[4] == numberTwo || kupon2[4] == numberThree || kupon2[4] == numberFour || kupon2[4] == numberFive || kupon2[4] == numberSix)
                        {
                            trafiony2++;
                        }
                        if (kupon2[5] == numberOne || kupon2[5] == numberTwo || kupon2[5] == numberThree || kupon2[5] == numberFour || kupon2[5] == numberFive || kupon2[5] == numberSix)
                        {
                            trafiony2++;
                        }

                        if (trafiony == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nUdało Ci się trafić 6 liczb z kuponu pierwszego! Twoja wygrana to {szczescTrafien}");
                            Console.ResetColor();
                            iloscPieniedzy += szczescTrafien;
                        }
                        else if (trafiony == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nUdało Ci się trafić 5 liczb z kuponu pierwszego! Twoja wygrana to {piecTrafien}");
                            Console.ResetColor();
                            iloscPieniedzy += piecTrafien;
                        }
                        else if (trafiony == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nUdało Ci się trafić 4 liczby z kuponu pierwszego! Twoja wygrana to {czteryTrafienia}");
                            Console.ResetColor();
                            iloscPieniedzy += czteryTrafienia;
                        }
                        else if (trafiony == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nUdało Ci się trafić 3 liczb z kuponu pierwszego! Twoja wygrana to {trzyTrafienia}");
                            Console.ResetColor();
                            iloscPieniedzy += trzyTrafienia;
                        }
                        else if (trafiony == 2)
                        {
                            Console.WriteLine($"\nTrafiłeś tylko dwie liczby z kuponu pierwszego! Niestety nie przewidujemy za to wygranej");
                        }
                        else if (trafiony == 1)
                        {
                            Console.WriteLine($"\nTrafiłeś jedną liczbę z z kuponu pierwszego! Niestety nie przewidujemy za to wygranej");
                        }
                        else
                        {
                            Console.WriteLine("\nTym razem nie trafiłeś żadnej liczby z kuponu numer jeden.");
                        }

                        if (trafiony2 == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Udało Ci się trafić 6 liczb z kuponu drugiego! Twoja wygrana to {szczescTrafien}");
                            Console.ResetColor();
                            iloscPieniedzy += szczescTrafien;
                        }
                        else if (trafiony2 == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Udało Ci się trafić 5 liczb z kuponu drugiego! Twoja wygrana to {piecTrafien}");
                            Console.ResetColor();
                            iloscPieniedzy += piecTrafien;
                        }
                        else if (trafiony2 == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Udało Ci się trafić 4 liczby z kuponu drugiego! Twoja wygrana to {czteryTrafienia}");
                            Console.ResetColor();
                            iloscPieniedzy += czteryTrafienia;
                        }
                        else if (trafiony2 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Udało Ci się trafić 3 liczb z kuponu drugiego! Twoja wygrana to {trzyTrafienia}");
                            Console.ResetColor();
                            iloscPieniedzy += trzyTrafienia;
                        }
                        else if (trafiony2 == 2)
                        {
                            Console.WriteLine($"Trafiłeś tylko dwie liczby z kuponu drugiego! Niestety nie przewidujemy za to wygranej");
                        }
                        else if (trafiony2 == 1)
                        {
                            Console.WriteLine($"Trafiłeś jedną liczbę z kuponu drugiego! Niestety nie przewidujemy za to wygranej");
                        }
                        else
                        {
                            Console.WriteLine("Niestety nie trafiłeś żadnej liczby z kuponu numer 2.");
                        }
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}