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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        public void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration_dLogin RL = new Registration_dLogin
            {
                idnumber = txtIDnumberChk.Text,
                password1 = txtPasswordChk.Text,
            };

            if (RL.LoginTxtFiles() == "Access granted!")
            {
                this.Close();
                Form6 form6 = new Form6();
                form6.Visible = true;
             
            }

            MessageBox.Show(RL.LoginTxtFiles());

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblNotyetamember_Click(object sender, EventArgs e)
        {

        }
    }
}
