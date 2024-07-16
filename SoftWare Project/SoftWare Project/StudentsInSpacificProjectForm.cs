﻿using System;
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
    public partial class StudentsInSpacificProjectForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public StudentsInSpacificProjectForm()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdvisorForm advisorForm = new AdvisorForm();
            this.Hide();
            advisorForm.Show();
        }
        
        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            TeamNumbersComboBox.Items.Clear();

            if (ProjectNameTextBox.Text == "")
            {
                MessageBox.Show("Complete your data");
            }
            else
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Getproject_teamnum";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("projectname", ProjectNameTextBox.Text);
                cmd.Parameters.Add("Teams", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("Project Name Not Found .");
                }
                while (dr.Read())
                {
                    if(!TeamNumbersComboBox.Items.Contains(dr[0]))
                    {
                        TeamNumbersComboBox.Items.Add(dr[0]);
                    }
                }
                dr.Close();


            }
        }
    }
}
