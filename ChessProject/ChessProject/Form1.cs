using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OwnChessField();
        }

        public void OwnChessField()
        {
            Label label;

            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    int index = row * tableLayoutPanel1.ColumnCount + col;

                    label = tableLayoutPanel1.Controls[index] as Label;

                    if ((row % 2 == 0 && col % 2 == 0) || (row % 2 == 1 && col % 2 == 1))
                    {
                        label.BackColor = Color.YellowGreen;
                    }
                    else
                    {
                        label.BackColor = Color.DarkGreen;
                    }
                }
            }
        }
    }
}