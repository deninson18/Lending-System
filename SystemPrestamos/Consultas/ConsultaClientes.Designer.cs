namespace SystemPrestamos.Consultas
{
    partial class ConsultaClientes
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
            this.buscaClientecomboBox = new System.Windows.Forms.ComboBox();
            this.ClientedataGridView = new System.Windows.Forms.DataGridView();
            this.buscaClientetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscaClientebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buscaClientecomboBox
            // 
            this.buscaClientecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buscaClientecomboBox.FormattingEnabled = true;
            this.buscaClientecomboBox.Items.AddRange(new object[] {
            "Cliente Id",
            "Nombres",
            "Apellidos",
            "Direccion"});
            this.buscaClientecomboBox.Location = new System.Drawing.Point(98, 9);
            this.buscaClientecomboBox.Name = "buscaClientecomboBox";
            this.buscaClientecomboBox.Size = new System.Drawing.Size(255, 21);
            this.buscaClientecomboBox.TabIndex = 0;
            // 
            // ClientedataGridView
            // 
            this.ClientedataGridView.AllowUserToAddRows = false;
            this.ClientedataGridView.AllowUserToDeleteRows = false;
            this.ClientedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientedataGridView.Location = new System.Drawing.Point(12, 65);
            this.ClientedataGridView.Name = "ClientedataGridView";
            this.ClientedataGridView.ReadOnly = true;
            this.ClientedataGridView.Size = new System.Drawing.Size(670, 277);
            this.ClientedataGridView.TabIndex = 1;
            // 
            // buscaClientetextBox
            // 
            this.buscaClientetextBox.Location = new System.Drawing.Point(98, 36);
            this.buscaClientetextBox.Name = "buscaClientetextBox";
            this.buscaClientetextBox.Size = new System.Drawing.Size(255, 20);
            this.buscaClientetextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Por:";
            // 
            // buscaClientebutton
            // 
            this.buscaClientebutton.Image = global::SystemPrestamos.Properties.Resources._1442277587_search;
            this.buscaClientebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buscaClientebutton.Location = new System.Drawing.Point(359, 9);
            this.buscaClientebutton.Name = "buscaClientebutton";
            this.buscaClientebutton.Size = new System.Drawing.Size(63, 47);
            this.buscaClientebutton.TabIndex = 3;
            this.buscaClientebutton.Text = "Consultar";
            this.buscaClientebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buscaClientebutton.UseVisualStyleBackColor = true;
            this.buscaClientebutton.Click += new System.EventHandler(this.buscaClientebutton_Click);
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscaClientebutton);
            this.Controls.Add(this.buscaClientetextBox);
            this.Controls.Add(this.ClientedataGridView);
            this.Controls.Add(this.buscaClientecomboBox);
            this.Name = "ConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.ClientedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox buscaClientecomboBox;
        private System.Windows.Forms.DataGridView ClientedataGridView;
        private System.Windows.Forms.TextBox buscaClientetextBox;
        private System.Windows.Forms.Button buscaClientebutton;
        private System.Windows.Forms.Label label1;
    }
}