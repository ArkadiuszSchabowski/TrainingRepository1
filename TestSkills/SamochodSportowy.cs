using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSkills
{
    class Subaru : Samochod
    {
        public void Model()
        {
            Console.WriteLine("Twój samochód to Subaru Impreza");
        }
        public void Cena()
        {
            Console.WriteLine("Twój Samochód kosztuje: 200000zł");
        }
    }
}
