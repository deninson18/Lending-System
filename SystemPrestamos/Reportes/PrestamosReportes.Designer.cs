namespace SystemPrestamos.Reportes
{
    partial class PrestamosReportes
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
            this.Cobradoresbutton = new System.Windows.Forms.Button();
            this.Clientesbutton = new System.Windows.Forms.Button();
            this.Rutasbutton = new System.Windows.Forms.Button();
            this.Prestamosbutton = new System.Windows.Forms.Button();
            this.Atrasosbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cobradoresbutton
            // 
            this.Cobradoresbutton.Location = new System.Drawing.Point(83, 85);
            this.Cobradoresbutton.Name = "Cobradoresbutton";
            this.Cobradoresbutton.Size = new System.Drawing.Size(88, 43);
            this.Cobradoresbutton.TabIndex = 0;
            this.Cobradoresbutton.Text = "Cobradores";
            this.Cobradoresbutton.UseVisualStyleBackColor = true;
            this.Cobradoresbutton.Click += new System.EventHandler(this.Cobradoresbutton_Click);
            // 
            // Clientesbutton
            // 
            this.Clientesbutton.Location = new System.Drawing.Point(83, 12);
            this.Clientesbutton.Name = "Clientesbutton";
            this.Clientesbutton.Size = new System.Drawing.Size(88, 46);
            this.Clientesbutton.TabIndex = 1;
            this.Clientesbutton.Text = "Clientes";
            this.Clientesbutton.UseVisualStyleBackColor = true;
            this.Clientesbutton.Click += new System.EventHandler(this.Clientesbutton_Click);
            // 
            // Rutasbutton
            // 
            this.Rutasbutton.Location = new System.Drawing.Point(83, 159);
            this.Rutasbutton.Name = "Rutasbutton";
            this.Rutasbutton.Size = new System.Drawing.Size(88, 44);
            this.Rutasbutton.TabIndex = 2;
            this.Rutasbutton.Text = "Rutas";
            this.Rutasbutton.UseVisualStyleBackColor = true;
            this.Rutasbutton.Click += new System.EventHandler(this.Rutasbutton_Click);
            // 
            // Prestamosbutton
            // 
            this.Prestamosbutton.Location = new System.Drawing.Point(83, 228);
            this.Prestamosbutton.Name = "Prestamosbutton";
            this.Prestamosbutton.Size = new System.Drawing.Size(88, 42);
            this.Prestamosbutton.TabIndex = 3;
            this.Prestamosbutton.Text = "Prestamos";
            this.Prestamosbutton.UseVisualStyleBackColor = true;
            this.Prestamosbutton.Click += new System.EventHandler(this.Prestamosbutton_Click);
            // 
            // Atrasosbutton
            // 
            this.Atrasosbutton.Location = new System.Drawing.Point(83, 296);
            this.Atrasosbutton.Name = "Atrasosbutton";
            this.Atrasosbutton.Size = new System.Drawing.Size(88, 42);
            this.Atrasosbutton.TabIndex = 4;
            this.Atrasosbutton.Text = "Atrasos";
            this.Atrasosbutton.UseVisualStyleBackColor = true;
            this.Atrasosbutton.Click += new System.EventHandler(this.Atrasosbutton_Click);
            // 
            // PrestamosReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(254, 350);
            this.Controls.Add(this.Atrasosbutton);
            this.Controls.Add(this.Prestamosbutton);
            this.Controls.Add(this.Rutasbutton);
            this.Controls.Add(this.Clientesbutton);
            this.Controls.Add(this.Cobradoresbutton);
            this.MaximizeBox = false;
            this.Name = "PrestamosReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrestamosReportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cobradoresbutton;
        private System.Windows.Forms.Button Clientesbutton;
        private System.Windows.Forms.Button Rutasbutton;
        private System.Windows.Forms.Button Prestamosbutton;
        private System.Windows.Forms.Button Atrasosbutton;
    }
}