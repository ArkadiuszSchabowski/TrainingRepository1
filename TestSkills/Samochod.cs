using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSkills
{
    abstract class Samochod
    {
        public Samochod()
        {

        }
        public void Kolor()
        {
            Console.WriteLine("Twój samochód ma kolor niebieski");
        }
        public void MozliwoscSkrecania()
        {
            Console.WriteLine("Twój samochód posiada kierownicę dzięki, której skręca");
        }
    }
}
