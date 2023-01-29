using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getSet
{
    class UrodzinowyProjekt
    {

        public string Lista { get; set; }

        public List<UrodzinowyProjekt> Submenus { get; set; }
    }

    internal class Program
        {

            static void Main(string[] args)
            {
                UrodzinowyProjekt Menu = new UrodzinowyProjekt();

                Menu.Lista = "Wybierz dział nauki dla - .Net / C# develeoper, np. (10) \n\n1.Podstawy C# \n2.Visual Studio \n3.Programowanie obiektowe\n4.Podstawy SQL\n5.Bazy danych\n6.Wzorce architektoniczne aplikacji\n7.Wzorce projektowe\n8.Uniwersalne umiejętności programistyczne\n9.SOLID\n10.Dependency Injection\n11.Frameworks\n12.Logowanie zdarzeń w aplikacji\n13.Unit testy\n14.Inne rodzaje testów\n15.Oprócz kodu\n16.Cashing danych\n17.Microservices\n";
                Console.WriteLine(Menu.Lista);
                Console.ReadKey();
            }
        }
    }
