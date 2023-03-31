using System;

namespace Lekcja48
{
    class Program
    {
        static void Main(string[] args)
        {
            Tekst tekst = new Tekst("hello");
            tekst[0] = 'H';
            Console.Write(tekst["jeden"]);
            Console.Write(tekst[1]);
            Console.Write(tekst[2]);
            Console.Write(tekst[3]);
            Console.WriteLine(tekst["ostatni"]);
        }
    }

    class Tekst
    {
        public Tekst(string txt)
        {
            tekst = new char[txt.Length];
            for (int i = 0; i < txt.Length; i++)
            {
                tekst[i] = txt[i];
            }
        }

        private char[] tekst;

        public char this[int n]
        {
            get
            {
                return tekst[n];
            }
            set
            {
                tekst[n] = value;
            }
        }

        public char this[string n]
        {
            get
            {
                if (n.Equals("jeden"))
                    return tekst[0];
                return tekst[tekst.Length - 1];
            }
        }
    }
}
