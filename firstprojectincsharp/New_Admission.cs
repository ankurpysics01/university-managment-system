using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstprojectincsharp
{
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            string mname = txtMotherName.Text;
            string gender = "";
            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
            {
                gender= radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            string dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMoblie.Text);
            String email = txtEmailID.Text;
            string semester = txtSemester.Text;
            string progam = txtProgramming.Text;
            string sname = txtSchoolName.Text;
            string duration = txtDuration.Text;
            string add =txtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-9UK7VOIA\\SQLEXPRESS; database =mycollege;integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "insert into NewAdmission (fname,mname,gender,dob,mobile,email,semester,progam,sname,duration,addres) values ('" + name + "','" + mname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + semester + "','" + progam + "','" + sname + "','" + add + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data Saved.Remember the Registration ID","Data",MessageBoxButtons.OK,MessageBoxIcon.Hand);




        }
    }
}
