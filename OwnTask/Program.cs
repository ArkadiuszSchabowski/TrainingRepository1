using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OwnTask
{
    class DisplayProgram
    {
    public static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine($"Numer 1: {student.Owner}, Wiek {student.Wiek}, Oceny ucznia to: {string.Join(",",student.Grades)}");
            Console.WriteLine($"Numer 2: {student.Owner2}, Wiek {student.Wiek2}, Oceny ucznia to: {string.Join(",", student.Grades2)}");
            Console.ReadKey();
        }
    }
    class Student
    {
        private string owner = "Tola";
        private int wiek = 20;
        public string Owner { get; set; }
        public int Wiek { get; set; }

        private string owner2 = "Pepa";
        private int wiek2 = 22;
        public string Owner2 { get; set; }
        public int Wiek2 { get; set; }
        public Student()
        {
            this.Owner = owner;
            this.Wiek = wiek;
            this.Grades = grades;
            this.Owner2 = owner2;
            this.Wiek2 = wiek2;
            this.Grades2 = grades2;
        }

        private List<int> grades = new List<int> { 3, 6, 5 };
        public List<int> Grades { get; set; }

        private List<int> grades2 = new List<int> { 6, 5, 3 };
        public List<int> Grades2 { get; set; }
    }

}