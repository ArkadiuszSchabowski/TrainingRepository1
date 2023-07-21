using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentBetweenC_andJS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Jezyk C# jest statycznie typowany, dlatego nie pozwoli na taka akcje!
            // Inaczej wyrzuci nam blad. W JS jest to jak najbardziej akceptowane.

            //var number = 5;
            //Console.WriteLine(number);
            //number = "Pies";
            //Console.WriteLine(number);
            //Console.ReadKey();

            // Rowniez jesli chcecmy zadeklarowac zmienna typu var musimy od razu ja zainicjalizowac!
            // Inaczej wyrzuci nam blad. W JS jest to jak najbardziej akceptowane.

            //var text;

            //Zmienna w C# NIE moze zaczynac sie znakiem dolara!

            //string $data = "jakis string";

            //Switch w JS
            //W instrukcji warunkowej switch w JS warunku default nie trzeba konczyc slowkiem kluczowym break. W C# jest to niedopuszczalne.

            //Console.WriteLine("What is the your favorite animal?");
            //Console.WriteLine("A - guinea pig");
            //Console.WriteLine("B - dog");
            //Console.WriteLine("C - cat");
            //Console.WriteLine("D - rabbit");

            //string question = Console.ReadLine();
            //string text = "Your favorite animal is a ";

            //switch (question)
            //{
            //    case "A":
            //        Console.WriteLine(text + "guinea pig!");
            //        break;
            //    case "B":
            //        Console.WriteLine(text + "dog!");
            //        break;
            //    case "C":
            //        Console.WriteLine(text + "cat!");
            //        break;
            //    case "D":
            //        Console.WriteLine(text + "rabbit!");
            //        break;
            //    default:
            //        Console.WriteLine(text + "other animal!");
            //        break;
            //}
            //Console.ReadKey();

            //W JS nie ma wsparcia dla poliformizmu statycznego. Dlatego w przypadku takiego kodu wykona się druga funkcja, a pierwsza będzie ignorowana:

            //    <script>
            //        function Add(a, b)
            //        {
            //            let c = a + b;
            //            console.log("Wynik: " + c);
            //        }
            //        function Add(d, e, f)
            //        {
            //            let g = d + e + f;
            //            console.log("Wynik: " + g);
            //        }
            //        Add(1, 5);
            //        Add(1, 2, 5);
            //</ script >

        }
    }
}
