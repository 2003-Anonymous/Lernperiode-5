using LP_4;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LP_5
{
    public partial class Form4 : Form
    {
        public SqliteConnection connection;
        public string username;
        public string password;
        private Form1 parent;
        public Form4(LP_4.Form1 parent)
        {
            
            string connectionString = "Data Source=..\\..\\..\\Towerdefense_Db.db";
            connection = new SqliteConnection(connectionString);
            connection.Open();
            this.parent = parent;
            InitializeComponent();
        }

        private void submitt_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Logins";
            SqliteCommand selectCmd = new SqliteCommand(selectQuery, connection);
            SqliteDataReader reader = selectCmd.ExecuteReader();

            bool exist = false;

            while (reader.Read())
            {
                username = reader["username"].ToString();
                
                exist = false;
                if (username_create.Text == username)
                {
                    exist = true;
                    break;
                }
                
            }

            reader.Close();

            if (!exist && password_create.Text != string.Empty && username_create.Text != string.Empty)
            {
                string writeQuery = $"INSERT INTO Logins (username, password) VALUES ('{username_create.Text}', '{password_create.Text}');";
                SqliteCommand writeCmd = new SqliteCommand(writeQuery, connection);
                writeCmd.ExecuteNonQuery();

                new LP_5.Form3(parent).Show();
                this.Hide();
            }
        }
    }
}
