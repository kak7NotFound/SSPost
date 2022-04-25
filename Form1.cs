using System;
using System.Windows.Forms;
using SSTattoo;

namespace SSPost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.Write(DataBase.strExeFilePath.Substring(0, DataBase.strExeFilePath.Length-10));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetPackageForm.open) return;
            new GetPackageForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SendPackageForm.open) return;
            new SendPackageForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StorageForm.open) return;
            new StorageForm().Show();
        }
    }
}