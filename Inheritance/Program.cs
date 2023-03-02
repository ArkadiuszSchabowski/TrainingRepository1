using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {

            Mazda mazda = new Mazda();
            mazda.Pochodzenie();
            mazda.IloscKol();
            mazda.Kolor();
            Console.ReadKey();
        }
    }
    abstract class Samochod
    {
        public void Kolor()
        {
            Console.WriteLine("Każdy samochód jest jakiegoś koloru");
        }
    }
    abstract class SamochodOsobowy : Samochod
    {
        public void IloscKol()
        {
            Console.WriteLine("Każdy samochód osobowy ma 4 koła");
        }
    }
    class Mazda : SamochodOsobowy
    {
        public void Pochodzenie()
        {
            Console.WriteLine("Samochód Mazda wywodzi się z Japonii");
        }
    }
}
