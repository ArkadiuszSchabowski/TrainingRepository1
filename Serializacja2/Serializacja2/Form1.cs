using Serializacja2.Models;
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

namespace Serializacja2
{

    public partial class Form1 : Form
    {
        BindingList<SecondClass> _lista = new BindingList<SecondClass>();

        private string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");
        public Form1()
        {
            InitializeComponent();

            CreateDataFile();

            GetData();

            dataGridView1.DataSource = _lista;
        }

        private void GetData()
        {
            var json = File.ReadAllText(_filePath);

            _lista = JsonConvert.DeserializeObject<BindingList<SecondClass>>(json);

            if (_lista == null || !_lista.Any())
                _lista = new BindingList<SecondClass>();
        }

        private void SaveData()
        {
            var json = JsonConvert.SerializeObject(_lista);

            File.WriteAllText(_filePath, json);
        }

        private void CreateDataFile()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Dispose();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook();

            SaveData();

            ClearFields();
        }

        private void AddBook()
        {
            var secondClass = new SecondClass()
            {
                Title = textBox1.Text,
                Person = textBox2.Text,
            };
            _lista.Add(secondClass);
        }

        private void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
