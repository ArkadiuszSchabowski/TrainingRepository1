using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    internal class TabelaNagrod
    {
        
        public static string Nagrody()
        {
            List<string> listaNagrod = new List<string>();

            listaNagrod.Add("Świński Kubek (nagroda pocieszenia");
            listaNagrod[1] = "Zapas siana na miesiąc (nagroda gwarantowana)";
            listaNagrod[2] = "Miesięczny zapas karmy Versele Laga";
            listaNagrod[3] = "Miesięczny warzywny catering dietetyczny";
            listaNagrod[4] = "Świński Hamak (nagroda gwarantowana)";
            listaNagrod[5] = "Klatka dla 3 świnek o wymiarach 120cmx60cm";
            listaNagrod[6] = "Zestaw świnkowych domków";
            listaNagrod[7] = "Zestaw 10 zabiegów SPA oraz kąpieli błotnych";
            listaNagrod[8] = "2-tygodniowe wakacje all-inclusive na rajską wyspę Pig Beach na Bahamach z osobą towarzyszącą";
            listaNagrod[9] = "Ogromny zagrodzony świński wybieg dla całego stada zakryty antydrapieżną siatką";

            for (int i = 0; i < listaNagrod.Count + 1; i++)
            {
                Console.WriteLine(listaNagrod[i]);
            }
            return listaNagrod[0];
        }
    }
}
