using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            int ile = 100;
            stopWatch.Start();
            KlasaSwinkowa.MetodaKonkatenacji();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
            Console.ReadKey();
        }

    }
    public static class KlasaSwinkowa
    {
        public static int MetodaKonkatenacji()
        {
            int czasTrwania = 5;
            return ile;
        }

    }

}
