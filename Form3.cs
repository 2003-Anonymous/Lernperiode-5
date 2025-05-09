using LP_4;
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
        private Form1 parent;
        public Form3(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Joshua";
            int password = 1234;
            if(txtBox_username.Text == username && txtBox_password.Text == "1234")
            {
                new Form2(parent).Show();
                this.Hide();
            }
        }
    }
}
