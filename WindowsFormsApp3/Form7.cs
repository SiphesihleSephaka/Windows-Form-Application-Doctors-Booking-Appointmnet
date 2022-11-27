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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
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

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

        }

        

        private void btnDetails_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void btnFeedBack_Click_1(object sender, EventArgs e)
        {
        }

        private void pnlMakeBooking_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string comment = rtxtFeedback.Text;
                //string[] commentname = comment.Split(' ');
                string nameofcomment = "FeeBack";

                string path = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\FeedBack\{nameofcomment}.txt");

                string r = System.IO.File.ReadAllText(path) + "\n" + rtxtFeedback.Text;

                StreamWriter writer = new StreamWriter(path);

                using (writer)
                {
                    writer.Write($"{r}");
                }

                MessageBox.Show("FeedBack sent");
            }

            catch (Exception ex)
            {
                MessageBox.Show("There is an error occured" + ex);
            }

            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form = new Form7();
            form.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            btnBad.Font = new Font("Wingdings",20, FontStyle.Bold);
            btnBad.Text = "L";
            btnBad.BackColor = Color.Red;

            btnExcellent.Font = new Font("Arial Rounded", 8, FontStyle.Bold);
            btnExcellent.Text = "Excellent";
            btnExcellent.BackColor = Color.White;

            btnGood.Font = new Font("Arial Rounded", 8, FontStyle.Bold);
            btnGood.Text = "Good";
            btnGood.BackColor = Color.White;

        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            btnGood.Font = new Font("Wingdings", 20, FontStyle.Bold);
            btnGood.Text = "K";
            btnGood.BackColor = Color.Green;

            btnExcellent.Font = new Font("Arial Rounded", 8, FontStyle.Bold);
            btnExcellent.Text = "Excellent";
            btnExcellent.BackColor = Color.White;

            btnBad.Font = new Font("Arial Rounded", 8, FontStyle.Bold);
            btnBad.Text = "Not Good";
            btnBad.BackColor = Color.White;
        }

        private void btnExcellent_Click(object sender, EventArgs e)
        {
            btnExcellent.Font = new Font("Wingdings", 20,FontStyle.Bold);
            btnExcellent.Text = "J";
            btnExcellent.BackColor = Color.Yellow;

            btnGood.Font = new Font("Arial Rounded", 8, FontStyle.Bold);
            btnGood.Text = "Good";
            btnGood.BackColor = Color.White;

            btnBad.Font = new Font("Arial Rounded", 8, FontStyle.Bold);
            btnBad.Text = "Not Good";
            btnBad.BackColor = Color.White;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
