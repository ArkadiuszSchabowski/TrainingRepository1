using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PapierKamien
{
    class FirstClass
    {
        static string _player = "";
        static string _computer = "";
        static int _computerPoints = 0;
        static int _playerPoints = 0;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random;
            string player;
            string computer;
            
            //Wybór użytkownika
            Console.WriteLine("Witaj w grze: Papier, Kamień, Nożyce. Wygrywa ten, kto zdobedzie 5pkt. Grasz przeciwko wlasnemu komputerowi.\n");
            Console.WriteLine("Nacisnij dowolny klawisz, by sprawdzic swoje sily!");
            Console.ReadKey();

            while (_playerPoints < 5 || _computerPoints < 5)
            {
                Console.Clear();
                Console.Write("Wybierz z opcji: Papier, Kamien, Nozyce: ");
                player = Console.ReadLine().ToUpper();
                _player = player;

                random = rnd.Next(1, 4);

                switch (random)
                {
                    case 1:
                        computer = "KAMIEN";
                        _computer = computer;
                        break;
                    case 2:
                        computer = "PAPIER";
                        _computer = computer;
                        break;
                    case 3:
                        computer = "NOZYCE";
                        _computer = computer;
                        break;
                }
                Console.WriteLine($"\nWybór gracza to: {player}.");
                Console.WriteLine($"Wybór komputera to: {_computer}.\n");
                CompareValues(player, _computer);
                Console.WriteLine($"Użytkownik {_playerPoints} : {_computerPoints} Komputer\n");
                Console.WriteLine("Nacisnij dowolny klawisz, by zaczac kolejna gre.");
                Console.ReadKey();
            }
        }
        static void CompareValues(string player, string computer)
        {
            player = _player;
            computer = _computer;

            if (_player == "KAMIEN" && _computer == "PAPIER")
            {
                Console.WriteLine("Wygrana komputera!");
                _computerPoints++;
            }
            if (_player == "KAMIEN" && _computer == "NOZYCE")
            {
                Console.WriteLine("Twoja wygrana!");
                _playerPoints++;
            }
            if (_player == _computer)
            {
                Console.WriteLine("Remis!");
            }
            if (_player == "PAPIER" && _computer == "NOZYCE")
            {
                Console.WriteLine("Wygrana komputera!");
                _computerPoints++;

            }
            if (_player == "PAPIER" && _computer == "KAMIEN")
            {
                Console.WriteLine("Twoja wygrana!");
                _playerPoints++;
            }
            if (_player == "NOZYCE" && _computer == "KAMIEN")
            {
                Console.WriteLine("Wygrana komputera!");
                _computerPoints++;
            }
            if (_player == "NOZYCE" && _computer == "PAPIER")
            {
                Console.WriteLine("Twoja wygrana!");
                _playerPoints++;
            }
        }
    }
}
