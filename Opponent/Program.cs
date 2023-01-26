using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TwojaKlasa
{
    static void Main(string[] args)

    {

    }
}
        //Program Numer 9 - cwiczenia
//        bool y1, y2;
//        double x1, x2;
//        string operation1, operation2;

//        Console.WriteLine("Podaj pierwszą cyfrę");
//        y1 = double.TryParse(Console.ReadLine(), out x1);
//        Console.WriteLine("Podaj drugą cyfrę");
//        y2 = double.TryParse(Console.ReadLine(), out x2);
//        Console.WriteLine("Podaj operację, którą chcesz wykonać");
//        Console.WriteLine("Dodaj, Odejmij, pomnóż, podziel");
//        operation1 = Console.ReadLine();
//        operation2 = Console.ReadLine();

//        if (operation1 == "dodaj")
//        {
//            Console.WriteLine("Wybierz 1 lub 2");

//        }
//        else
//        if (operation2 == "1")
//        {
//            Console.WriteLine("Wybrałeś 1");
//        }
//        else
//        if (operation2 == "2")
//        {
//            Console.WriteLine("Wybrałeś 2");
//        }
//    }
//}

//        if (operation1 == "odejmij")
//        {
//            Console.WriteLine("wynik = " + (x1 - x2));
//            Console.ReadKey();
//        }
//        if (operation1 == "pomnóż")
//        {
//            Console.WriteLine("wynik = " + (x1 * x2));
//            Console.ReadKey();
//        }
//        if (operation1 == "podziel")
//        {
//            Console.WriteLine("wynik = " + (x1 / x2));
//            Console.ReadKey();
//        }

//    }
//}

//Program 8 - Menu prawidłowe
//            Console.Title = "Proste Menu";

//            while (true)
//            {
//                Console.WriteLine("Jaką chcesz kawę?");
//                Console.WriteLine("1. Czarną");
//                Console.WriteLine("2. Biała");
//                Console.WriteLine("3.Koniec");

//                ConsoleKeyInfo klawisz = Console.ReadKey();
//                switch (klawisz.Key)
//                {
//                    case ConsoleKey.D1:
//                        Console.Clear(); OpcjaWBudowie(); break;
//                    case ConsoleKey.D2:
//                        Console.Clear(); OpcjaWBudowie(); break;
//                    case ConsoleKey.Escape: break;
//                    case ConsoleKey.D3:
//                        Environment.Exit(0); break;
//                    default: break;
//                }
//                static void OpcjaWBudowie()
//                {
//                    Console.Write("Opcja w budowie");
//                    Console.ReadKey();
//                }
//            }
//        }
//    }
//Program 7 - Pętla w pętli - zagnieżdżanie pętli
//        {
//            int x1, x2;

//            x1 = 0;
//            x2 = 0;
//            while (x1 <= 3)
//            {
//                while(x2 <=3)
//                {
//                    Console.WriteLine("x1 " + x1 + "    x2 " + x2);
//                    x2++;
//                }
//                x2 = 0;
//                x1++;
//            }

//        }
//    }
//}

//Program Numer 6 - Petla for
//        {
//            for (int hp = 100; hp <= 100; hp--)
//            {
//                Console.WriteLine(hp);

//            }
//        }
//    }
//}





//Program Numer 5 - Petla While
// * {
//            int hp = 100;
//            while (hp <= 100)
//            {
//                Console.WriteLine(hp);
//                hp--;
//            }
//        }
//    }
//}
//        {
//            {
//Program 4
//                bool con1, con2;
//                double x1, x2;
//                string operation1;

//                Console.WriteLine("Podaj pierwszą cyfrę");
//                con1 = double.TryParse(Console.ReadLine(), out x1);
//                Console.WriteLine("Podaj drugą cyfrę");
//                con2 = double.TryParse(Console.ReadLine(), out x2);
//                Console.WriteLine("Podaj operację, którą chcesz wykonać.");
//                Console.WriteLine("Dostępne opcje: dodaj, odejmij, pomnóż, podziel");
//                operation1 = Console.ReadLine();

//                    switch (operation1)
//                    {
//                        case "dodaj":
//                            Console.WriteLine(x1 + x2);
//                            Console.ReadLine();
//                            {
//                                break;
//                            }
//                        case "odejmij":
//                            Console.WriteLine(x1 - x2);
//                            Console.ReadLine();
//                            {
//                                break;
//                            }
//                        case "pomnóż":
//                            Console.WriteLine(x1 * x2);
//                            Console.ReadLine();
//                            {
//                                break;
//                            }
//                        case "podziel":
//                            Console.WriteLine(x1 / x2);
//                            Console.ReadLine();
//                            {
//                                break;
//                            }
//                        default:
//                            {
//                                break;
//                            }
//                    }

//            }
//        }
//    }
//}
//Program Numer 3
//        {
//            double x1, x2;
//            string operation1;

//            Console.WriteLine("Podaj pierwszą cyfrę");
//            x1 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Podaj drugą cyfrę");
//            x2 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Podaj operację, którą chcesz wykonać.");
//            Console.WriteLine("Dostępne opcje: dodaj, odejmij, pomnóż, podziel");
//            operation1 = Console.ReadLine();

//            if (operation1 == "dodaj")
//            {
//                Console.WriteLine(x1 + x2);
//                Console.ReadLine();
//            }
//            else
//            if (operation1 == "odejmij")
//            {
//                Console.WriteLine(x1 - x2);
//                Console.ReadLine();
//            }
//            else
//            if (operation1 == "pomnóż")
//            {
//                Console.WriteLine(x1 * x2);
//                Console.ReadLine();
//            }
//            else
//                if (operation1 == "podziel")
//                {
//                    Console.WriteLine(x1 / x2);
//                    Console.ReadLine();
//                }
//               else
//            Console.WriteLine("Wpisałeś złą opcję wyboru");
//            }
//        }
//    }

//Program numer 2

//            bool y1, y2;
//            double x1, x2;

//            Console.WriteLine("Podaj pierwszą cyfrę");
//            y1 = double.TryParse(Console.ReadLine(), out x1);
//            Console.WriteLine("Podaj drugą cyfrę");
//            y2 = double.TryParse(Console.ReadLine(), out x2);

//            if(y1 && y2)
//            {
//                Console.WriteLine("Obie cyfry są prawidłowe");
//            }
//            else
//            {
//                Console.WriteLine("Przynajmniej jedna cyfra jest nieprawidłowa");
//            }
//        }
//    }
//}

//Program Numer 1

//        {
//            int x1, x2;

//            Console.WriteLine("Ile zarabiasz rocznie (liczba)?");
//            x1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Ile potrzebujesz zarabiać (liczba)?");
//            x2 = Convert.ToInt32(Console.ReadLine());

//            if (x1 < x2)
//            {
//                Console.WriteLine("Weź się za siebie");
//                Console.ReadLine();
//            }
//            if (x1 == x2)
//            {
//                Console.WriteLine("Zarabiasz dokładnie tyle ile potrzebujesz. Nie stać Cię na więcej?");
//                Console.ReadLine();
//            }
//            if (x1 > x2)
//            {
//                Console.WriteLine("Zarabiasz więcej niż potrzebujesz. Gratulacje");
//                Console.ReadLine();
//            }
//            else
//            {
//            }
//        }
//    }
//}*/