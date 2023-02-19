using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RevisionArray();
            //WorkWithArrays();
            //TwoDimensionalArray();
            //GradesLoopyFor();
            //GradesArray();

            int[,] grades = new int[2, 3] { { 1, 4, 6 }, { 2, 9, 3 } };

            PrintArray(grades);
        }

        static void PrintArray(int[,]array)
        {

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i , j]+",");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
        static void RevisionArray()
        {
            int[] tablica1D = new int[5] { 0, 2, 3, 4, 5 };
            int[,] tablica2D = new int[3, 2] {

                { 1, 5 },
                { 2, 2 },
                { 3, 2 }
            };
            int[,] tablicaDwuwymiarowa = new int[2, 3] {

                { 0, 1, 2 },
                { 0, 3, 2 }
            };
            int[,,] Tablica3D = new int[2, 3, 3] { { { 0, 1, 7 }, { 4, 7, 2 }, { 5, 9, 4 }, }, { { 0, 1, 3 }, { 4, 7, 6 }, { 5, 9, 10 }, }, };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(Tablica3D[i, j, k]+",");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            foreach (int elem in Tablica3D)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();

        }
        static void WorkWithArrays()
        {
            int[] Tablica = new int[5] { 4, 3, 1, 2, 6 };
            Console.WriteLine(Tablica[4]);

            int[,] Tablica2 = new int[3, 6];
            Tablica2[2, 5] = 10;

            Console.WriteLine(Tablica2[2, 5]);

            int[][] TablicaTablic = new int[3][];
            int[] TablicaPierwsza = new int[3];
            int[] TablicaDruga = new int[2];

            TablicaPierwsza[0] = 5;
            TablicaPierwsza[1] = 9;
            TablicaPierwsza[2] = 3;

            TablicaDruga[0] = 11;
            TablicaDruga[1] = 22;

            Console.WriteLine(TablicaDruga[1]);
            Console.ReadKey();

        }
        static void TwoDimensionalArray()
        {
            int[,] Tablica = new int[2, 3];

            Tablica[0, 0] = 3;
            Tablica[0, 1] = 6;
            Tablica[0, 2] = 5;
            Tablica[1, 0] = 1;
            Tablica[1, 1] = 4;
            Tablica[1, 2] = 2;

            foreach (int elem in Tablica)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();

        }

        static void GradesLoopyFor()
        {
            int[] tablica = new int[10] { 5, 4, 3, 2, 1, 2, 3, 6, 6, 2 };
            double sum = 0;

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
                sum = sum + i;
            }
            Console.WriteLine();
            Console.WriteLine(sum);

            double grades = sum / tablica.Length;
            Console.WriteLine($"Twoją średnia to: {grades}");
            Console.ReadKey();
        }
        static void GradesArray()
        {
            double sum = 0;
            int[] NowaTablica = new int[10] { 3, 4, 5, 3, 2, 1, 6, 2, 2, 1 };

            //for (int i = 0; i < NowaTablica.Length; i++)
            //{
            //    Console.WriteLine("index " + i + " pozycja " + (i + 1) + " ocena " + NowaTablica[i]);
            //}

            foreach (int elem in NowaTablica)
            {
                sum += elem;
            }

            Console.WriteLine("\nSuma ocen to " + sum);
            Console.WriteLine("\nŚrednia ocen to " + (sum / NowaTablica.Length));
            Console.ReadKey();
        }
    }
}

