using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3MonthProject
{
    //    Oto pomysł na projekt konsolowy w języku C#, który będzie odpowiedni po nauce przez 3 miesiące w średnim tempie:
    //Stwórz program konsolowy do zarządzania listą zadań.Program powinien umożliwiać użytkownikowi dodawanie, usuwanie i edytowanie zadań, a także wyświetlanie listy zadań.

    //Główne funkcjonalności programu mogą obejmować:

    //    Dodawanie nowych zadań do listy.Użytkownik powinien móc wprowadzić opis zadania, datę wykonania i priorytet zadania.

    //    Usuwanie zadań z listy. Użytkownik powinien móc wybrać zadanie do usunięcia na podstawie jego numeru ID.

    //    Edytowanie zadań na liście. Użytkownik powinien móc zmienić opis, datę wykonania lub priorytet wybranego zadania.

    //    Wyświetlanie listy zadań.Program powinien umożliwić użytkownikowi wyświetlenie całej listy zadań, posortowanej według daty wykonania lub priorytetu.

    //    Zapisywanie i wczytywanie listy zadań.Program powinien umożliwić użytkownikowi zapisanie listy zadań do pliku i wczytanie jej ponownie w późniejszym czasie.

    //Projekt ten wymagałby pracy z typami danych, pętlami, warunkami, funkcjami oraz operacjami na plikach.W ciągu 3 miesięcy nauki powinieneś być w stanie zaimplementować większość funkcjonalności projektu. Powodzenia!

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            string newTask, descriptionTask;
            int taskPriority;
            int deleteTask;
            bool check;
            bool checkDelete;

            StreamWriter sw = new StreamWriter("file.txt");

            Console.WriteLine("Witaj w programie o nazwie: lista zadań.");

            //Console.WriteLine("Naciśnij escape, aby zakończyć program lub inny klawisz, aby kontynuować.");
            //Console.ReadKey().Key != ConsoleKey.Escape

            while (true)
            {
                Console.WriteLine("Wybierz operację, którą chcesz wykonać\n");

                Console.WriteLine("1. Wyświetl listę zadań\n2. Dodaj zadanie\n3. Usuń zadanie\n4. Edytuj zadanie.\n5. Zakończ program");
                ConsoleKey operation = Console.ReadKey().Key;

                switch (operation)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Oto Twoja lista zadań:\n");
                        Console.WriteLine(File.ReadAllText("ListaSwinki.txt"));
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Dodaj tytuł zadania:");
                        newTask = Console.ReadLine();

                        Console.WriteLine("Dodaj opis zadania:");
                        descriptionTask = Console.ReadLine();

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Nadaj priorytet zadaniu: 1-Pilne!, 2-Standard, 3-W wolnej chwili");
                            check = int.TryParse(Console.ReadLine(), out taskPriority);
                            if (check && taskPriority > 0 && taskPriority < 4)
                            {
                                break;
                            }
                        }
                        string taskString = ($"Zadanie: {newTask},Opis: {descriptionTask},Priorytet: {taskPriority}");
                        lista.Add(taskString);
                        File.AppendAllLines("ListaSwinki.txt", lista);
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Wybierz numer ID zadania, które chcesz usunąć:");

                        List<string> pobrana = new List<string>();

                        for (int i = 0; i < pobrana.Count; i++)
                        {
                            string zawartoscPliku = File.ReadAllText("ListaSwinki.txt");
                            pobrana.AddRange(zawartoscPliku.Split('\n'));

                            checkDelete = int.TryParse(Console.ReadLine(), out deleteTask);

                            if (checkDelete && deleteTask > 0 && deleteTask <= lista.Count)
                            {
                                lista.RemoveAt(deleteTask - 1);
                                Console.WriteLine("Zadanie zostało usunięte z listy.");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Podano nieprawidłowy numer ID zadania.");
                            }
                        }
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Edytuj zadanie");
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("\nDziękuję za skorzystanie z programu. Naciśnij dowolny klawisz, aby zakończyć.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Niewłaściwa operacja");
                        break;
                }
            }
        }
    }
}