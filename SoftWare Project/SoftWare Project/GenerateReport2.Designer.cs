
namespace SoftWare_Project
{
    partial class GenerateReport2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UpdateEvaluationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 81);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1524, 611);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoftWare_Project.Properties.Resources.pngegg;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // UpdateEvaluationButton
            // 
            this.UpdateEvaluationButton.BackColor = System.Drawing.Color.Gray;
            this.UpdateEvaluationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEvaluationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateEvaluationButton.Location = new System.Drawing.Point(667, 12);
            this.UpdateEvaluationButton.Name = "UpdateEvaluationButton";
            this.UpdateEvaluationButton.Size = new System.Drawing.Size(217, 63);
            this.UpdateEvaluationButton.TabIndex = 34;
            this.UpdateEvaluationButton.Text = "Generate Report";
            this.UpdateEvaluationButton.UseVisualStyleBackColor = false;
            this.UpdateEvaluationButton.Click += new System.EventHandler(this.UpdateEvaluationButton_Click);
            // 
            // GenerateReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1521, 691);
            this.Controls.Add(this.UpdateEvaluationButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "GenerateReport2";
            this.Text = "GenerateReport2";
            this.Load += new System.EventHandler(this.GenerateReport2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button UpdateEvaluationButton;
    }
}