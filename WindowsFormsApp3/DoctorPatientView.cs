using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp3
{
    public partial class DoctorPatientView : Form
    {
        Registration_dLogin rr = new Registration_dLogin();
        DataTable dT = new DataTable();
        public DoctorPatientView()
        {
            InitializeComponent();
            dT.Columns.Add("Name", Type.GetType("System.String"));
            dT.Columns.Add("Surname", Type.GetType("System.String"));
            dT.Columns.Add("ID Number", Type.GetType("System.String"));
            dT.Columns.Add("Gender", Type.GetType("System.String"));
            dT.Columns.Add("Cellphone Number", Type.GetType("System.String"));
            dT.Columns.Add("Email", Type.GetType("System.String"));
            dT.Columns.Add("Home Adress", Type.GetType("System.String"));
            dT.Columns.Add("City", Type.GetType("System.String"));

            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dataGridView1.DataSource = dT;
        }

        private void AdminPatientDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rr.DocLogout();

            this.Hide();
            Form1 ADL = new Form1();
            ADL.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDetails DD = new DoctorDetails();
            DD.ShowDialog();
        }

        private void DoctorPatientView_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorBookings ADL = new DoctorBookings();
            ADL.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rr.idnumber = txtSearchID.Text;
            string[] details = rr.SearchPatient().Split(',');
            dT.Rows.Add(details);


        }

        private void txtIDNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
