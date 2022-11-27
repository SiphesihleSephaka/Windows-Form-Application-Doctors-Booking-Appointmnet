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
    public partial class DoctorDetails : Form
    {
        Registration_dLogin rr = new Registration_dLogin();
        public DoctorDetails()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorPatientView DPV = new DoctorPatientView();
            DPV.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ADL = new Form1();
            ADL.ShowDialog();
        }

        private void DoctorDetails_Load(object sender, EventArgs e)
        {
           pnlD.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorBookings ADL = new DoctorBookings();
            ADL.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string info = rr.LoggedDoc();
            string name, surname, IdNumber, gender, CellNum, Email, HA, category, City;
            string[] details = rr.LoggedDoc().Split(',');

            name = details[0];
            surname = details[1];
            IdNumber = details[2];
            gender = details[3];
            CellNum = details[4];
            Email = details[5];
            HA = details[6];
            category = details[7];
            City = details[8];

            lblTakeName.Text = name;
            lblTakeSurname.Text = surname;
            lblTakeID.Text = IdNumber;
            lblTakePN.Text = CellNum;
            lblTakeEmail.Text = Email;
            lblTakeHA.Text = HA;
            lblTakeCategory.Text = category;
            lblTakeCity.Text = City;




            pnlD.Visible = true;
        }
    


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form = new Form10();
            form.Visible = true;
        }
    }
}
