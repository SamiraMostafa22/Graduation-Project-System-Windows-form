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
    public partial class ContactWithAdvisor : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public ContactWithAdvisor()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.Show();
        }
        
        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            if(ProjectNameTextBox.Text == "")
            {
                MessageBox.Show("Complete your data");
            }
            else
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "GetAdvisorID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("projectname", ProjectNameTextBox.Text);
                cmd.Parameters.Add("AdvisorID", OracleDbType.Int64, ParameterDirection.Output);
                try
                {
                    cmd.ExecuteNonQuery();
                    AdvisorIDTextBox.Text = cmd.Parameters["AdvisorID"].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Project not found .");
                }
                
            }
        }
    }
}
