using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Menjacnica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string username;
        string pass;

        string userDef = "Stefan";
        string passDef = "2007";

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text == username && txtPass.Text == pass)
            {
                Form1 f = new Form1();

                f.Show();
            }

            else if (txtId.Text == userDef && txtPass.Text == passDef)
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Email or password is incorrect!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = txtId.Text;
            pass = txtPass.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            username = "";
            pass = "";
            txtId.Text = "";
            txtPass.Text = "";
        }
    }
}
