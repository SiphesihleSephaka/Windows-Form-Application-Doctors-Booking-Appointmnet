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
    public partial class DocLogin : Form
    {

        public DocLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration_dLogin rr = new Registration_dLogin
            {
                idnumber = txtEmail.Text,
                password1 = txtPassword.Text,
            };

            if (rr.DocLoginTxtFiles() == "Access granted!")
            {
                this.Hide();
                DoctorBookings ADL = new DoctorBookings();
                ADL.ShowDialog();

            }
            MessageBox.Show(rr.DocLoginTxtFiles());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DocLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
