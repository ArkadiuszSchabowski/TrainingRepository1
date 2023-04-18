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
            ChessField();
        }
        public void ChessField()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.RowCount*tableLayoutPanel1.ColumnCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.RowCount*tableLayoutPanel1.ColumnCount; j++)
                {
                    label = tableLayoutPanel1.Controls[i] as Label;

                    if (i % 2 == 0)
                    {
                        label.BackColor = Color.White;
                    }
                }
            }
        }

        public void OwnChessField()
        {
            Label wiersz;
            Label kolumna;

            for (int i = 0; i < tableLayoutPanel1.ColumnCount * tableLayoutPanel1.RowCount; i++)
            {
                wiersz = tableLayoutPanel1.Controls[i] as Label;

                for (int j = 0; j < tableLayoutPanel1.RowCount * tableLayoutPanel1.ColumnCount; j++)
                {
                    kolumna = tableLayoutPanel1.Controls[j] as Label;
                    if (i % 2 == 0)
                    {
                        wiersz.ForeColor = Color.White;
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            kolumna.ForeColor = Color.White;
                        }
                    }

                }
            }
        }
    }
}