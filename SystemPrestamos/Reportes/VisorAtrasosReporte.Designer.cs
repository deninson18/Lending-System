namespace SystemPrestamos.Reportes
{
    partial class VisorAtrasosReporte
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
            this.VisorAtrasoscrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VisorAtrasoscrystalReportViewer
            // 
            this.VisorAtrasoscrystalReportViewer.ActiveViewIndex = -1;
            this.VisorAtrasoscrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorAtrasoscrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorAtrasoscrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorAtrasoscrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.VisorAtrasoscrystalReportViewer.Name = "VisorAtrasoscrystalReportViewer";
            this.VisorAtrasoscrystalReportViewer.Size = new System.Drawing.Size(543, 394);
            this.VisorAtrasoscrystalReportViewer.TabIndex = 0;
            // 
            // VisorAtrasosReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 394);
            this.Controls.Add(this.VisorAtrasoscrystalReportViewer);
            this.Name = "VisorAtrasosReport";
            this.Text = "VisorAtrasosReport";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer VisorAtrasoscrystalReportViewer;
    }
}