using Microsoft.Data.Sqlite;
using System.Windows.Forms.Design;

namespace LP_4
{
    public partial class Form1 : Form
    {
        public SqliteConnection connection;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Data Sourcr="

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
            this.Hide();
        }

        private void start_btn_Click_1(object sender, EventArgs e)
        {
            new LP_5.Form3(this).Show();
            this.Hide();
        }
    }
}
