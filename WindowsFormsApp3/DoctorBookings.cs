using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace WindowsFormsApp3
{
    public partial class DoctorBookings : Form
    {
        Registration_dLogin rr = new Registration_dLogin();
        DataTable bookings = new DataTable("Bookings");
        public DoctorBookings()
        {
            InitializeComponent();
            bookings.Columns.Add("File Number", Type.GetType("System.String"));
            bookings.Columns.Add("Category", Type.GetType("System.String"));
            bookings.Columns.Add("Doctor", Type.GetType("System.String"));
            bookings.Columns.Add("Date", Type.GetType("System.String"));
            bookings.Columns.Add("Time", Type.GetType("System.String"));
            bookings.Columns.Add("Name", Type.GetType("System.String"));
            dataGridView1.DataSource = bookings;

        }

        private void DoctorBookings_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rr.DocLogout();
            this.Hide();
            Form1 ADL = new Form1();
            ADL.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDocBookings_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDetails DD = new DoctorDetails();
            DD.ShowDialog();
        }

        private void btnSearchP_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorPatientView DPV = new DoctorPatientView();
            DPV.ShowDialog();
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            string fileNumber, Category, Doctor, Date, time;
            string[] variables = rr.ViewDBooking();
            if (variables.Length > 0)
            {
                for (int i = 0; i < variables.Length; i++)
                {

                    string[] info = new string[6];
                    info = variables[i].Split(',');

                    fileNumber = info[0];
                    Category = info[1];
                    Doctor = info[2];
                    Date = info[3];
                    time = info[4];
                    string name = info[5];

                    bookings.Rows.Add(fileNumber, Category, Doctor, Date, time, name);
                }
                btnViewBookings.Enabled = false;
            }





        }

       
    }
}
