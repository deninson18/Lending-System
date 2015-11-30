namespace SystemPrestamos
{
    partial class RegistroUsuarios
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
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.NombreUsuariolabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.NombreUsuariotextBox = new System.Windows.Forms.TextBox();
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.Registrolabel = new System.Windows.Forms.Label();
            this.AgregarImgbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioIdtextBox = new System.Windows.Forms.TextBox();
            this.AreaUsuariolabel = new System.Windows.Forms.Label();
            this.AreaUsuariotextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.InsertarImgpictureBox = new System.Windows.Forms.PictureBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InsertarImgpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrelabel.Location = new System.Drawing.Point(12, 119);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(59, 15);
            this.Nombrelabel.TabIndex = 0;
            this.Nombrelabel.Text = "Nombre";
            // 
            // NombreUsuariolabel
            // 
            this.NombreUsuariolabel.AutoSize = true;
            this.NombreUsuariolabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuariolabel.Location = new System.Drawing.Point(12, 184);
            this.NombreUsuariolabel.Name = "NombreUsuariolabel";
            this.NombreUsuariolabel.Size = new System.Drawing.Size(132, 15);
            this.NombreUsuariolabel.TabIndex = 1;
            this.NombreUsuariolabel.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(309, 82);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(15, 135);
            this.NombretextBox.MaxLength = 30;
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(214, 20);
            this.NombretextBox.TabIndex = 0;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // NombreUsuariotextBox
            // 
            this.NombreUsuariotextBox.Location = new System.Drawing.Point(15, 200);
            this.NombreUsuariotextBox.MaxLength = 40;
            this.NombreUsuariotextBox.Name = "NombreUsuariotextBox";
            this.NombreUsuariotextBox.Size = new System.Drawing.Size(214, 20);
            this.NombreUsuariotextBox.TabIndex = 1;
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.Location = new System.Drawing.Point(15, 264);
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.Size = new System.Drawing.Size(214, 20);
            this.ContrasenatextBox.TabIndex = 2;
            this.ContrasenatextBox.UseSystemPasswordChar = true;
            // 
            // Registrolabel
            // 
            this.Registrolabel.AutoSize = true;
            this.Registrolabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrolabel.Location = new System.Drawing.Point(109, 22);
            this.Registrolabel.Name = "Registrolabel";
            this.Registrolabel.Size = new System.Drawing.Size(256, 28);
            this.Registrolabel.TabIndex = 8;
            this.Registrolabel.Text = "Registro de Usuarios";
            // 
            // AgregarImgbutton
            // 
            this.AgregarImgbutton.Location = new System.Drawing.Point(360, 255);
            this.AgregarImgbutton.Name = "AgregarImgbutton";
            this.AgregarImgbutton.Size = new System.Drawing.Size(91, 26);
            this.AgregarImgbutton.TabIndex = 5;
            this.AgregarImgbutton.Text = "Cargar Imagen";
            this.AgregarImgbutton.UseVisualStyleBackColor = true;
            this.AgregarImgbutton.Click += new System.EventHandler(this.AgregarImgbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "UsuarioId";
            // 
            // UsuarioIdtextBox
            // 
            this.UsuarioIdtextBox.Location = new System.Drawing.Point(15, 82);
            this.UsuarioIdtextBox.MaxLength = 10;
            this.UsuarioIdtextBox.Name = "UsuarioIdtextBox";
            this.UsuarioIdtextBox.Size = new System.Drawing.Size(214, 20);
            this.UsuarioIdtextBox.TabIndex = 9;
            this.UsuarioIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsuarioIdtextBox_KeyPress);
            // 
            // AreaUsuariolabel
            // 
            this.AreaUsuariolabel.AutoSize = true;
            this.AreaUsuariolabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaUsuariolabel.Location = new System.Drawing.Point(12, 309);
            this.AreaUsuariolabel.Name = "AreaUsuariolabel";
            this.AreaUsuariolabel.Size = new System.Drawing.Size(111, 15);
            this.AreaUsuariolabel.TabIndex = 12;
            this.AreaUsuariolabel.Text = "Area de Usuario";
            // 
            // AreaUsuariotextBox
            // 
            this.AreaUsuariotextBox.Location = new System.Drawing.Point(15, 325);
            this.AreaUsuariotextBox.MaxLength = 30;
            this.AreaUsuariotextBox.Name = "AreaUsuariotextBox";
            this.AreaUsuariotextBox.Size = new System.Drawing.Size(214, 20);
            this.AreaUsuariotextBox.TabIndex = 3;
            this.AreaUsuariotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AreaUsuariotextBox_KeyPress);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::SystemPrestamos.Properties.Resources._1442277587_search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(237, 66);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(39, 36);
            this.Buscarbutton.TabIndex = 10;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // InsertarImgpictureBox
            // 
            this.InsertarImgpictureBox.Cursor = System.Windows.Forms.Cursors.No;
            this.InsertarImgpictureBox.Location = new System.Drawing.Point(309, 119);
            this.InsertarImgpictureBox.Name = "InsertarImgpictureBox";
            this.InsertarImgpictureBox.Size = new System.Drawing.Size(183, 130);
            this.InsertarImgpictureBox.TabIndex = 9;
            this.InsertarImgpictureBox.TabStop = false;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::SystemPrestamos.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(309, 364);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(59, 66);
            this.Eliminarbutton.TabIndex = 8;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::SystemPrestamos.Properties.Resources.save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(222, 364);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(64, 66);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar ";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::SystemPrestamos.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(139, 364);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(57, 66);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 429);
            this.Controls.Add(this.AreaUsuariotextBox);
            this.Controls.Add(this.AreaUsuariolabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.UsuarioIdtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarImgbutton);
            this.Controls.Add(this.InsertarImgpictureBox);
            this.Controls.Add(this.Registrolabel);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ContrasenatextBox);
            this.Controls.Add(this.NombreUsuariotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreUsuariolabel);
            this.Controls.Add(this.Nombrelabel);
            this.MaximizeBox = false;
            this.Name = "RegistroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            ((System.ComponentModel.ISupportInitialize)(this.InsertarImgpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label NombreUsuariolabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox NombreUsuariotextBox;
        private System.Windows.Forms.TextBox ContrasenatextBox;
        private System.Windows.Forms.Label Registrolabel;
        private System.Windows.Forms.PictureBox InsertarImgpictureBox;
        private System.Windows.Forms.Button AgregarImgbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsuarioIdtextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label AreaUsuariolabel;
        private System.Windows.Forms.TextBox AreaUsuariotextBox;
    }
}