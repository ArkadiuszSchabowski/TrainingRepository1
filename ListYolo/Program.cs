using System.Collections.Generic;
using System;

namespace ConsoleApp9
{
    class UrodzinowyProjekt
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<UrodzinowyProjekt> Submenus { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            UrodzinowyProjekt Menu = new UrodzinowyProjekt
            {
                Id = 0,
                Name = "Wybierz dział nauki dla - .Net / C# develeoper, np. (10)",
                Submenus = new List<UrodzinowyProjekt>
                {
                    new UrodzinowyProjekt
                    {
                        Id = 1,
                        Name = "Podstawy C#",
                        Submenus = new List<UrodzinowyProjekt>
                        {
                            new UrodzinowyProjekt
                            {
                                Id = 1,
                                Name = "Zmienne"
                            },
                            new UrodzinowyProjekt
                            {
                                Id = 2,
                                Name = "Instrukcje",
                                Submenus = new List<UrodzinowyProjekt>
                                {
                                    new UrodzinowyProjekt
                                    {
                                        Id = 1,
                                        Name = "If",
                                    },
                                    new UrodzinowyProjekt
                                    {
                                        Id = 2,
                                        Name = "Switch",
                                    }
                                }
                            },
                            new UrodzinowyProjekt
                            {
                                Id = 3,
                                Name = "Pętle"
                            }
                        }
                    },
                    new UrodzinowyProjekt
                    {
                        Id = 2,
                        Name = "Visual Studio",
                        Submenus = new List<UrodzinowyProjekt>
                        {
                            new UrodzinowyProjekt
                            {
                                Id = 1,
                                Name = "Instalacja"
                            },
                            new UrodzinowyProjekt
                            {
                                Id = 2,
                                Name = "Skróty klawiszowe"
                            }
                        }
                    },
                    new UrodzinowyProjekt
                    {
                        Id = 3,
                        Name = "Programowanie obiektowe",
                        Submenus = new List<UrodzinowyProjekt>
                        {
                            new UrodzinowyProjekt
                            {
                                Id = 1,
                                Name = "Polimorfizm"
                            },
                            new UrodzinowyProjekt
                            {
                                Id = 2,
                                Name = "Dziedziczenie"
                            }
                        }
                    }
                }
            };


            DisplayFirstElement(Menu);

            var currentSubMenus = Menu.Submenus;
            UrodzinowyProjekt currentMenu = null;

            while (true)
            {
                var currentId = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (currentMenu == null || currentMenu.Submenus == null || currentMenu.Submenus.Count == 0)
                {
                    Console.WriteLine("Koniec.");
                    break;
                }

                currentSubMenus = currentMenu.Submenus;

                foreach (var menu in currentSubMenus)
                {
                    Console.WriteLine($"{menu.Id}. {menu.Name}");
                }
            }

            Console.WriteLine("\nTwój wybór to:");
            Console.WriteLine(currentMenu.Name);
            Console.WriteLine("\nGratulacje!");

            Console.ReadKey();
        }

        private static void DisplayFirstElement(UrodzinowyProjekt Menu)
        {
            Console.WriteLine(Menu);

            foreach (var menu in Menu.Submenus)
            {
                Console.WriteLine($"{menu.Id}. {menu.Name}");
            }
        }
    }
}