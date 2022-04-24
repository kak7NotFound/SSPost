using System;
using System.Windows.Forms;

namespace SSPost
{
    public partial class StorageForm : Form
    {
        public static bool open;

        public StorageForm()
        {
            open = true;
            InitializeComponent();
        }

        private void StorageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            open = false;
        }
    }
}