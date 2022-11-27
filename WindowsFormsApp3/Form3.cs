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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            cmbGender.Items.Add("Rather not say");
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            {
                    this.Hide();
                    Form6 form6 = new Form6();
                    form6.ShowDialog();
                
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            Registration_dLogin textfiles = new Registration_dLogin
            {
                name = txtName.Text,
                surname = txtSurname.Text,
                idnumber = txtIDnumber.Text,
                gender = cmbGender.Text,
                cellnumber = txtCell.Text,
                email = txtEmail.Text,
                homeaddress = txtAddress.Text,
                city = txtCity.Text,
                password1 = txtPassword.Text,
                password2 = txtPasswordConfirm.Text
            };

            int IDlength = txtIDnumber.Text.Length;
            int Cellength = txtCell.Text.Length;

            if (textfiles.password1 != textfiles.password2)
                {
                    MessageBox.Show("Passwords do not match");
                }
                else if ((textfiles.name == "") || (textfiles.surname == "") || (textfiles.idnumber == "") || (textfiles.gender == "") || (textfiles.cellnumber == "") || (textfiles.email == "") || (textfiles.homeaddress == "") || (textfiles.city == "") || (textfiles.password1 == "")|| (textfiles.password2 == ""))
                {
                    MessageBox.Show("Please enter all requied details");
                }

                else if ((IDlength !=13) & (IDlength != 0))
           
            {
                MessageBox.Show("Please make sure that your ID number has 13 digits");
            }
            
                else if ((Cellength != 10) & (Cellength != 0))
            {
                MessageBox.Show("Please make sure that your Cellphone number has 10 digits");
            }

            else if ((textfiles.name != "") || (textfiles.surname != "") || (textfiles.idnumber != "") || (textfiles.gender != "") || (textfiles.cellnumber != "") || (textfiles.email != "") || (textfiles.homeaddress != "") || (textfiles.city != "") || (textfiles.password1 != "") || (textfiles.password2 != ""))
            {
                MessageBox.Show(textfiles.SaveTxtFiles());
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
               
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

            
         

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
