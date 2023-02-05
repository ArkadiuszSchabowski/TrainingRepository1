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
            string typOdziezy, operation1, kolor;
            Console.WriteLine("Aplikacja dla Kobiet.\n");

            while (true)
            {

                Console.Write("Wybierz typ odzieży: buty, bielizna: ");
                typOdziezy = Console.ReadLine();

                if (typOdziezy == "buty")
                {
                    Console.Write("\nWybierz typ butów: ");
                    Console.Write("koturny, szpilki, kozaki: ");
                    operation1 = Console.ReadLine();

                    if (operation1 == "koturny")
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

                    if (operation1 == "szpilki")
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

                    if (operation1 == "kozaki")
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
                    Console.Write("\nWybierz typ bielizny: stringi, figi: ");
                    

                    operation1 = Console.ReadLine();
                    if(operation1 == "stringi")
                    {
                        Console.WriteLine("\nI tak dostanę się do twojej szparki\n");
                    }
                    if (operation1 == "figi")
                    {
                        Console.WriteLine("\nI tak zaraz ci je ściągne\n");
                    }
                }
            }
        }
    }
}