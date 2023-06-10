using Serializacja3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Serializacja3
{
    public partial class Form1 : Form
    {
        BindingList<PropertyClass> _lista = new BindingList<PropertyClass>();
        public string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");
        public Form1()
        {
            InitializeComponent();

            CreateData();

            GetData();

            dataGridView1.DataSource = _lista;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook();

            SaveData();

            ClearFields();
        }

        private void AddBook()
        {
            var propertyClass = new PropertyClass()
            {
                Book = tbBook.Text,
                Person = tbPerson.Text,
            };

            _lista.Add(propertyClass);
        }
        private void GetData()
        {
            var json = File.ReadAllText(_filePath);
            _lista = JsonConvert.DeserializeObject<BindingList<PropertyClass>>(json);

            if (_lista == null || !_lista.Any())
            {
                _lista = new BindingList<PropertyClass>();
            }
        }

        private void CreateData()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
            }

        }

        private void SaveData()
        {
            var json = JsonConvert.SerializeObject(_lista);
            File.WriteAllText(_filePath, json);
        }

        private void ClearFields()
        {
            tbBook.Text = "";
            tbPerson.Text = "";
        }
    }
}
