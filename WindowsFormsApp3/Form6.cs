using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        Registration_dLogin rr = new Registration_dLogin();
        public Form6()
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

        private void Form6_Load(object sender, EventArgs e)
        {
            pnlOutput.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            string name, surname, IdNumber, gender, CellNum, Email, HA, City;
            string[] details = rr.LoggedPatient().Split(',');

            name = details[0];
            surname = details[1];
            IdNumber = details[2];
            gender = details[3];
            CellNum = details[4];
            Email = details[5];
            HA = details[6];
            City = details[7];

            lblTakeName.Text = name;
            lblTakeSurname.Text = surname;
            lblTakeID.Text = IdNumber;
            lblTakeGender.Text = gender;
            lblTakePN.Text = CellNum;
            lblTakeEmail.Text = Email;
            lblTakeHA.Text = HA;
            lblTakeCity.Text = City;







            pnlOutput.Visible = true;


        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
            form.ShowDialog();
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
            rr.PatientLogout();
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

  
        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void lblPersonalInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblNameGoesHere_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblOutPut_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnterID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientUpdateDetails form = new patientUpdateDetails();
            form.ShowDialog();
        }
    }
}
