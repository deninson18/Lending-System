namespace SystemPrestamos.Consultas
{
    partial class ConsultaCobradores
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
            this.buscaCobradorcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscaCobradortextBox = new System.Windows.Forms.TextBox();
            this.buscaCobradorbutton = new System.Windows.Forms.Button();
            this.CobradordataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CobradordataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buscaCobradorcomboBox
            // 
            this.buscaCobradorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buscaCobradorcomboBox.FormattingEnabled = true;
            this.buscaCobradorcomboBox.Items.AddRange(new object[] {
            "Cobrador Id",
            "Nombres",
            "Apellidos",
            "Direccion"});
            this.buscaCobradorcomboBox.Location = new System.Drawing.Point(92, 12);
            this.buscaCobradorcomboBox.Name = "buscaCobradorcomboBox";
            this.buscaCobradorcomboBox.Size = new System.Drawing.Size(250, 21);
            this.buscaCobradorcomboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Por:";
            // 
            // buscaCobradortextBox
            // 
            this.buscaCobradortextBox.Location = new System.Drawing.Point(92, 39);
            this.buscaCobradortextBox.MaxLength = 50;
            this.buscaCobradortextBox.Name = "buscaCobradortextBox";
            this.buscaCobradortextBox.Size = new System.Drawing.Size(250, 20);
            this.buscaCobradortextBox.TabIndex = 2;
            // 
            // buscaCobradorbutton
            // 
            this.buscaCobradorbutton.Image = global::SystemPrestamos.Properties.Resources._1442277587_search;
            this.buscaCobradorbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buscaCobradorbutton.Location = new System.Drawing.Point(348, 12);
            this.buscaCobradorbutton.Name = "buscaCobradorbutton";
            this.buscaCobradorbutton.Size = new System.Drawing.Size(61, 47);
            this.buscaCobradorbutton.TabIndex = 3;
            this.buscaCobradorbutton.Text = "Consultar";
            this.buscaCobradorbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buscaCobradorbutton.UseVisualStyleBackColor = true;
            this.buscaCobradorbutton.Click += new System.EventHandler(this.buscaCobradorbutton_Click);
            // 
            // CobradordataGridView
            // 
            this.CobradordataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CobradordataGridView.Location = new System.Drawing.Point(6, 65);
            this.CobradordataGridView.Name = "CobradordataGridView";
            this.CobradordataGridView.Size = new System.Drawing.Size(772, 252);
            this.CobradordataGridView.TabIndex = 4;
            // 
            // ConsultaCobradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 329);
            this.Controls.Add(this.CobradordataGridView);
            this.Controls.Add(this.buscaCobradorbutton);
            this.Controls.Add(this.buscaCobradortextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscaCobradorcomboBox);
            this.MaximizeBox = false;
            this.Name = "ConsultaCobradores";
            this.Text = "ConsultaCobradores";
            this.Load += new System.EventHandler(this.ConsultaCobradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CobradordataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox buscaCobradorcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscaCobradortextBox;
        private System.Windows.Forms.Button buscaCobradorbutton;
        private System.Windows.Forms.DataGridView CobradordataGridView;
    }
}