using System;
using System.Threading;
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
            refreshDatagrid();
        }

        public void refreshDatagrid()
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
                        reader.GetValue(3),
                        reader.GetValue(4),
                        reader.GetValue(5),
                        reader.GetValue(6)
                    });
                }
            }
        }

        private void StorageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            open = false;
        }
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var fromWhom = dataGridView1.CurrentRow.Cells[0].Value;
                var toWhom = dataGridView1.CurrentRow.Cells[1].Value;
                var weight = dataGridView1.CurrentRow.Cells[2].Value;
                var toAddress = dataGridView1.CurrentRow.Cells[5].Value;
                
                Program.database.ExecuteNonQuery($"delete from Items where fromWhom = '{fromWhom}' and toWhom = '{toWhom}' and weight = {weight} and toAddress = '{toAddress}'");
                refreshDatagrid();
            }
            catch (Exception exception)
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var a = dataGridView1.CurrentRow.Cells;
                new StorageItemChangerForm(a[0].Value.ToString(), a[1].Value.ToString(), Int32.Parse(a[2].Value.ToString()), a[3].Value.ToString(), a[4].Value.ToString(), a[5].Value.ToString(),a[6].Value.ToString(), a, this).Show();

            }
            catch (Exception exception)
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SuccessForm().Show();
        }
    }
}