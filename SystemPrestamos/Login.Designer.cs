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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SysPrestamoslabel = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.IniciarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(16, 339);
            this.usuarioTextBox.MaxLength = 40;
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(252, 20);
            this.usuarioTextBox.TabIndex = 2;
            this.usuarioTextBox.TextChanged += new System.EventHandler(this.usuarioTextBox_TextChanged);
            this.usuarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuarioTextBox_KeyPress);
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.Location = new System.Drawing.Point(15, 391);
            this.ContrasenaTextBox.MaxLength = 50;
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.Size = new System.Drawing.Size(252, 20);
            this.ContrasenaTextBox.TabIndex = 3;
            this.ContrasenaTextBox.UseSystemPasswordChar = true;
            this.ContrasenaTextBox.TextChanged += new System.EventHandler(this.ContrasenaTextBox_TextChanged);
            this.ContrasenaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContrasenaTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 8;
            // 
            // SysPrestamoslabel
            // 
            this.SysPrestamoslabel.AutoSize = true;
            this.SysPrestamoslabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysPrestamoslabel.Location = new System.Drawing.Point(45, 9);
            this.SysPrestamoslabel.Name = "SysPrestamoslabel";
            this.SysPrestamoslabel.Size = new System.Drawing.Size(202, 28);
            this.SysPrestamoslabel.TabIndex = 9;
            this.SysPrestamoslabel.Text = "Lending System ";
            this.SysPrestamoslabel.Click += new System.EventHandler(this.SysPrestamoslabel_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelarButton.Location = new System.Drawing.Point(193, 417);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 57);
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "CANCELAR";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // IniciarButton
            // 
            this.IniciarButton.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IniciarButton.Location = new System.Drawing.Point(16, 417);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IniciarButton.Size = new System.Drawing.Size(75, 57);
            this.IniciarButton.TabIndex = 4;
            this.IniciarButton.Text = "INICIAR";
            this.IniciarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemPrestamos.Properties.Resources.personal_information_98356;
            this.pictureBox1.Location = new System.Drawing.Point(17, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 261);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SysPrestamoslabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.IniciarButton);
            this.Controls.Add(this.ContrasenaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

