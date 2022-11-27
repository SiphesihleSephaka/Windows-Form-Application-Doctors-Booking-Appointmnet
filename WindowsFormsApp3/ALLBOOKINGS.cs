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
        DataTable bookings = new DataTable("Bookings");
        public DoctorBookings()
        {
            InitializeComponent();
        }

        private void DoctorBookings_Load(object sender, EventArgs e)
        {
            bookings.Columns.Add("File Number", Type.GetType("System.String"));
            bookings.Columns.Add("Category", Type.GetType("System.String"));
            bookings.Columns.Add("Doctor", Type.GetType("System.String"));
            bookings.Columns.Add("Date", Type.GetType("System.String"));
            bookings.Columns.Add("Time", Type.GetType("System.String"));
            dataGridView1.DataSource = bookings;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            try
            {
                string path = (@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\ScheduleBookings");

                string[] fileEntries = Directory.GetFiles(path);

                foreach (string fileName in fileEntries)
                {
                    string fileNumber, Category, Doctor, Date, time;

                    List<string> details = new List<string>();

                    string fileDirectory = fileName;
                    using (StreamReader reader = new StreamReader(fileDirectory))
                    {
                        string line = reader.ReadLine();

                        while (line != null)
                        {

                            string[] lineArray = new string[2];
                            lineArray = line.Split(':');
                            details.Add(lineArray[1]);
                            line = reader.ReadLine();
                        }
                    }


                    string[] variables = details.ToArray();

                    fileNumber = variables[0];
                    Category = variables[1];
                    Doctor = variables[2];
                    Date = variables[3];
                    time = variables[4];

                    string[] mDateTime = new string[2];
                    mDateTime = Date.Split(' ');
                    Date = mDateTime[0];



                    bookings.Rows.Add(fileNumber, Category, Doctor, Date, time);



                }
            }


            catch (Exception)
            {
                MessageBox.Show("Exception");


            }
        }

        private void btnPastBookings_Click(object sender, EventArgs e)
        {
            string path = (@"C: \Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\\ScheduleBookings\\");


            string[] fileEntries = Directory.GetFiles(path);



            foreach (string fileName in fileEntries)
            {
                string fileNumber, Category, Doctor, Date, time;


                List<string> details = new List<string>();

                string fileDirectory = fileName;
                using (StreamReader reader = new StreamReader(fileDirectory))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {

                        string[] lineArray = new string[2];

                        lineArray = line.Split(':');
                        details.Add(lineArray[1]);
                        line = reader.ReadLine();

                    }
                }


                string[] variables = details.ToArray();

                fileNumber = variables[0];
                Category = variables[1];
                Doctor = variables[2];
                Date = variables[3];
                time = variables[4];


                DateTime todaysDate = DateTime.Today;
                DateTime AppointmentDate = Convert.ToDateTime(Date);
                int res = DateTime.Compare(AppointmentDate, todaysDate);
                if (res < 0)

                {
                    bookings.Rows.Add(fileNumber, Category, Doctor, Date, time);

                }


            }
        }

        private void btnActiveBookings_Click(object sender, EventArgs e)
        {
            string path = (@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\\ScheduleBookings\\");


            string[] fileEntries = Directory.GetFiles(path);

            foreach (string fileName in fileEntries)
            {
                string fileNumber, Category, Doctor, Date, time;


                List<string> details = new List<string>();

                string fileDirectory = fileName;
                using (StreamReader reader = new StreamReader(fileDirectory))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {

                        string[] lineArray = new string[2];

                        lineArray = line.Split(':');
                        details.Add(lineArray[1]);
                        line = reader.ReadLine();

                    }
                }


                string[] variables = details.ToArray();

                fileNumber = variables[0];
                Category = variables[1];
                Doctor = variables[2];
                Date = variables[3];
                time = variables[4];


                DateTime todaysDate = DateTime.Today;
                DateTime AppointmentDate = Convert.ToDateTime(Date);
                int res = DateTime.Compare(AppointmentDate, todaysDate);
                if (res >= 0)

                {
                    bookings.Rows.Add(fileNumber, Category, Doctor, Date, time);

                }

            }
        }
    }
}
