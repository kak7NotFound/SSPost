using System;
using System.Windows.Forms;

namespace SSPost
{
    public partial class StorageItemChangerForm : Form
    {
        public DataGridViewCellCollection data;
        public StorageForm storageform;
        public StorageItemChangerForm(string fromWhom, string toWhom, int weight, string fragile, string fromAddress, string toAddress, string storagePlace, DataGridViewCellCollection a, StorageForm form)
        {
            InitializeComponent();
            storageform = form;
            data = a;
            setFields(fromWhom, toWhom, weight, fragile, fromAddress, toAddress, storagePlace);
        }

        public void setFields(string fromWhom, string toWhom, int weight, string fragile, string fromAddress, string toAddress, string storagePlace)
        {
            textBox1.Text = fromWhom;
            textBox2.Text = toWhom;
            numericUpDown1.Value = weight;
            checkBox1.Checked = Boolean.Parse(fragile);
            textBox5.Text = fromAddress;
            textBox6.Text = toAddress;
            textBox7.Text = storagePlace;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.database.ExecuteNonQuery($"delete from Items where toAddress = '{data[0].Value.ToString()}' and weight = {Int32.Parse(data[2].Value.ToString())}");
            Program.database.ExecuteNonQuery($"insert into Items (fromWhom, toWhom, weight, fragile, fromAddress, toAddress, storagePlace) VALUES ('{textBox1.Text}', '{textBox2.Text}', {numericUpDown1.Value}, '{checkBox1.Checked.ToString()}', '{textBox5.Text}', '{textBox6.Text}', '{textBox7.Text}')");
            storageform.refreshDatagrid();
        }
    }
}