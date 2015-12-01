namespace SystemPrestamos.Consultas
{
    partial class ConsultaAtrasos
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
            this.AtrasocomboBox = new System.Windows.Forms.ComboBox();
            this.AtrasotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.consultaAtrasobutton = new System.Windows.Forms.Button();
            this.AtrasodataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AtrasodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AtrasocomboBox
            // 
            this.AtrasocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AtrasocomboBox.FormattingEnabled = true;
            this.AtrasocomboBox.Items.AddRange(new object[] {
            "AtrasoId",
            "Atraso"});
            this.AtrasocomboBox.Location = new System.Drawing.Point(101, 9);
            this.AtrasocomboBox.Name = "AtrasocomboBox";
            this.AtrasocomboBox.Size = new System.Drawing.Size(218, 21);
            this.AtrasocomboBox.TabIndex = 0;
            // 
            // AtrasotextBox
            // 
            this.AtrasotextBox.Location = new System.Drawing.Point(101, 36);
            this.AtrasotextBox.Name = "AtrasotextBox";
            this.AtrasotextBox.Size = new System.Drawing.Size(218, 20);
            this.AtrasotextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Por:";
            // 
            // consultaAtrasobutton
            // 
            this.consultaAtrasobutton.Image = global::SystemPrestamos.Properties.Resources._1442277587_search;
            this.consultaAtrasobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.consultaAtrasobutton.Location = new System.Drawing.Point(325, 9);
            this.consultaAtrasobutton.Name = "consultaAtrasobutton";
            this.consultaAtrasobutton.Size = new System.Drawing.Size(61, 47);
            this.consultaAtrasobutton.TabIndex = 3;
            this.consultaAtrasobutton.Text = "Consultar";
            this.consultaAtrasobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.consultaAtrasobutton.UseVisualStyleBackColor = true;
            this.consultaAtrasobutton.Click += new System.EventHandler(this.consultaAtrasobutton_Click);
            // 
            // AtrasodataGridView
            // 
            this.AtrasodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AtrasodataGridView.Location = new System.Drawing.Point(15, 62);
            this.AtrasodataGridView.Name = "AtrasodataGridView";
            this.AtrasodataGridView.Size = new System.Drawing.Size(547, 150);
            this.AtrasodataGridView.TabIndex = 4;
            // 
            // ConsultaAtrasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 243);
            this.Controls.Add(this.AtrasodataGridView);
            this.Controls.Add(this.consultaAtrasobutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AtrasotextBox);
            this.Controls.Add(this.AtrasocomboBox);
            this.MaximizeBox = false;
            this.Name = "ConsultaAtrasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaAtrasos";
            ((System.ComponentModel.ISupportInitialize)(this.AtrasodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AtrasocomboBox;
        private System.Windows.Forms.TextBox AtrasotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button consultaAtrasobutton;
        private System.Windows.Forms.DataGridView AtrasodataGridView;
    }
}