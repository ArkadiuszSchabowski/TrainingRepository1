using System.Windows.Forms;

namespace LastClassProject
{
    internal class RandomGenerator
    {
        public void AddCountry(ListBox listBox, ComboBox comboBox)
        {
            listBox.Items.Add(comboBox.Text);
        }
    }
}