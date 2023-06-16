using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.Models;
using System.Drawing;
using WindowsFormsApp2.Class;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int _barCode;
        int countContractors = 0;
        BindingList<ContractorInformation> _list = new BindingList<ContractorInformation>();
        string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");

        public Form1()
        {
            InitializeComponent();

            SetWindowsProperty.StrechTheWindowsToFullScreen();

            SerializeAndDeserialize.CreateFile();

            SerializeAndDeserialize.GetData();

            LabelCountContractors.CountContractors();

            dataGridView1.DataSource = _list;

            DataFromGridView.ChangeFontInDataGridViev();
            DataFromGridView.ChangeColumnWidths();
            DataFromGridView.ChangeColumnHeaders();
            DataFromGridView.HideBarCodeColumnWithDataGridView();
        }
    }
}
        