using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsNormal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoStatic.LiczbaLudnosci();
            Auto auto = new Auto();
            auto.Wszystko();
        }
    }
    class Auto
    {
        public void Wszystko()
        {
            int a = 5;
            int b = 10;
            int result = a + b;
            Console.WriteLine("result");
        }
    }
    
    public static class AutoStatic
    {
        public static void LiczbaLudnosci()
        {
            string liczbaLudnosci = "2000";
            Console.WriteLine(liczbaLudnosci);
        }
    }
}
