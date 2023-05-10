using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Main_System
{
    public class CarParts
    {
        public Random rnd = new Random();
        public List<string> orders = new List<string>();

        public void Brembo()
        {
            int bremboOrders = rnd.Next(1, 5);

            List<string> listBrembo = new List<string>()
            {
                "Klocki hamulcowe - MD19132",
                "Klocki hamulcowe - JG23145",
                "Zacisk hamulcowy - MD23142",
                "Tarcza hamulcowa - MD21902",
            };
            orders.Add(listBrembo[bremboOrders]);
        }
        public void Gkn()
        {
            List<string> listBrembo = new List<string>()
            {
                 "Oslona przegubu - GKN2341",
                 "Oslona przegubu - GKN2389",
                 "Krzyzak walu napedowego - U-942",
                 "Smar do przegubow - 9043111"
            };
        }
        public void Rts()
        {
            List<string> listRts = new List<string>()
            {
                "Sworzen wahacza - 9140650",
                "Sworzen wahacza - 9300850",
                "Wahacz Renault lewy - 34817",
                "Wahacz Renault prawy - 34818"
            };
        }
        public void Snr()
        {
            List<string> listSnr = new List<string>()
            {
                "Lozysko amortyzatora Citroen",
                "Zestaw piasty kola tyl",
                "Lozysko piasty kola",
                "Lozysko kola Mazda 6 - przod",
            };
        }
    }
}
