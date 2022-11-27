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

namespace WindowsFormsApp3
{
    public partial class patientUpdateDetails : Form
    {
        Registration_dLogin rr = new Registration_dLogin();
        public patientUpdateDetails()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          



        }

        private void patientUpdateDetails_Load(object sender, EventArgs e)
        {

        }

        private void patientUpdateDetails_Load_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string[] Details = rr.LoggedPatient().Split(',');
            string name, surname, idNumber, gender, phonenum, email, HA, city;
            name = Details[0];
            surname = Details[1];
            idNumber = Details[2];
            gender = Details[3];
            phonenum = Details[4];
            email = Details[5];
            HA = Details[6];
            city = Details[7];


            try
            {
                StreamWriter writer = new StreamWriter($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\PatientRegistrationTextFile\{idNumber}.txt");


                using (writer)
                {
                    if (txtName.Text != "")
                    {
                        name = txtName.Text;
                    }

                    if (txtSurname.Text != "")
                    {
                        surname = txtSurname.Text;
                    }

                    if (txtIdnum.Text != "")
                    {
                        idNumber = txtIdnum.Text;
                    }

                    if (txtGender.Text != "")
                    {
                        gender = txtGender.Text;
                    }
                    if (txtPhoneNum.Text != "")
                    {
                        phonenum = txtPhoneNum.Text;
                    }
                    if (txtEmail.Text != "")
                    {
                        email = txtEmail.Text;
                    }

                    if (txtHA.Text != "")
                    {
                        HA = txtHA.Text;
                    }

                    if (txtCity.Text != "")
                    {
                        city = txtCity.Text;
                    }

                    writer.WriteLine($"Name \t{name}");
                    writer.WriteLine($"Surname \t{surname}");
                    writer.WriteLine($"IDNumber \t{idNumber}");
                    writer.WriteLine($"Gender \t{gender}");
                    writer.WriteLine($"PhoneNumber \t{phonenum}");
                    writer.WriteLine($"Email \t{email}");
                    writer.WriteLine($"HomeAddress \t{HA}");
                    writer.WriteLine($"City \t{city}");
                    writer.WriteLine($"Password \t{rr.Password()}");
                    writer.WriteLine($"ConfirmPassword \t{rr.Password()}");

                    writer.Close();

                    MessageBox.Show("Updated");


                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
            string CurrDest = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\LOGGED\Patients\{idNumber}.txt");
            //Assing path to a folder where a logged patient file is stored 
            File.Delete(CurrDest);
            string Mypath = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\PatientRegistrationTextFile\{idNumber}.txt");
            //Assing path to where patient users files are stored 

            string dest = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\LOGGED\Patients\{idNumber}.txt");
            //Assing path to a folder where a logged patient file is stored

            File.Copy(Mypath, dest, true);

            this.Hide();
            Form6 form = new Form6();
            form.Visible = true;



        }
    }
}