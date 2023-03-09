using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Program
    {
        static void Main(string[] args)
        {
            Druid kropka = new Druid();
            kropka.TerraHur(200);

            ILeczenie leczenie = (ILeczenie)kropka;
            leczenie.Sio(250);
            leczenie.MasRes(150);
        }
    }
    interface IAtakTerraHur
    {
        void TerraHur(int obrazenia);
    }
    interface ILeczenie
    {
        void Sio(int uleczGracza);
        void MasRes(int uleczObszarowo);
    }
    public class Character
    {
        public void Poruszanie()
        {
            Console.WriteLine("Poruszanie za pomocą strzałek");
        }
    }
    public class Druid : Character, IAtakTerraHur, ILeczenie
    {
        public void TerraHur(int obrazenia)
        {
            Console.WriteLine("Atak TerraHur");
        }

        public void TypRozdzki()
        {
            Console.WriteLine("Zezwól na założenie roda");
        }

        void ILeczenie.MasRes(int uleczObszarowo)
        {
            Console.WriteLine("Spell: Exura gran mas res");
        }

        void ILeczenie.Sio(int uleczGracza)
        {
            Console.WriteLine("Spell: Exura sio player");
        }
    }
}
