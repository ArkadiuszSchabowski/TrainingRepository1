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
            var card = new Card("Arkadiusz");
            card.RegisterNewTrace(5, "22.02.2023", "Kropka przygotowanie do zdobycia tytułu mistrza C#");
            card.RegisterNewTrace(42, "23.02.2023", "Kropka Mistrzem C#");
            card.ShowCard();
            var membercard = new MemberCard("Owner", "Organisation");
            Console.WriteLine($"Organizacja, do której należy członek to: {membercard.Organisation}.");
            var tripWithGroup = new SherpaCard("Trip with friends", "1");
            tripWithGroup.RegisterNewTripWithGroup("02.23 8:00 - Start", "02.23 16:00 - Koniec", 20);
            //var guide = new GuideCard("Przewodnik Kreska");
            //Console.WriteLine($"\nId przewodnika Kreski to: {guide.Id}");
            Console.ReadKey();
        }
    }
}

//    public class GuideCard : Card
//    {
//        private int id = 1;

//        public string Id;


//        public GuideCard(string owner) : base(owner)
//        {
//            this.Id = id.ToString().PadLeft(4,'0');
//            id++;
//        }
//        public void TripWithMembers()
//        {

//        }
//    }
//}