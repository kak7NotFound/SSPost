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
    }
}