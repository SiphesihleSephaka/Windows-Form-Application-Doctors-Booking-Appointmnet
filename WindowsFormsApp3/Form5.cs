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
    public partial class Form5 : Form
    {
        Registration_dLogin dd = new Registration_dLogin();
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.ShowDialog();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Close();
            Form2 form2 = new Form2();
            form2.Close();
            Form3 form3 = new Form3();
            form3.Close();
            Form4 form4 = new Form4();
            form4.Close();
            Form5 form5 = new Form5();
            form5.Close();
            Form6 form6 = new Form6();
            form6.Close();

            this.Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form = new Form7();
            form.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            dd.PatientLogout();
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                string fileNumber, Category, Doctor, Date, time;

                string[] variables = dd.ViewBooking().Split(',');

                fileNumber = variables[0];
                Category = variables[1];
                Doctor = variables[2];
                Date = variables[3];
                time = variables[4];

                lblFileNumberGoesHere.Text = fileNumber;
                lblCategoryGoesHere.Text = Category;
                lblDoctorNameGoesHere.Text = Doctor;
                lblDateGoesHere.Text = Date;
                lblTime.Text = time;
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);

            }
        }

        private void txtFileNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
