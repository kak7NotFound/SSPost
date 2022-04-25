using System;
using System.Windows.Forms;
using SSTattoo;

namespace SSPost
{
    public partial class ChangeStoragePlaceForm : Form
    {
        private DataGridViewCellCollection data;
        private SendPackageForm SPform;
        public ChangeStoragePlaceForm(string name, DataGridViewCellCollection data_, SendPackageForm form)
        {
            InitializeComponent();
            data = data_;
            SPform = form;
            textBox1.Text = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write(data[0].Value.ToString());
            Program.database.ExecuteNonQuery($"update Items set storagePlace = '{comboBox1.Text + comboBox2.Text}' where toAddress = '{data[3].Value.ToString()}' and fromWhom = '{data[0].Value.ToString()}'");
            SPform.refreshData();
        }
    }
}