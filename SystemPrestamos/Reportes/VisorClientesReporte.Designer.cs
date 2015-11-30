namespace SystemPrestamos.Reportes
{
    partial class VisorClientesReporte
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
            this.VisorClientescrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VisorClientescrystalReportViewer
            // 
            this.VisorClientescrystalReportViewer.ActiveViewIndex = -1;
            this.VisorClientescrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorClientescrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorClientescrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorClientescrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.VisorClientescrystalReportViewer.Name = "VisorClientescrystalReportViewer";
            this.VisorClientescrystalReportViewer.Size = new System.Drawing.Size(733, 533);
            this.VisorClientescrystalReportViewer.TabIndex = 0;
            // 
            // VisorClientesReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 533);
            this.Controls.Add(this.VisorClientescrystalReportViewer);
            this.Name = "VisorClientesReporte";
            this.Text = "VisorClientesReporte";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer VisorClientescrystalReportViewer;
    }
}