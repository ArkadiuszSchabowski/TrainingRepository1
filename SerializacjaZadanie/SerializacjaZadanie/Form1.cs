using SerializacjaZadanie.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SerializacjaZadanie
{
    public partial class Form1 : Form
    {
        BindingList<newClass> _list = new BindingList<newClass>();
        string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.newClass");
        public Form1()
        {
            InitializeComponent();

            CreatePath();

            GetData();

            dataGridView1.DataSource = _list;
        }

        private void CreatePath()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
            }
        }

        private void GetData()
        {
            var json = File.ReadAllText(_filePath);
            _list = JsonConvert.DeserializeObject<BindingList<newClass>>(json);

            if (json == null || !json.Any())
            {
                _list = new BindingList<newClass>();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateRecord();

            SaveData();

            ClearFields();
        }

        private void SaveData()
        {
            var json = JsonConvert.SerializeObject(_list);
            File.WriteAllText(_filePath, json);
        }

        private void ClearFields()
        {
            tbName.Text = "";
            tbPerson.Text = "";
        }

        private void CreateRecord()
        {
            var obiekt = new newClass()
            {
                Osoba = tbPerson.Text,
                Ksiazka = tbName.Text,
            };
            _list.Add(obiekt);
        }
    }
}
