namespace RegistroPelicula
{
    partial class Consulta
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
            this.ConsultaCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ConsultaCrystalReportViewer
            // 
            this.ConsultaCrystalReportViewer.ActiveViewIndex = -1;
            this.ConsultaCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultaCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConsultaCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultaCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ConsultaCrystalReportViewer.Name = "ConsultaCrystalReportViewer";
            this.ConsultaCrystalReportViewer.Size = new System.Drawing.Size(320, 261);
            this.ConsultaCrystalReportViewer.TabIndex = 0;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 261);
            this.Controls.Add(this.ConsultaCrystalReportViewer);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer ConsultaCrystalReportViewer;
    }
}