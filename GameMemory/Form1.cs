using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMemory
{

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<int> list = new List<int>
    {
        1, 1, 2, 2, 3, 3, 4, 4,
        5, 5, 6, 6, 7, 7, 8, 8
    };
        public Form1()
        {
            InitializeComponent();
            AssignItemsToSquares();
        }
        public void AssignItemsToSquares()
        {
            Label label;

            int position = rnd.Next(0, 16);


            for (int i = 0; i < list.Count; i++)
            {
                if (!list.Contains(list[position]))
                {
                    list[i] = position;
                }
                tableLayoutPanel1.Controls = position;
            }
        }
    } 
}
