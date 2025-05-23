using LP_4;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP_5
{
    public partial class Form3 : Form
    {
        public SqliteConnection connection;
        private Form1 parent;
        public Form3(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;

            string connectionString = "Data Source=..\\..\\..\\Towerdefense_Db.db";
            connection = new SqliteConnection(connectionString);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            string selectQuery = "SELECT * FROM Logins";
            SqliteCommand selectCmd = new SqliteCommand(selectQuery, connection);
            SqliteDataReader reader = selectCmd.ExecuteReader();

            while (reader.Read())
            {
                username = reader["username"].ToString();
                password = reader["password"].ToString();

                if (txtBox_username.Text == username && txtBox_password.Text == password)
                {
                    new Form2(parent, username, password).Show();
                    this.Hide();
                }
            }


        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            new Form4(this.parent).Show();
            this.Hide();
        }
    }
}
