using Newtonsoft.Json;
using Serializacja4.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializacja4
{
    public partial class Form1 : Form
    {
        BindingList<FirstClass> _list = new BindingList<FirstClass>();

        public string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");

        public Form1()
        {
            InitializeComponent();

            CreateData();

            GetData();

            dataGridView1.DataSource = _list;
        }

        private void CreateData()
        {

            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
            }
        }

        private void GetData()
        {
            var json = File.ReadAllText(_filePath);
            _list = JsonConvert.DeserializeObject<BindingList<FirstClass>>(json);

            if (_list == null || !_list.Any())
            {
                _list = new BindingList<FirstClass>();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateRecord();

            SaveData();

            ClearFields();
        }
        private void CreateRecord()
        {
            var newObject = new FirstClass()
            {
                Tytul = tbBook.Text,
                Osoba = tbPerson.Text,
            };
            _list.Add(newObject);
        }

        private void SaveData()
        {
            var json = JsonConvert.SerializeObject(_list);
            File.WriteAllText(_filePath, json);
        }

        private void ClearFields()
        {
            tbBook.Text = "";
            tbPerson.Text = "";
        }

    }
}
