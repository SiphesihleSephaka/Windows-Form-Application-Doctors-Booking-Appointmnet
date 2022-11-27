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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class AdminRegisterDoctor : Form
    {
        public AdminRegisterDoctor()
        {
            InitializeComponent();
        }

        private void AdminRegisterDoctor_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
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
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewDocBooking DB = new AdminViewDocBooking();
            DB.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
            string Name, Surname, IDn, Tel, Email, Home, Category, Password;
            Name = txtName.Text;
            Surname = txtSurname.Text;
            IDn = txtIDnumber.Text;
            Tel = txtMobileNumber.Text;
            Email = txtEmail.Text;
            Home = txtHomeAdress.Text;
            Category = comboBox2.Text;
            Password = txtPassword.Text;

            string filePath = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\Doc&AdminReg\{Email}.txt");

            try
            {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine($"Name\t{Name}");
                        writer.WriteLine($"Surname\t{Surname}");
                        writer.WriteLine($"ID Number\t{IDn}");
                        writer.WriteLine($"Gender\t{comboBox1.Text}");
                        writer.WriteLine($"PhoneNumber\t{Tel}");
                        writer.WriteLine($"Email\t{Email}");
                        writer.WriteLine($"HomeAddress\t{Home}");
                        writer.WriteLine($"Category\t{comboBox2.Text}");
                        writer.WriteLine($"Password\t{Password}");
                    }
                    MessageBox.Show("Details Successful Saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!! Details not saved");
            }
            this.Hide();
            AdminPatientDetails AD = new AdminPatientDetails();
            AD.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ADL = new Form11();
            ADL.ShowDialog();
        }
    }
}
