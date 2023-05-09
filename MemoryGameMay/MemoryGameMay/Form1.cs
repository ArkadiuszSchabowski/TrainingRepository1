using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameMay
{
    
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<string> list = new List<string>
        {
            "a","a","Q","Q","C","C", "X","X",
            "d","d","M","M","Z","Z","I","I",
        };
        public Form1()
        {
            InitializeComponent();
            AssignItemsToSquares();
        }
        public void AssignItemsToSquares()
        {
            Label label;
            int position;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
               
                position = rnd.Next(0,list.Count);
                label.Text = list[position];

                list.RemoveAt(position);          
            }
        }
    }
}
