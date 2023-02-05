using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace needSomeCofee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typOdziezy, rodzajButow, typBielizny, rodzajBielizny, kolor, kroj;
            Console.WriteLine("Aplikacja dla Kobiet.\n");

            while (true)
            {

                Console.Write("Wybierz typ odzieży: buty, bielizna: ");
                typOdziezy = Console.ReadLine();

                if (typOdziezy == "buty")
                {
                    Console.Write("\nWybierz typ butów: ");
                    Console.Write("koturny, szpilki, kozaki: ");
                    rodzajButow = Console.ReadLine();

                    if (rodzajButow == "koturny")
                    {
                        Console.Write("\nWybierz kolor koturnów: ");
                        Console.Write("białe, beżowe, czarne: ");
                        kolor = Console.ReadLine();
                        Console.WriteLine("");

                        if (kolor == "białe")
                        {
                            Console.WriteLine("Twój wybór do białe koturny");
                        }
                        if (kolor == "beżowe")
                        {
                            Console.WriteLine("Twój wybór do beżowe koturny");
                        }
                        if (kolor == "czarne")
                        {
                            Console.WriteLine("Twój wybór to czarne koturny");
                        }
                        Console.Write("");
                    }

                    if (rodzajButow == "szpilki")
                    {
                        Console.Write("\nWybierz kolor szpilek: ");
                        Console.Write("różowe, czarne: ");
                        kolor = Console.ReadLine();
                        Console.WriteLine("");

                        if (kolor == "różowe")
                        {
                            Console.WriteLine("Twój wybór to różowe szpilki");
                        }

                        if (kolor == "czarne")
                        {
                            Console.WriteLine("Twój wybór to czarne szpilki");
                        }
                        Console.WriteLine("");
                    }

                    if (rodzajButow == "kozaki")
                    {
                        Console.Write("\nWybierz kolor kozaków: białe, beżowe czarne: ");
                        kolor = Console.ReadLine();
                        Console.WriteLine("");

                        if (kolor == "białe")
                        {
                            Console.WriteLine("Twój wybór to białe kozaki");
                        }
                        if (kolor == "beżowe")
                        {
                            Console.WriteLine("Twój wybór to beżowe kozaki");
                        }
                        if (kolor == "czarne")
                        {
                            Console.WriteLine("Twój wybór to czarne kozaki");
                        }
                        Console.WriteLine("");
                    }
                }
            

                if (typOdziezy == "bielizna")
                {
                    Console.Write("\nWybierz typ bielizny: figi, stringi: ");
                    typBielizny = Console.ReadLine();

                    if(typBielizny == "figi")
                    {
                        Console.Write("\nWybierz rodzaj: koronkowe, gładkie: ");
                        rodzajBielizny = Console.ReadLine();

                        if (rodzajBielizny == "koronkowe")
                        {
                            Console.WriteLine("\nTwój wybór to koronkowe figi\n");
                        }
                        if (rodzajBielizny == "gładkie")
                        {
                            Console.WriteLine("\nTwój wybór to gładkie figi\n");
                        }

                    }
                    if (typBielizny == "stringi")
                    {
                        Console.WriteLine("\nWybierz krój: G-Stringi(G), T-Stringi(T): ");
                        kroj = Console.ReadLine();

                        if (kroj == "G")
                        {
                            Console.WriteLine("\nTwój wybór to: stringi typu G\n"); 
                        }
                        if (kroj == "T")
                        {
                            Console.WriteLine("\nTwój wybór to stringi typu T\n");
                        }
                    }
                }
            }
        }
    }
}