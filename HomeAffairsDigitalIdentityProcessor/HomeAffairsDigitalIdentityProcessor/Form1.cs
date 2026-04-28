using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ✅ FORM LOAD (already correct)
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("South African");
            comboBox1.Items.Add("Permanent Resident");
            comboBox1.Items.Add("Visitor");

            comboBox1.SelectedIndex = 0;
        }

        // ✅ VALIDATE ID BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter name and ID number");
                return;
            }

            CitizenProfile profile = new CitizenProfile(
                textBox1.Text,
                textBox2.Text,
                comboBox1.Text
            );

            string result = profile.ValidateID();

            // Show short result
            textBox3.Text = result;
        }

        // ✅ GENERATE PROFILE BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            CitizenProfile profile = new CitizenProfile(
                textBox1.Text,
                textBox2.Text,
                comboBox1.Text
            );

            string validation = profile.ValidateID();

            textBox3.Text =
                "---- DIGITAL CITIZEN SUMMARY ----\r\n" +
                "Name: " + profile.FullName + "\r\n" +
                "ID Number: " + profile.IDNumber + "\r\n" +
                "Age: " + profile.Age + "\r\n" +
                "Citizenship: " + profile.CitizenshipStatus + "\r\n" +
                "Validation: " + validation + "\r\n" +
                "Processed at: Home Affairs Digital Desk\r\n" +
                "Timestamp: " + DateTime.Now;
        }

        // 🔹 These are unused — you can keep or delete them
        private void label3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}