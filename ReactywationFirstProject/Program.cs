using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OwnTask
{
    class FirstClass
    {
        static void Main(string[] args)
        {
            Student uczen = new Student();
            Console.WriteLine($"{uczen.Wiek}");
            Console.WriteLine($"Oceny ucznia to {uczen.Grades}");
            Console.ReadKey();
        }
    }
    class Student
    {
        public Student()
        {
            Wiek = wiek;
            Grades = grades;
        }

        public int Wiek { get; set; }

        private int wiek = 21;

        public List<int> Grades { get; set; }

        private List<int> grades = new List<int> { 1, 2, 3 };
    }
}