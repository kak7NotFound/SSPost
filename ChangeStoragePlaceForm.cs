using System.Windows.Forms;

namespace SSPost
{
    public partial class ChangeStoragePlaceForm : Form
    {
        public ChangeStoragePlaceForm(string name)
        {
            InitializeComponent();

            textBox1.Text = name;
        }
    }
}