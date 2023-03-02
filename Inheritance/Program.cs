using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            var postac = new Postac();
            postac.Name();
            Console.WriteLine($"Początkowe punkty HP to: {Postac.PunktyHp}, punkty MP to: {Postac.PunktyMp}.");
            Console.ReadKey();
            postac.Level();
            var postacRook = new None();
            var postacMainland = new Druid();
        }
        public class Postac
        {
            public static int PunktyHp { get; set; }
            private static int punktyHp = 150;
            public static int PunktyMp { get; set; }
            private static int punktyMp = 0;
            public Postac()
            {
                PunktyHp = punktyHp;
                PunktyMp = punktyMp;
            }
            public void Name()
            {
                Console.WriteLine("Podaj nazwę postaci:");
                string characterName = Console.ReadLine();
                Console.WriteLine($"Twoja nazwa postaci to {characterName}.");
            }
            public void Level()
            {
                int sum = 0;

                var healthPoints = new Dictionary<int, string>
                {
                    healthPoints.Add(1, "level1");

                };


                foreach (var elem in healthPoints)
                {
                    sum += 5;
                }
                Console.WriteLine(healthPoints);
                Console.ReadKey();
            }
            public void manaPoints()
            {
                int sum = 0;

                var manaPoints = new List<int>();
                manaPoints.Add(150);

                foreach (var hp in manaPoints)
                {
                    sum += 5;
                }
                Console.WriteLine(sum);
                Console.ReadKey();
            }

        }
        class None : Postac
        {
            public void Profesja()
            {
                Console.WriteLine("Nie masz jeszcze profesji");
            }
            public void ManaPoints()
            {

            }
        }
        class Druid
        {
            public void Profesja()
            {
                Console.WriteLine("Twoja profesja to: Druid");
            }
            public void HealthPoints()
            {

            }
            public void ManaPoints()
            {

            }
        }
        class Knight
        {
            public void Profesja()
            {
                Console.WriteLine("Twoja profesja to: Knight");
            }
            public void HealthPoints()
            {

            }
            public void ManaPoints()
            {

            }
        }
    }
}
