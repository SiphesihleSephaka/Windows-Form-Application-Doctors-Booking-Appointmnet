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
    public partial class AdminViewFeedback : Form
    {
        public AdminViewFeedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void AdminViewFeedback_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
               
     
            string Path = (@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\FeedBack\FeeBack.txt");
            StreamReader stream = new StreamReader(Path);
            string filedata = stream.ReadToEnd();
            richTextBox1.Text = filedata.ToString();
            stream.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ADL = new Form11();
            ADL.ShowDialog();
        }
    }
}
