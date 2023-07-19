using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithPolymorphism
{
    //Polimorfizm - czyli wielopostaciowość. Polimofrizm dzieli się na polimorfizm statyczny i dynamiczny. Statyczny to przeciążanie metode o tej samej nazwie za pomocą zmiany ilości argumentów, czy kolejności ich typów. Natomiast polimorfizm dynamiczny jest ściśle powiązany z słówkami kluczowymi takimi jak: virtual, override ora base. Dzięki temu możemy stworzyć w klasie bazowej metodę oznaczoną jako virtual, a następnie w klasach pochodnych nadpisać te metody za pomocą słówka kluczowego ovveride.

    public class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>()
            {
                new Square(),
                new Triangle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            Console.ReadKey();
        }
    }
    public class Shape
    {
        public virtual void Draw()
        {

        }
    }
    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Square");
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Triangle");
        }
    }
}
