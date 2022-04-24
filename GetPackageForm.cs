using System;
using System.Windows.Forms;

namespace SSPost
{
    public partial class GetPackageForm : Form
    {
        public static bool open = false;

        public GetPackageForm()
        {
            open = true;
            InitializeComponent();
        }

        private void GetPackageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            open = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Program.database.ExecuteNonQuery(
                $"INSERT INTO Items (fromWhom, toWhom, weight, fragile, fromAddress, toAddress, storagePlace) values ('{comboBox4.Text}', '{comboBox3.Text}', {numericUpDown1.Value}, '{checkBox1.Checked}', '{comboBox1.Text}', '{comboBox2.Text}', '{comboBox5.Text}')");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            open = false;
        }

        private void comboBox4_TextUpdate(object sender, EventArgs e)
        {
        }
    }
}