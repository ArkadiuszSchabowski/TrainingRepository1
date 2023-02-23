using EXE6;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace NeverSurrender
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card();
            var membercard = new MemberCard();
            var sherpacard = new SherpaCard();
            var tripWithGroup = new SherpaCard();
            Console.WriteLine($"Wlasciciel legitymacji to: {card.Owner}, numer legitymacji to {card.Number}.");
            Console.WriteLine($"Organizacja, do której należy członek to: {membercard.Organisation}.\n");
            card.RegisterNewTrace(5, "22.02.2023", "Kropka przygotowanie do zdobycia tytułu mistrza C#");
            card.RegisterNewTrace(42, "23.02.2023", "Kropka Mistrzem C#");
            card.ShowAllTraces();
            Console.WriteLine($"Twój przebyty dystans to: {card.Distance}km");
            sherpacard.ShowSherpaCard();
            tripWithGroup.RegisterNewTripWithGroup("02.23 8:00 - Start", "02.23 16:00 - Koniec", 20);
            //var guide = new GuideCard("Przewodnik Kreska");
            //Console.WriteLine($"\nId przewodnika Kreski to: {guide.Id}");
            Console.ReadKey();
        }
    }
}