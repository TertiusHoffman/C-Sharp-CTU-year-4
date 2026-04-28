using System;
using System.Windows.Forms;

namespace FavouriteLanguagesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRemove.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lang = txtLanguage.Text.Trim();

            if (string.IsNullOrEmpty(lang))
            {
                MessageBox.Show("Please enter a programming language");
                return;
            }

            foreach (var item in listBox1.Items)
            {
                if (item.ToString().Equals(lang, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Language already exists");
                    return;
                }
            }

            listBox1.Items.Add(lang);
            lblInfo.Text = $"Added '{lang}' at {DateTime.Now}";
            txtLanguage.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Select a language to remove");
                return;
            }

            string removed = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(listBox1.SelectedItem);
            lblInfo.Text = $"Removed '{removed}' at {DateTime.Now}";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = listBox1.SelectedItem != null;
        }

        private void txtLanguage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}