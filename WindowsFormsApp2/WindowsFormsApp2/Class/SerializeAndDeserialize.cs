using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.Class
{
    public static class SerializeAndDeserialize
    {
        public static void SaveData()
        {
            try
            {
                var json = JsonConvert.SerializeObject(_list);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetData()
        {
            try
            {
                var json = File.ReadAllText(_filePath);
                _list = JsonConvert.DeserializeObject<BindingList<ContractorInformation>>(json);

                if (json == null || !json.Any())
                {
                    _list = new BindingList<ContractorInformation>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CreateFile()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    File.Create(_filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
