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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void UpdateEvaluationButton_Click(object sender, EventArgs e)
        {
            GenerateReport1 generateReport1 = new GenerateReport1();
            this.Hide();
            generateReport1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateReport2 generateReport2 = new GenerateReport2();
            this.Hide();
            generateReport2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdvisorForm advisorForm = new AdvisorForm();
            this.Hide();
            advisorForm.Show();
        }
    }
}
