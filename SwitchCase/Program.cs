using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typOdziezy, rodzajObuwia, kolorObuwia, rodzajBielizny, krojBielizny;

            Console.WriteLine("Witamy w aplikacji dla Kobiet: Nasze Szczęście");

            while (true)
            {


                Console.WriteLine("\nPodaj typ odzieży: buty, bielizna");
                typOdziezy = Console.ReadLine();

                switch (typOdziezy)
                {
                    case "buty":
                        {
                            Console.WriteLine("Wybrałeś buty");
                            Console.WriteLine("Wybierz typ butów: koturny, szpilki, kozaki");
                            rodzajObuwia = Console.ReadLine();

                            switch (rodzajObuwia)
                            {
                                case "koturny":
                                    {
                                        Console.WriteLine("Wybrałaś koturny");
                                        Console.WriteLine("Wybierz kolor: beżowe, białe, czarne");
                                        kolorObuwia = Console.ReadLine();
                                        switch (kolorObuwia)
                                        {
                                            case "beżowe":

                                                {
                                                    Console.WriteLine($"Wybrałaś beżowe {rodzajObuwia}.");
                                                    Console.ReadKey();

                                                }
                                                break;
                                            case "białe":

                                                {
                                                    Console.WriteLine($"Wybrałaś białe {rodzajObuwia}.");
                                                    Console.ReadKey();

                                                }
                                                break;
                                            case "czarne":

                                                {
                                                    Console.WriteLine($"Wybrałaś czarne {rodzajObuwia}.");
                                                    Console.ReadKey();

                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case "szpilki":
                                    {
                                        Console.WriteLine("Wybrałeś szpilki");
                                        Console.WriteLine("Wybierz kolor: beżowe, białe, czarne");
                                        kolorObuwia = Console.ReadLine();
                                        switch (kolorObuwia)
                                        {
                                            case "beżowe":

                                                {
                                                    Console.WriteLine($"Wybrałaś beżowe {rodzajObuwia}.");
                                                    Console.ReadKey();

                                                }
                                                break;
                                            case "białe":

                                                {
                                                    Console.WriteLine($"Wybrałaś białe {rodzajObuwia}.");
                                                    Console.ReadKey();

                                                }
                                                break;
                                            case "czarne":

                                                {
                                                    Console.WriteLine($"Wybrałaś czarne {rodzajObuwia}.");
                                                    Console.ReadKey();

                                                }
                                                break;
                                        }
                                    }
                                    break;

                                case "kozaki":
                                    {
                                        Console.WriteLine("Wybrałeś kozaki");
                                        Console.WriteLine("Wybierz kolor: beżowe, białe, czarne");
                                        kolorObuwia = Console.ReadLine();

                                        switch (kolorObuwia)
                                        {
                                            case "beżowe":

                                                {
                                                    Console.WriteLine($"Wybrałaś beżowe {rodzajObuwia}.");
                                                    Console.ReadKey();

                                                }
                                                break;
                                            case "białe":

                                                {
                                                    Console.WriteLine($"Wybrałaś białe {rodzajObuwia}.");
                                                    Console.ReadKey();

                                                }
                                                break;
                                            case "czarne":

                                                {
                                                    Console.WriteLine($"Wybrałaś czarne {rodzajObuwia}.");
                                                    Console.ReadKey();

                                                }
                                                break;
                                        }
                                    }
                                    break;
                            }
                            break;

                        }
                    case "bielizna":
                        {
                            Console.WriteLine("Wybrałaś bieliznę");
                            Console.WriteLine("Wybierz typ bielizny: stringi, figi");
                            rodzajBielizny = Console.ReadLine();

                            switch (rodzajBielizny)
                            {
                                case "stringi":
                                    {
                                        Console.WriteLine("Wybrałaś stringi");
                                        Console.WriteLine("Wybierz krój: (T),(G)");
                                        krojBielizny = Console.ReadLine();

                                        switch (krojBielizny)
                                        {
                                            case "T":
                                                {
                                                    Console.WriteLine($"Wybrałaś {rodzajBielizny} typu T.");
                                                }
                                                break;
                                            case "G":
                                                {
                                                    Console.WriteLine($"Wybrałaś {rodzajBielizny} typu G.");
                                                }
                                                break;
                                        }
                                        break;
                                    }

                                case "figi":
                                    {
                                        Console.WriteLine("Wybrałaś figi");
                                        Console.WriteLine("Wybierz rodzaj figów: gładkie, koronkowe");
                                        krojBielizny = Console.ReadLine();

                                        switch (krojBielizny)
                                        {
                                            case "gładkie":
                                                {
                                                    Console.WriteLine($"Wybrałaś {krojBielizny} figi.");
                                                }
                                                break;
                                            case "koronkowe":
                                                {
                                                    Console.WriteLine($"Wybrałaś {krojBielizny} figi.");
                                                }
                                                break;

                                        }
                                    }
                                    break;
                            }
                        }break;
                }
            }
        }
    }
}