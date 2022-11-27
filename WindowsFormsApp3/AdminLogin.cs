using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string E, P;
            E = "Admin@1";
            P = "Coderz";

            bool EM = false, PS = false;


            if (txtEmail.Text == E)
            {
                EM = true;
            }
            else
            {
                MessageBox.Show("Incorect Email");
            }

            if (txtPassword.Text == P)
            {
                PS = true;
            }
            else if ((txtPassword.Text != P) & (txtEmail.Text ==E))
            {
                MessageBox.Show("Incorect password");
            }

            if (EM && PS)
            {
                MessageBox.Show("Access granted");
                this.Hide();
                AdminPatientDetails AD = new AdminPatientDetails();
                AD.ShowDialog();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
