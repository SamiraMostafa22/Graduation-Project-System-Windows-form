using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftWare_Project
{
    public partial class GenerateReport2 : Form
    {
        CrystalReport2 CR;
        public GenerateReport2()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void GenerateReport2_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            this.Hide();
            reportsForm.Show();
        }

        private void UpdateEvaluationButton_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
