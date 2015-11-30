namespace SystemPrestamos.Reportes
{
    partial class VisorPrestamosReporte
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
            this.VisorPrestamoscrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VisorPrestamoscrystalReportViewer
            // 
            this.VisorPrestamoscrystalReportViewer.ActiveViewIndex = -1;
            this.VisorPrestamoscrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorPrestamoscrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorPrestamoscrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorPrestamoscrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.VisorPrestamoscrystalReportViewer.Name = "VisorPrestamoscrystalReportViewer";
            this.VisorPrestamoscrystalReportViewer.Size = new System.Drawing.Size(697, 461);
            this.VisorPrestamoscrystalReportViewer.TabIndex = 0;
            // 
            // VisorPrestamosReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 461);
            this.Controls.Add(this.VisorPrestamoscrystalReportViewer);
            this.Name = "VisorPrestamosReporte";
            this.Text = "VisorPrestamosReporte";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer VisorPrestamoscrystalReportViewer;
    }
}