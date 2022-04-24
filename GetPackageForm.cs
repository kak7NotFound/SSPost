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
            updateBoxesData();
        }

        private void updateBoxesData()
        {
            using (var reader =
                   Program.database.GetReader($"select name from Customers where name like '{comboBox4.Text}%'"))
            {
                while (reader.Read())
                {
                    comboBox4.Items.AddRange(new object[] {reader.GetValue(0),});
                    comboBox3.Items.AddRange(new object[] {reader.GetValue(0),});
                }
            }
            
            using (var reader =
                   Program.database.GetReader($"select storagePlace from Items"))
            {
                while (reader.Read()) {comboBox5.Items.AddRange(new object[] {reader.GetValue(0),});}
            }
            
            using (var reader =
                   Program.database.GetReader($"select address from Customers"))
            {
                while (reader.Read())
                {
                    comboBox1.Items.AddRange(new object[] {reader.GetValue(0),});
                    comboBox2.Items.AddRange(new object[] {reader.GetValue(0),});
                }
            }
            
        }
        

        private void GetPackageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            open = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.database.ExecuteNonQuery($"INSERT INTO Items (fromWhom, toWhom, weight, fragile, fromAddress, toAddress, storagePlace) values ('{comboBox4.Text}', '{comboBox3.Text}', {numericUpDown1.Value}, '{checkBox1.Checked}', '{comboBox1.Text}', '{comboBox2.Text}', '{comboBox5.Text}')");
            Program.database.ExecuteNonQuery($"REPLACE INTO Customers values ('{comboBox4.Text}', '{comboBox1.Text}')");
            Program.database.ExecuteNonQuery($"REPLACE INTO Customers values ('{comboBox3.Text}', '{comboBox2.Text}')");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            open = false;
        }
        
    }
}