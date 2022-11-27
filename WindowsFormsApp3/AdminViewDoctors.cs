using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form11 : Form
    {
        Registration_dLogin rr = new Registration_dLogin();
        DataTable dT = new DataTable();
        public Form11()
        {
            InitializeComponent();
            dT.Columns.Add("Name", Type.GetType("System.String"));
            dT.Columns.Add("Surname", Type.GetType("System.String"));
            dT.Columns.Add("ID Number", Type.GetType("System.String"));
            dT.Columns.Add("Gender", Type.GetType("System.String"));
            dT.Columns.Add("Cellphone Number", Type.GetType("System.String"));
            dT.Columns.Add("Email", Type.GetType("System.String"));
            dT.Columns.Add("Home Adress", Type.GetType("System.String"));
            dT.Columns.Add("Category", Type.GetType("System.String"));
            dT.Columns.Add("City", Type.GetType("System.String"));

            dataGridView1.DataSource = dT;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }


        private void Form11_Load_1(object sender, EventArgs e)
        {

        }

        private void btnViewDoc_Click_1(object sender, EventArgs e)
        {
            string[] Doctors = rr.AdminViewDoctors();
            if (Doctors.Length > 0)
            {
                for (int i = 0; i < Doctors.Length; i++)
                {
                    string[] populate = Doctors[i].Split(',');
                    dT.Rows.Add(populate);
                }

            }
            else
            {
                MessageBox.Show("There are no registerd Doctors");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPatientDetails AD = new AdminPatientDetails();
            AD.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewDocBooking DB = new AdminViewDocBooking();
            DB.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewFeedback ADL = new AdminViewFeedback();
            ADL.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ADL = new Form1();
            ADL.ShowDialog();
        }
    }
}