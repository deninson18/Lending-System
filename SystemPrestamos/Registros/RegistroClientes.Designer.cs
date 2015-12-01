namespace SystemPrestamos
{
    partial class RegistroClientes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idCtextBox = new System.Windows.Forms.TextBox();
            this.nombreCtextBox = new System.Windows.Forms.TextBox();
            this.apellidoCtextBox = new System.Windows.Forms.TextBox();
            this.apodoCtextBox = new System.Windows.Forms.TextBox();
            this.direccionCtextBox = new System.Windows.Forms.TextBox();
            this.referenciaCtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MasculinoradioButton = new System.Windows.Forms.RadioButton();
            this.FemeninoradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cedulaCtextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefonoCtextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularCtextBox = new System.Windows.Forms.MaskedTextBox();
            this.buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.ClienteerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apodo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Referencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefono";
            // 
            // idCtextBox
            // 
            this.idCtextBox.Location = new System.Drawing.Point(12, 76);
            this.idCtextBox.MaxLength = 10;
            this.idCtextBox.Name = "idCtextBox";
            this.idCtextBox.Size = new System.Drawing.Size(216, 20);
            this.idCtextBox.TabIndex = 12;
            this.idCtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idCtextBox_KeyPress);
            // 
            // nombreCtextBox
            // 
            this.nombreCtextBox.Location = new System.Drawing.Point(12, 126);
            this.nombreCtextBox.MaxLength = 30;
            this.nombreCtextBox.Name = "nombreCtextBox";
            this.nombreCtextBox.Size = new System.Drawing.Size(287, 20);
            this.nombreCtextBox.TabIndex = 0;
             this.nombreCtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreCtextBox_KeyPress);
            // 
            // apellidoCtextBox
            // 
            this.apellidoCtextBox.Location = new System.Drawing.Point(12, 179);
            this.apellidoCtextBox.MaxLength = 30;
            this.apellidoCtextBox.Name = "apellidoCtextBox";
            this.apellidoCtextBox.Size = new System.Drawing.Size(287, 20);
            this.apellidoCtextBox.TabIndex = 1;
            this.apellidoCtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidoCtextBox_KeyPress);
            // 
            // apodoCtextBox
            // 
            this.apodoCtextBox.Location = new System.Drawing.Point(12, 231);
            this.apodoCtextBox.MaxLength = 30;
            this.apodoCtextBox.Name = "apodoCtextBox";
            this.apodoCtextBox.Size = new System.Drawing.Size(287, 20);
            this.apodoCtextBox.TabIndex = 2;
            this.apodoCtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apodoCtextBox_KeyPress);
            // 
            // direccionCtextBox
            // 
            this.direccionCtextBox.Location = new System.Drawing.Point(316, 76);
            this.direccionCtextBox.MaxLength = 100;
            this.direccionCtextBox.Multiline = true;
            this.direccionCtextBox.Name = "direccionCtextBox";
            this.direccionCtextBox.Size = new System.Drawing.Size(309, 70);
            this.direccionCtextBox.TabIndex = 4;
            // 
            // referenciaCtextBox
            // 
            this.referenciaCtextBox.Location = new System.Drawing.Point(314, 179);
            this.referenciaCtextBox.MaxLength = 50;
            this.referenciaCtextBox.Name = "referenciaCtextBox";
            this.referenciaCtextBox.Size = new System.Drawing.Size(309, 20);
            this.referenciaCtextBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cedula";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(313, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Celular";
            // 
            // MasculinoradioButton
            // 
            this.MasculinoradioButton.AutoSize = true;
            this.MasculinoradioButton.Checked = true;
            this.MasculinoradioButton.Location = new System.Drawing.Point(44, 19);
            this.MasculinoradioButton.Name = "MasculinoradioButton";
            this.MasculinoradioButton.Size = new System.Drawing.Size(91, 19);
            this.MasculinoradioButton.TabIndex = 0;
            this.MasculinoradioButton.TabStop = true;
            this.MasculinoradioButton.Text = "Masculino";
            this.MasculinoradioButton.UseVisualStyleBackColor = true;
            // 
            // FemeninoradioButton
            // 
            this.FemeninoradioButton.AutoSize = true;
            this.FemeninoradioButton.Location = new System.Drawing.Point(157, 19);
            this.FemeninoradioButton.Name = "FemeninoradioButton";
            this.FemeninoradioButton.Size = new System.Drawing.Size(89, 19);
            this.FemeninoradioButton.TabIndex = 1;
            this.FemeninoradioButton.Text = "Femenino";
            this.FemeninoradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MasculinoradioButton);
            this.groupBox1.Controls.Add(this.FemeninoradioButton);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 57);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "Registro de Clientes";
            // 
            // cedulaCtextBox
            // 
            this.cedulaCtextBox.Location = new System.Drawing.Point(12, 351);
            this.cedulaCtextBox.Mask = "999-9999999-9";
            this.cedulaCtextBox.Name = "cedulaCtextBox";
            this.cedulaCtextBox.Size = new System.Drawing.Size(287, 20);
            this.cedulaCtextBox.TabIndex = 3;
            // 
            // telefonoCtextBox
            // 
            this.telefonoCtextBox.Location = new System.Drawing.Point(316, 231);
            this.telefonoCtextBox.Mask = "(000)-000-0000";
            this.telefonoCtextBox.Name = "telefonoCtextBox";
            this.telefonoCtextBox.Size = new System.Drawing.Size(307, 20);
            this.telefonoCtextBox.TabIndex = 6;
            // 
            // celularCtextBox
            // 
            this.celularCtextBox.Location = new System.Drawing.Point(316, 294);
            this.celularCtextBox.Mask = "(000)-000-0000";
            this.celularCtextBox.Name = "celularCtextBox";
            this.celularCtextBox.Size = new System.Drawing.Size(307, 20);
            this.celularCtextBox.TabIndex = 7;
            // 
            // buscarbutton
            // 
            this.buscarbutton.Image = global::SystemPrestamos.Properties.Resources._1442277587_search;
            this.buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarbutton.Location = new System.Drawing.Point(234, 57);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(37, 39);
            this.buscarbutton.TabIndex = 13;
            this.buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::SystemPrestamos.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(352, 388);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(56, 57);
            this.Eliminarbutton.TabIndex = 11;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::SystemPrestamos.Properties.Resources.save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(264, 388);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(61, 57);
            this.Guardarbutton.TabIndex = 10;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::SystemPrestamos.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(188, 388);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(54, 57);
            this.Nuevobutton.TabIndex = 9;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.button_Click);
            // 
            // ClienteerrorProvider
            // 
            this.ClienteerrorProvider.ContainerControl = this;
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 457);
            this.Controls.Add(this.celularCtextBox);
            this.Controls.Add(this.telefonoCtextBox);
            this.Controls.Add(this.cedulaCtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buscarbutton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.referenciaCtextBox);
            this.Controls.Add(this.direccionCtextBox);
            this.Controls.Add(this.apodoCtextBox);
            this.Controls.Add(this.apellidoCtextBox);
            this.Controls.Add(this.nombreCtextBox);
            this.Controls.Add(this.idCtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RegistroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idCtextBox;
        private System.Windows.Forms.TextBox nombreCtextBox;
        private System.Windows.Forms.TextBox apellidoCtextBox;
        private System.Windows.Forms.TextBox apodoCtextBox;
        private System.Windows.Forms.TextBox direccionCtextBox;
        private System.Windows.Forms.TextBox referenciaCtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.RadioButton MasculinoradioButton;
        private System.Windows.Forms.RadioButton FemeninoradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox cedulaCtextBox;
        private System.Windows.Forms.MaskedTextBox telefonoCtextBox;
        private System.Windows.Forms.MaskedTextBox celularCtextBox;
        private System.Windows.Forms.ErrorProvider ClienteerrorProvider;
    }
}