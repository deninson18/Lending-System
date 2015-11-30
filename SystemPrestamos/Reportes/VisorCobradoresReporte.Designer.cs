namespace SystemPrestamos.Reportes
{
    partial class VisorCobradoresReporte
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
            this.VisorCobradorescrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VisorCobradorescrystalReportViewer
            // 
            this.VisorCobradorescrystalReportViewer.ActiveViewIndex = -1;
            this.VisorCobradorescrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorCobradorescrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorCobradorescrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorCobradorescrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.VisorCobradorescrystalReportViewer.Name = "VisorCobradorescrystalReportViewer";
            this.VisorCobradorescrystalReportViewer.Size = new System.Drawing.Size(538, 346);
            this.VisorCobradorescrystalReportViewer.TabIndex = 0;
            // 
            // CobradoresReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 346);
            this.Controls.Add(this.VisorCobradorescrystalReportViewer);
            this.Name = "CobradoresReporte";
            this.Text = "CobradoresReporte";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer VisorCobradorescrystalReportViewer;
    }
}