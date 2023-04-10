using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace Milionerzy
{
    public class Program
    {
        static void Menu()
        {
            string path = @"..\..\..\wygrana.txt";

            int number;
            bool check;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Wybierz operację:\n");

                Console.WriteLine("1. Nowa gra");
                Console.WriteLine("2. Lista wyników");
                Console.WriteLine("3. Usuń wynik");
                Console.WriteLine("4. Zakończ program");

                check = int.TryParse(Console.ReadLine(), out number);

                if (check && number > 0 && number < 4)
                {
                    if (number ==1)
                    {
                        NowaGra();
                    }
                    if (number == 2)
                    {
                        Console.Clear();
                        string[] lines = File.ReadAllLines(path);
                        Console.WriteLine("Oto lista ostatnich wyników:\n");
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować");
                        Console.ReadKey();
                    }
                    else if (number == 3)
                    {
                        Console.WriteLine("Wybierz wynik do usunięcia\n");
                        string[] lines = File.ReadAllLines(path);
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować");

                        List<string> lista = new List<string>();

                        for (int i = 0; i < lines.Length; i++)
                        {
                            lista.Add(lines[i]);
                        }

                        int deleteNumber;
                        bool deleteLine = int.TryParse(Console.ReadLine(), out deleteNumber);

                        if (deleteLine && deleteNumber < lista.Count)
                        {
                            lista.RemoveAt(deleteNumber - 1);
                        }
                        foreach (var item in lista)
                        {
                            Console.WriteLine(item);
                        }

                        Console.ReadKey();
                    }
                    else if (number == 4)
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Niewłaściwy wybór");
                }
            }

        }
        static void Main(string[] args)
        {
            Menu();
        }
        static void NowaGra()

        {
            try
            {
                string wygrana = "0";
                string path = @"..\..\..\wygrana.txt";
                StreamWriter sw = new StreamWriter(path, true);
                string name;
                bool mainGame = true;

                List<string> listaNagrod = new List<string>()
            {
            "Świński Kubek (nagroda pocieszenia)",
            "Zapas siana na miesiąc (nagroda gwarantowana)",
            "Miesięczny zapas karmy Versele Laga",
            "Miesięczny warzywny catering dietetyczny",
            "Świński Hamak (nagroda gwarantowana)",
            "Klatka dla 3 świnek o wymiarach 120cmx60cm",
            "Zestaw świnkowych domków",
            "Zestaw 10 zabiegów SPA oraz kąpieli błotnych",
            "2-tygodniowe wakacje all-inclusive na rajską wyspę Pig Beach na Bahamach z osobą towarzyszącą",
            "Ogromny zagrodzony świński wybieg dla całego stada zakryty antydrapieżną siatką",
        };

                Console.WriteLine("Witaj w świnskich milionerach\n");
                Console.WriteLine("Podaj swoje imię");
                name = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"Witaj w milionerach {name}.");

                while (mainGame)
                {
                    bool firstQuestion = Pytanie1.PytaniePierwsze();

                    if (firstQuestion == true)
                    {
                        wygrana = listaNagrod[1];
                        bool secondQuestion = Pytanie2.PytanieDrugie();

                        if (secondQuestion == true)
                        {
                            wygrana = listaNagrod[2];
                            bool thirdQuestion = Pytanie3.PytanieTrzecie();

                            if (thirdQuestion == true)
                            {
                                wygrana = listaNagrod[3];
                                mainGame = false;
                                break;
                            }
                            else
                            {
                                wygrana = listaNagrod[1];
                                mainGame = false;
                                break;
                            }
                        }
                        else
                        {
                            //Próg gwarantowany
                            wygrana = listaNagrod[1];
                            mainGame = false;
                            break;
                        }
                    }
                    else
                    {
                        wygrana = listaNagrod[0];
                        mainGame = false;
                        break;
                    }

                }

                Console.WriteLine($"Dziękujemy za grę, wygrywasz {wygrana}");
                Console.ReadKey();
                sw.WriteLine($"{DateTime.Now}  gracz: {name} zdobył: {wygrana}");
                sw.Close();
                Koniec();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        private static void Koniec()
        {
            Environment.Exit(0);
        }
    }
}

