namespace SystemPrestamos.Consultas
{
    partial class ConsultaUsuario
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
            this.buscaUscomboBox = new System.Windows.Forms.ComboBox();
            this.buscaUstextBox = new System.Windows.Forms.TextBox();
            this.buscaUsuariobutton = new System.Windows.Forms.Button();
            this.UsdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buscaUscomboBox
            // 
            this.buscaUscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buscaUscomboBox.FormattingEnabled = true;
            this.buscaUscomboBox.Items.AddRange(new object[] {
            "Usuario Id",
            "Nombre"});
            this.buscaUscomboBox.Location = new System.Drawing.Point(95, 25);
            this.buscaUscomboBox.Name = "buscaUscomboBox";
            this.buscaUscomboBox.Size = new System.Drawing.Size(214, 21);
            this.buscaUscomboBox.TabIndex = 0;
            // 
            // buscaUstextBox
            // 
            this.buscaUstextBox.Location = new System.Drawing.Point(95, 52);
            this.buscaUstextBox.MaxLength = 50;
            this.buscaUstextBox.Name = "buscaUstextBox";
            this.buscaUstextBox.Size = new System.Drawing.Size(214, 20);
            this.buscaUstextBox.TabIndex = 1;
            // 
            // buscaUsuariobutton
            // 
            this.buscaUsuariobutton.Image = global::SystemPrestamos.Properties.Resources._1442277587_search;
            this.buscaUsuariobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buscaUsuariobutton.Location = new System.Drawing.Point(315, 25);
            this.buscaUsuariobutton.Name = "buscaUsuariobutton";
            this.buscaUsuariobutton.Size = new System.Drawing.Size(59, 47);
            this.buscaUsuariobutton.TabIndex = 2;
            this.buscaUsuariobutton.Text = "Consultar";
            this.buscaUsuariobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buscaUsuariobutton.UseVisualStyleBackColor = true;
            this.buscaUsuariobutton.Click += new System.EventHandler(this.buscaUsuariobutton_Click);
            // 
            // UsdataGridView
            // 
            this.UsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsdataGridView.Location = new System.Drawing.Point(12, 78);
            this.UsdataGridView.Name = "UsdataGridView";
            this.UsdataGridView.ReadOnly = true;
            this.UsdataGridView.Size = new System.Drawing.Size(581, 295);
            this.UsdataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Por:";
            // 
            // ConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsdataGridView);
            this.Controls.Add(this.buscaUsuariobutton);
            this.Controls.Add(this.buscaUstextBox);
            this.Controls.Add(this.buscaUscomboBox);
            this.MinimizeBox = false;
            this.Name = "ConsultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.UsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox buscaUscomboBox;
        private System.Windows.Forms.TextBox buscaUstextBox;
        private System.Windows.Forms.Button buscaUsuariobutton;
        private System.Windows.Forms.DataGridView UsdataGridView;
        private System.Windows.Forms.Label label1;
    }
}