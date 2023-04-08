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
        static void Main(string[] args)
        {
            bool mainGame = true;
            string wygrana = "0";
            StreamWriter sw = new StreamWriter("wygrana.txt");

            try
            {
                while (mainGame == true)
                {

                    Console.WriteLine("Witaj w świnskich milionerach\n");
                    Console.WriteLine("Podaj swoje imię");
                    string name = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Witaj w milionerach {name}.");

                    bool firstQuestion = Pytanie1.PytaniePierwsze();
                    if (firstQuestion == true)
                    {
                        Pytanie2.PytanieDrugie();
                    }
                    else if(firstQuestion == false)
                    {
                        wygrana = TabelaNagrod.Nagrody();

                        Console.WriteLine($"Dziękujemy za grę, wygrywasz {wygrana}");
                        Console.ReadKey();
                    }
                }
                //sw.WriteLine($"{DateTime.Now} zdobył: {wygrana}");
                //sw.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
