namespace SystemPrestamos
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.IniciarButton = new System.Windows.Forms.Button();
            this.SysPrestamoslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(12, 151);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(243, 20);
            this.usuarioTextBox.TabIndex = 2;
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.Location = new System.Drawing.Point(12, 213);
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.Size = new System.Drawing.Size(243, 20);
            this.ContrasenaTextBox.TabIndex = 3;
            this.ContrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 8;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::SystemPrestamos.Properties.Resources.cancel;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelarButton.Location = new System.Drawing.Point(180, 266);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 71);
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "CANCELAR";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // IniciarButton
            // 
            this.IniciarButton.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarButton.Image = global::SystemPrestamos.Properties.Resources._1445992385_Open;
            this.IniciarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IniciarButton.Location = new System.Drawing.Point(12, 266);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.Size = new System.Drawing.Size(75, 71);
            this.IniciarButton.TabIndex = 4;
            this.IniciarButton.Text = "INICIAR";
            this.IniciarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // SysPrestamoslabel
            // 
            this.SysPrestamoslabel.AutoSize = true;
            this.SysPrestamoslabel.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysPrestamoslabel.Location = new System.Drawing.Point(13, 40);
            this.SysPrestamoslabel.Name = "SysPrestamoslabel";
            this.SysPrestamoslabel.Size = new System.Drawing.Size(245, 34);
            this.SysPrestamoslabel.TabIndex = 9;
            this.SysPrestamoslabel.Text = "System Prestamos";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 409);
            this.Controls.Add(this.SysPrestamoslabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.IniciarButton);
            this.Controls.Add(this.ContrasenaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox ContrasenaTextBox;
        private System.Windows.Forms.Button IniciarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SysPrestamoslabel;
    }
}

