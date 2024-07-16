using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace SoftWare_Project
{
    public partial class GenerateReport1 : Form
    {
        CrystalReport1 CR;
        public GenerateReport1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void GenerateReport1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            foreach(ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            this.Hide();
            reportsForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateEvaluationButton_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
            CR.SetParameterValue(0, comboBox1.Text);
        }
    }
}
