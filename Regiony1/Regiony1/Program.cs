using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Regiony1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = $"../../../Test.txt";


            #region Zapis1

            //StreamWriter sw = new StreamWriter(path, true);

            //Console.WriteLine("Podaj tekst do przechowania");
            //sw.WriteLine(Console.ReadLine());
            //sw.Close();
            #endregion

            #region Odczyt1

            //Console.WriteLine();
            //Console.WriteLine(File.ReadAllText(path));
            #endregion

            #region Odczyt2

            StreamReader sr = new StreamReader(path);

            string line;

            List<string> lista= new List<string>();

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                lista.Add(line);
            }
            foreach (var item in lista)
            {
                Console.WriteLine(item + " Element w liście");
            }
            sr.Close();
            Console.ReadKey();
            #endregion
        }
    }
}