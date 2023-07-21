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

            //W JS można zaokrąglić metodą Math.round() do liczby całkowitej, aby zaokrąglić liczbę do double (np.2 miejsca po przecinku używamy metody toFixed(2) na naszej zmiennej let.

            //C#:
            //double a = 100;
            //double b = 3;
            //double result = Math.Round(a / b, 2);
            //Console.WriteLine($"Twój wynik to: {result}\n");

            //double c = 10;
            //double d = 3;
            //double result2 = c / d;
            //Console.WriteLine($"Twój wynik to: {Math.Round(result2, 2)}");
            //Console.ReadLine();

            // JS: 
            //    let divisionResult = division(100, 3)
            //    {
            //        console.log("Wynik przy użyciu metody: Math.round = " + Math.round(divisionResult));
            //        console.log(divisionResult.toFixed(2));
            //    }
        }
        //W JS możemy stworzyć zmienną globalną np. "text", a następnie nadpisać ją zmienną lokalną "text".
        //W C# nie ma takiej możliwości nazwy zmiennych nie mogą się powtarzać.

        // Błąd w C#:

        //class Testing
        //    {
        //    public string text = "HI";
        //    public void Test()
        //    {
        //        private string text = "Hello";
        //    }
        //}

        //JS: prawidłowy zapis

    //        <script>
    //    let data = 55;

    //    function test()
    //    {
    //        let data = 20;
    //        console.log("Wartość data", data);
    //    }

    //    test();
    //    console.log(data);

    //       </script>
    }
}
