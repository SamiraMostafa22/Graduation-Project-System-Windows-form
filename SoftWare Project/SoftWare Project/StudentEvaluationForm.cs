using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace SoftWare_Project
{
    public partial class StudentEvaluationForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public StudentEvaluationForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (StudentIDTextBox.Text == "")
            {
                MessageBox.Show("Complete your data");
            }
            else
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "GETNUMBEROFPHASES";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", Convert.ToInt32(StudentIDTextBox.Text));
                cmd.Parameters.Add("NumberOfPhases", OracleDbType.Int32, ParameterDirection.Output);
                try
                {
                    cmd.ExecuteNonQuery();
                    StudentNumberOfPhasesTextBox.Text = cmd.Parameters["NumberOfPhases"].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Student not found .");
                }
                
            }
            
        }
       
    }
}
