namespace SystemPrestamos.Consultas
{
    partial class ConsultaRutas
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
            this.buscaRutatextBox = new System.Windows.Forms.TextBox();
            this.buscaRutacomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscaRutabutton = new System.Windows.Forms.Button();
            this.RutasdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RutasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buscaRutatextBox
            // 
            this.buscaRutatextBox.Location = new System.Drawing.Point(109, 39);
            this.buscaRutatextBox.Name = "buscaRutatextBox";
            this.buscaRutatextBox.Size = new System.Drawing.Size(187, 20);
            this.buscaRutatextBox.TabIndex = 0;
            // 
            // buscaRutacomboBox
            // 
            this.buscaRutacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buscaRutacomboBox.FormattingEnabled = true;
            this.buscaRutacomboBox.Items.AddRange(new object[] {
            "Ruta Id",
            "Nombre"});
            this.buscaRutacomboBox.Location = new System.Drawing.Point(109, 12);
            this.buscaRutacomboBox.Name = "buscaRutacomboBox";
            this.buscaRutacomboBox.Size = new System.Drawing.Size(187, 21);
            this.buscaRutacomboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Por:";
            // 
            // buscaRutabutton
            // 
            this.buscaRutabutton.Image = global::SystemPrestamos.Properties.Resources._1442277587_search;
            this.buscaRutabutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buscaRutabutton.Location = new System.Drawing.Point(302, 12);
            this.buscaRutabutton.Name = "buscaRutabutton";
            this.buscaRutabutton.Size = new System.Drawing.Size(59, 47);
            this.buscaRutabutton.TabIndex = 3;
            this.buscaRutabutton.Text = "Consultar";
            this.buscaRutabutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buscaRutabutton.UseVisualStyleBackColor = true;
            this.buscaRutabutton.Click += new System.EventHandler(this.buscaRutabutton_Click);
            // 
            // RutasdataGridView
            // 
            this.RutasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RutasdataGridView.Location = new System.Drawing.Point(12, 65);
            this.RutasdataGridView.Name = "RutasdataGridView";
            this.RutasdataGridView.Size = new System.Drawing.Size(349, 163);
            this.RutasdataGridView.TabIndex = 4;
            // 
            // ConsultaRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 237);
            this.Controls.Add(this.RutasdataGridView);
            this.Controls.Add(this.buscaRutabutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscaRutacomboBox);
            this.Controls.Add(this.buscaRutatextBox);
            this.Name = "ConsultaRutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaRutas";
            ((System.ComponentModel.ISupportInitialize)(this.RutasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buscaRutatextBox;
        private System.Windows.Forms.ComboBox buscaRutacomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscaRutabutton;
        private System.Windows.Forms.DataGridView RutasdataGridView;
    }
}