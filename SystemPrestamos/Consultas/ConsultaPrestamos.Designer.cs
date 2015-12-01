namespace SystemPrestamos.Consultas
{
    partial class ConsultaPrestamos
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
            this.label1 = new System.Windows.Forms.Label();
            this.prestamocomboBox = new System.Windows.Forms.ComboBox();
            this.prestamotextBox = new System.Windows.Forms.TextBox();
            this.prestamoConsultabutton = new System.Windows.Forms.Button();
            this.PrestamodataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Por:";
            // 
            // prestamocomboBox
            // 
            this.prestamocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prestamocomboBox.FormattingEnabled = true;
            this.prestamocomboBox.Items.AddRange(new object[] {
            "PrestamoId",
            "Monto"});
            this.prestamocomboBox.Location = new System.Drawing.Point(101, 9);
            this.prestamocomboBox.Name = "prestamocomboBox";
            this.prestamocomboBox.Size = new System.Drawing.Size(194, 21);
            this.prestamocomboBox.TabIndex = 1;
            // 
            // prestamotextBox
            // 
            this.prestamotextBox.Location = new System.Drawing.Point(101, 36);
            this.prestamotextBox.MaxLength = 30;
            this.prestamotextBox.Name = "prestamotextBox";
            this.prestamotextBox.Size = new System.Drawing.Size(194, 20);
            this.prestamotextBox.TabIndex = 2;
            // 
            // prestamoConsultabutton
            // 
            this.prestamoConsultabutton.Image = global::SystemPrestamos.Properties.Resources._1442277587_search;
            this.prestamoConsultabutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prestamoConsultabutton.Location = new System.Drawing.Point(301, 12);
            this.prestamoConsultabutton.Name = "prestamoConsultabutton";
            this.prestamoConsultabutton.Size = new System.Drawing.Size(60, 44);
            this.prestamoConsultabutton.TabIndex = 3;
            this.prestamoConsultabutton.Text = "Consultar";
            this.prestamoConsultabutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.prestamoConsultabutton.UseVisualStyleBackColor = true;
            this.prestamoConsultabutton.Click += new System.EventHandler(this.prestamoConsultabutton_Click);
            // 
            // PrestamodataGridView
            // 
            this.PrestamodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrestamodataGridView.Location = new System.Drawing.Point(15, 62);
            this.PrestamodataGridView.Name = "PrestamodataGridView";
            this.PrestamodataGridView.Size = new System.Drawing.Size(535, 187);
            this.PrestamodataGridView.TabIndex = 4;
            // 
            // ConsultaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 261);
            this.Controls.Add(this.PrestamodataGridView);
            this.Controls.Add(this.prestamoConsultabutton);
            this.Controls.Add(this.prestamotextBox);
            this.Controls.Add(this.prestamocomboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ConsultaPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaPrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.PrestamodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox prestamocomboBox;
        private System.Windows.Forms.TextBox prestamotextBox;
        private System.Windows.Forms.Button prestamoConsultabutton;
        private System.Windows.Forms.DataGridView PrestamodataGridView;
    }
}