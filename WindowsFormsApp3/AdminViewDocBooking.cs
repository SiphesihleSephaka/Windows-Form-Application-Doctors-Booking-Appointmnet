using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;



namespace WindowsFormsApp3
{
    public partial class AdminViewDocBooking : Form
    {
        DataTable bookings = new DataTable("Bookings");
        Registration_dLogin rr = new Registration_dLogin();

        public AdminViewDocBooking()
        {
            InitializeComponent();
            bookings.Columns.Add("File Number", Type.GetType("System.String"));
            bookings.Columns.Add("Category", Type.GetType("System.String"));
            bookings.Columns.Add("Doctor", Type.GetType("System.String"));
            bookings.Columns.Add("Date", Type.GetType("System.String"));
            bookings.Columns.Add("Time", Type.GetType("System.String"));
            bookings.Columns.Add("Name", Type.GetType("System.String"));
            dataGridView2.DataSource = bookings;
        }

        private void AdminViewDocBooking_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ADL = new Form1();
            ADL.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPatientDetails AD = new AdminPatientDetails();
            AD.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegisterDoctor RD = new AdminRegisterDoctor();
            RD.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewDocBooking DB = new AdminViewDocBooking();
            DB.ShowDialog();
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminViewDocBooking_Load_1(object sender, EventArgs e)
        {

        }

        private void btnActiveBookings_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPastBookings_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewFeedback ADL = new AdminViewFeedback();
            ADL.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string[] files = rr.AdminViewBookings();
            for (int i = 0; i < files.Length; i++)
            {
                bookings.Rows.Add(files[i].Split(','));
            }


            string path = (@"");

        }

        private void btnActive_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPast_Click(object sender, EventArgs e)
        {
           


            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ADL = new Form1();
            ADL.ShowDialog();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegisterDoctor RD = new AdminRegisterDoctor();
            RD.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPatientDetails AD = new AdminPatientDetails();
            AD.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewFeedback ADL = new AdminViewFeedback();
            ADL.ShowDialog();
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ADL = new Form11();
            ADL.ShowDialog();
        }
    }
}
