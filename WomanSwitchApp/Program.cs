using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WomanSwitchApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typOdziezy, typObuwia, typBielizny;

            Console.WriteLine("Wybierz typ odzieży: buty, bielizna");
            typOdziezy = Console.ReadLine();

            switch (typOdziezy)
            {
                case "buty":
                    Console.WriteLine("Wybierz rodzaj butów: koturny, szpilki, kozaki");
                    typObuwia = Console.ReadLine();

                    switch (typObuwia)
                    {
                        case "koturny":
                            {
                                Console.WriteLine("Twój wybór to koturny");
                                Console.ReadKey();
                                break;
                            }
                        case "szpilki":
                            {
                                Console.WriteLine("Twój wybór to szpilki");
                                Console.ReadKey();
                                break;
                            }
                        case "kozaki":
                            {
                                Console.WriteLine("Twój wybór to kozaki");
                                Console.ReadKey();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Niewłaściwy wybór");
                            }
                            break;
                    }
                    break;
                case "bielizna":
                    Console.WriteLine("Wybierz typ bielizny: figi, stringi");
                    typBielizny = Console.ReadLine();
                    Console.ReadKey();
                    { 
                        switch(typBielizny)
                        {
                            case "figi":
                                {
                                    Console.WriteLine("Twój wybór to figi");
                                    break;
                                }
                        }break;
                    }

            }
        }
    }
}
