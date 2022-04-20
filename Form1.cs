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
            new GetPackageForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SendPackageForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new StorageForm().Show();
        }
    }
}