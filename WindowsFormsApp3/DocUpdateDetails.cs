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
    public partial class Form10 : Form
    {
        Registration_dLogin rr = new Registration_dLogin();
        public Form10()
        {
            InitializeComponent();
        }

        private void DocUpdateDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] info = rr.LoggedDoc().Split(',');
            string N, S, G, ID, PN, EM, HA, Cat, City;
            N = info[0];
            S = info[1];
            ID = info[2];
            G = info[3];
            PN = info[4];
            EM = info[5];
            HA = info[6];
            Cat = info[7];
            City = info[8];

            try
            {
                StreamWriter writer = new StreamWriter($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\Doc&AdminReg\{EM}.txt");


                using (writer)
                {
                    if (txtName.Text != "")
                    {
                        N = txtName.Text;
                    }

                    if (txtSurname.Text != "")
                    {
                        S = txtSurname.Text;
                    }

                    if (txtIdnum.Text != "")
                    {
                        ID = txtIdnum.Text;
                    }

                    if (cmbGender.Text != "")
                    {
                        G = cmbGender.Text;
                    }
                    if (txtPhoneNum.Text != "")
                    {
                        PN = txtPhoneNum.Text;
                    }
                    if (txtEmail.Text != "")
                    {
                        EM = txtEmail.Text;
                    }

                    if (txtHA.Text != "")
                    {
                        HA = txtHA.Text;
                    }
                    if (cmbCategory.Text != "")
                    {
                        Cat = cmbCategory.Text;

                    }

                    if (txtCity.Text != "")
                    {
                        City = txtCity.Text;
                    }

                    writer.WriteLine($"Name \t{N}");
                    writer.WriteLine($"Surname \t{S}");
                    writer.WriteLine($"IDNumber \t{ID}");
                    writer.WriteLine($"Gender \t{""}");
                    writer.WriteLine($"PhoneNumber \t{PN}");
                    writer.WriteLine($"Email \t{EM}");
                    writer.WriteLine($"HomeAddress \t{HA}");
                    writer.WriteLine($"City \t{City}");
                    writer.WriteLine($"Password \t{"1234"}");
                    writer.WriteLine($"ConfirmPassword \t{"1234"}");

                    writer.Close();

                    MessageBox.Show("Details Updated!!!");


                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }



            string CurrDest = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\LOGGED\Doctor\{EM}.txt");
            //Assing path to a folder where a logged patient file is stored 
            File.Delete(CurrDest);
            string Mypath = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\Doc&AdminReg\{EM}.txt");
            //Assing path to where patient users files are stored 

            string dest = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\LOGGED\Doctor\{EM}.txt");
            //Assing path to a folder where a logged patient file is stored

            File.Copy(Mypath, dest, true);

            DoctorDetails dt = new DoctorDetails();
            this.Hide();
            dt.Visible = true;


            MessageBox.Show(G);

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
