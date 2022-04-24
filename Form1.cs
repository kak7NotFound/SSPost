using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSPost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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