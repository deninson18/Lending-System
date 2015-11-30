namespace SystemPrestamos.Reportes
{
    partial class VisorRutasReporte
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
            this.VisorRutascrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VisorRutascrystalReportViewer
            // 
            this.VisorRutascrystalReportViewer.ActiveViewIndex = -1;
            this.VisorRutascrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorRutascrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorRutascrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorRutascrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.VisorRutascrystalReportViewer.Name = "VisorRutascrystalReportViewer";
            this.VisorRutascrystalReportViewer.Size = new System.Drawing.Size(621, 465);
            this.VisorRutascrystalReportViewer.TabIndex = 0;
            // 
            // VisorRutasReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 465);
            this.Controls.Add(this.VisorRutascrystalReportViewer);
            this.Name = "VisorRutasReporte";
            this.Text = "VisorRutasReporte";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer VisorRutascrystalReportViewer;
    }
}