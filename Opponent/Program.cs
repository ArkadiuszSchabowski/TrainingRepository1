using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opponent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                bool con1, con2;
                double x1, x2;
                string operation1;

                Console.WriteLine("Podaj pierwszą cyfrę");
                con1 = double.TryParse(Console.ReadLine(), out x1);
                Console.WriteLine("Podaj drugą cyfrę");
                con2 = double.TryParse(Console.ReadLine(), out x2);
                Console.WriteLine("Podaj operację, którą chcesz wykonać.");
                Console.WriteLine("Dostępne opcje: dodaj, odejmij, pomnóż, podziel");
                operation1 = Console.ReadLine();

                if (con1 || con2)
                    switch (operation1)
                    {
                        case "dodaj":
                            Console.WriteLine(x1 + x2);
                            Console.ReadLine();
                            {
                                break;
                            }
                        case "odejmij":
                            Console.WriteLine(x1 - x2);
                            Console.ReadLine();
                            {
                                break;
                            }
                        case "pomnóż":
                            Console.WriteLine(x1 * x2);
                            Console.ReadLine();
                            {
                                break;
                            }
                        case "podziel":
                            Console.WriteLine(x1 / x2);
                            Console.ReadLine();
                            {
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }

                }
            }
        }
    }


            
            
            
            
            
            
            /*Program Numer 3
        {
            double x1, x2;
            string operation1;

            Console.WriteLine("Podaj pierwszą cyfrę");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą cyfrę");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj operację, którą chcesz wykonać.");
            Console.WriteLine("Dostępne opcje: dodaj, odejmij, pomnóż, podziel");
            operation1 = Console.ReadLine();

            if (operation1 == "dodaj")
            {
                Console.WriteLine(x1 + x2);
                Console.ReadLine();
            }
            else
            if (operation1 == "odejmij")
            {
                Console.WriteLine(x1 - x2);
                Console.ReadLine();
            }
            else
            if (operation1 == "pomnóż")
            {
                Console.WriteLine(x1 * x2);
                Console.ReadLine();
            }
            else
                if (operation1 == "podziel")
                {
                    Console.WriteLine(x1 / x2);
                    Console.ReadLine();
                }
               else
            Console.WriteLine("Wpisałeś złą opcję wyboru");
            }
        }
    }

 /*Program numer 2

            bool y1, y2;
            double x1, x2;

            Console.WriteLine("Podaj pierwszą cyfrę");
            y1 = double.TryParse(Console.ReadLine(), out x1);
            Console.WriteLine("Podaj drugą cyfrę");
            y2 = double.TryParse(Console.ReadLine(), out x2);

            if(y1 && y2)
            {
                Console.WriteLine("Obie cyfry są prawidłowe");
            }
            else
            {
                Console.WriteLine("Przynajmniej jedna cyfra jest nieprawidłowa");
            }
        }
    }
}

Program Numer 1
        
        {
            int x1, x2;

            Console.WriteLine("Ile zarabiasz rocznie (liczba)?");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ile potrzebujesz zarabiać (liczba)?");
            x2 = Convert.ToInt32(Console.ReadLine());

            if (x1 < x2)
            {
                Console.WriteLine("Weź się za siebie");
                Console.ReadLine();
            }
            if (x1 == x2)
            {
                Console.WriteLine("Zarabiasz dokładnie tyle ile potrzebujesz. Nie stać Cię na więcej?");
                Console.ReadLine();
            }
            if (x1 > x2)
            {
                Console.WriteLine("Zarabiasz więcej niż potrzebujesz. Gratulacje");
                Console.ReadLine();
            }
            else
            {
            }
        }
    }
}*/