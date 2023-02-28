using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToeGame
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isPlayer1Turn { get; set; } = true;
        public MainWindow()
        {
            InitializeComponent();

            NewGame();

        }
        public void NewGame()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            isPlayer1Turn ^= true;

            var button = sender as Button;

            button.Content = isPlayer1Turn ? "O" : "X";
        }

    }
}
