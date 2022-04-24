using System;
using System.Windows.Forms;

namespace SSPost
{
    public partial class SendPackageForm : Form
    {
        public static bool open = false;
        public SendPackageForm()
        {
            open = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        

        private void SendPackageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            open = false;
        }
    }
}