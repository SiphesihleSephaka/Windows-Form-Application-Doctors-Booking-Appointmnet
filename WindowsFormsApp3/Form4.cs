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
using System.Security.Cryptography;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        Registration_dLogin dd = new Registration_dLogin();

        public Form4()
        {
            InitializeComponent();
            string[] names = dd.InitializeDoc();
            for (int i = 0; i < names.Length; i++)
            {
                cmbChooseDoctor.Items.Add("Dr " + names[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            int fileNumber;
            string Category, Doctor, Date, time;







            Category = cmbCategory.Text;
            Doctor = cmbChooseDoctor.Text;
            Date = dtpDate.Value.ToString();
            time = comboBox1.Text;

            string[] d = new string[2];
            d = Date.Split(' ');
            Date = d[0];

            bool found = false;

            string[] bookings = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\ScheduleBookings");
            fileNumber = bookings.Length + 1;
            for (int i = 0; i < bookings.Length; i++)
            {
                string FN, C, DR, DT, T;
                List<string> Info = new List<string>();
                StreamReader reader = new StreamReader(bookings[i]);
                string line = reader.ReadLine();
                string[] lineArray = new string[2];
                while (line != null)
                {
                    lineArray = line.Split('\t');
                    Info.Add(lineArray[1]);
                    line = reader.ReadLine();
                }

                FN = Info[0];
                C = Info[1];
                DR = Info[2];
                DT = Info[3];
                T = Info[4];

                if ((DR == Doctor) && (DT == Date) && (T == time))
                {
                    found = true;
                    break;
                }

                while (Convert.ToInt32(FN) == fileNumber)
                {
                    fileNumber += 2;
                }

            }




            string filePath = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\ScheduleBookings\{fileNumber}.txt");

            if (found)
            {
                MessageBox.Show("Time slot already booked");
            }
            else
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine($"File number\t{fileNumber}");
                        writer.WriteLine($"Category\t{Category}");
                        writer.WriteLine($"Doctor\t{Doctor}");
                        writer.WriteLine($"Date\t{Date}");
                        writer.WriteLine($"Time\t{time}");
                        writer.WriteLine($"Name\t{dd.LoggedPName()}");
                    }


                    MessageBox.Show($"Booking Successful \nYour file number is {fileNumber}");

                    this.Hide();
                    Form5 form5 = new Form5();
                    form5.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please remake booking" + ex);
                }

            }




        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
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
            dd.PatientLogout();
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
