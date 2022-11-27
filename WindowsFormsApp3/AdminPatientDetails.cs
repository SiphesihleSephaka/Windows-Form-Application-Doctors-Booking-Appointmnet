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

namespace WindowsFormsApp3
{
    public partial class AdminPatientDetails : Form
    {
        Registration_dLogin rr = new Registration_dLogin();
        DataTable detailsT = new DataTable();
        public AdminPatientDetails()
        {
            InitializeComponent();
            detailsT.Columns.Add("Name", Type.GetType("System.String"));
            detailsT.Columns.Add("Surname", Type.GetType("System.String"));
            detailsT.Columns.Add("ID Number", Type.GetType("System.String"));
            detailsT.Columns.Add("Gender", Type.GetType("System.String"));
            detailsT.Columns.Add("Cellphone Number", Type.GetType("System.String"));
            detailsT.Columns.Add("Email", Type.GetType("System.String"));
            detailsT.Columns.Add("Home Adress", Type.GetType("System.String"));
            detailsT.Columns.Add("City", Type.GetType("System.String"));

            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dataGridView1.DataSource = detailsT;
        }

        private void AdminPatientDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ADL = new Form1();
            ADL.ShowDialog();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string[] details = rr.AdminViewPatients();
            if (details.Length > 0)
            {
                for (int i = 0; i < details.Length; i++)
                {
                    string[] populate = details[i].Split(',');
                    detailsT.Rows.Add(populate);
                }
            }
            else
            {
                MessageBox.Show("There are no Registerd patients");
            }



        }
        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewFeedback ADL = new AdminViewFeedback();
            ADL.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ADL = new Form11();
            ADL.ShowDialog();
        }
    }
}
