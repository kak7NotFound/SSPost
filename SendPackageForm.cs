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
refreshData();
            
        }

        public void refreshData()
        {
            dataGridView1.Rows.Clear();
            using (var reader = Program.database.GetReader("select * from Items"))
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                        reader.GetValue(0),
                        reader.GetValue(1),
                        reader.GetValue(2),
                        reader.GetValue(5),
                        reader.GetValue(6)
                    });
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new SuccessForm().Show();
        }
        

        private void SendPackageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            open = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ChangeStoragePlaceForm(dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells, this).Show();
        }
    }
}