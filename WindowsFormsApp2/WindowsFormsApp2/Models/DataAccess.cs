using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2.Models
{
    public class DataAccess
    {
        public static void CreateFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SaveData(string filePath, BindingList<ContractorInformation> list)
        {
            try
            {
                var json = JsonConvert.SerializeObject(list);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetData(string filePath, BindingList<ContractorInformation> list)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    list.Clear();

                    if (!string.IsNullOrEmpty(json))
                    {
                        var contractors = JsonConvert.DeserializeObject<BindingList<ContractorInformation>>(json);
                        foreach (var contractor in contractors)
                        {
                            list.Add(contractor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void SaveIdCounterToFile(string idNumber)
        {
            try
            {
                if (!File.Exists(idNumber))
                {
                    File.Create(idNumber).Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static int ReadIdCounterFromFile(string idNumber)
        {
            try
            {
                if (!File.Exists(idNumber))
                {
                    File.Create(idNumber).Close();
                    return 1;
                }

                string idCounterText = File.ReadAllText(idNumber);

                if (int.TryParse(idCounterText, out int counter))
                {
                    return counter;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 1;
            }
        }
    }
}