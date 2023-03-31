using System;
using System.Collections.Generic;
using System.Text;

namespace Lekcja43
{
    class Person
    {
        public string name;
        public int age;

        public void Hello()
        {
            Console.WriteLine($"Cześć, jestem {name} i mam {age} lat.");
        }
    }
}
