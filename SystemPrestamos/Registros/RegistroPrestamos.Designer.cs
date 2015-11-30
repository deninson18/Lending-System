namespace SystemPrestamos
{
    partial class RegistroPrestamos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrestamoIdtextBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.FechaIdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaFdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.ValorCuotatextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.InterestextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.Ruta = new System.Windows.Forms.Label();
            this.RutacomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SemanaNotextBox = new System.Windows.Forms.TextBox();
            this.PrestamodataGridView = new System.Windows.Forms.DataGridView();
            this.PrestamoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemanaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarPrestamobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamos Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto";
            // 
            // PrestamoIdtextBox
            // 
            this.PrestamoIdtextBox.Location = new System.Drawing.Point(15, 27);
            this.PrestamoIdtextBox.Name = "PrestamoIdtextBox";
            this.PrestamoIdtextBox.Size = new System.Drawing.Size(139, 20);
            this.PrestamoIdtextBox.TabIndex = 5;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(160, 6);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(52, 39);
            this.button.TabIndex = 7;
            this.button.Text = "Buscar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(17, 157);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(276, 20);
            this.MontotextBox.TabIndex = 10;
            // 
            // FechaIdateTimePicker
            // 
            this.FechaIdateTimePicker.Location = new System.Drawing.Point(302, 25);
            this.FechaIdateTimePicker.Name = "FechaIdateTimePicker";
            this.FechaIdateTimePicker.Size = new System.Drawing.Size(275, 20);
            this.FechaIdateTimePicker.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha Inicial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Final:";
            // 
            // FechaFdateTimePicker
            // 
            this.FechaFdateTimePicker.Location = new System.Drawing.Point(302, 64);
            this.FechaFdateTimePicker.Name = "FechaFdateTimePicker";
            this.FechaFdateTimePicker.Size = new System.Drawing.Size(275, 20);
            this.FechaFdateTimePicker.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor Cuota:";
            // 
            // ValorCuotatextBox
            // 
            this.ValorCuotatextBox.Location = new System.Drawing.Point(309, 157);
            this.ValorCuotatextBox.Name = "ValorCuotatextBox";
            this.ValorCuotatextBox.Size = new System.Drawing.Size(123, 20);
            this.ValorCuotatextBox.TabIndex = 16;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 98);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 13);
            this.label.TabIndex = 20;
            this.label.Text = "Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "lnteres";
            // 
            // InterestextBox
            // 
            this.InterestextBox.Location = new System.Drawing.Point(441, 157);
            this.InterestextBox.Name = "InterestextBox";
            this.InterestextBox.Size = new System.Drawing.Size(136, 20);
            this.InterestextBox.TabIndex = 22;
            this.InterestextBox.Text = "0.10";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::SystemPrestamos.Properties.Resources.save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(253, 332);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(59, 59);
            this.Guardarbutton.TabIndex = 26;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::SystemPrestamos.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(345, 332);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(60, 59);
            this.Eliminarbutton.TabIndex = 27;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::SystemPrestamos.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(160, 332);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(60, 54);
            this.Nuevobutton.TabIndex = 25;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(15, 114);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(278, 21);
            this.ClientecomboBox.TabIndex = 28;
            // 
            // Ruta
            // 
            this.Ruta.AutoSize = true;
            this.Ruta.Location = new System.Drawing.Point(306, 98);
            this.Ruta.Name = "Ruta";
            this.Ruta.Size = new System.Drawing.Size(30, 13);
            this.Ruta.TabIndex = 29;
            this.Ruta.Text = "Ruta";
            // 
            // RutacomboBox
            // 
            this.RutacomboBox.FormattingEnabled = true;
            this.RutacomboBox.Location = new System.Drawing.Point(309, 114);
            this.RutacomboBox.Name = "RutacomboBox";
            this.RutacomboBox.Size = new System.Drawing.Size(268, 21);
            this.RutacomboBox.TabIndex = 30;
            this.RutacomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Semana No:";
            // 
            // SemanaNotextBox
            // 
            this.SemanaNotextBox.Location = new System.Drawing.Point(17, 196);
            this.SemanaNotextBox.Name = "SemanaNotextBox";
            this.SemanaNotextBox.Size = new System.Drawing.Size(276, 20);
            this.SemanaNotextBox.TabIndex = 33;
            // 
            // PrestamodataGridView
            // 
            this.PrestamodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrestamodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrestamoId,
            this.Cliente,
            this.RutaId,
            this.SemanaNo,
            this.Cuota});
            this.PrestamodataGridView.Location = new System.Drawing.Point(17, 236);
            this.PrestamodataGridView.Name = "PrestamodataGridView";
            this.PrestamodataGridView.Size = new System.Drawing.Size(560, 90);
            this.PrestamodataGridView.TabIndex = 34;
            // 
            // PrestamoId
            // 
            this.PrestamoId.HeaderText = "PrestamoId";
            this.PrestamoId.Name = "PrestamoId";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // RutaId
            // 
            this.RutaId.HeaderText = "RutaId";
            this.RutaId.Name = "RutaId";
            // 
            // SemanaNo
            // 
            this.SemanaNo.HeaderText = "SemanaNo";
            this.SemanaNo.Name = "SemanaNo";
            // 
            // Cuota
            // 
            this.Cuota.HeaderText = "Cuota";
            this.Cuota.Name = "Cuota";
            // 
            // agregarPrestamobutton
            // 
            this.agregarPrestamobutton.Location = new System.Drawing.Point(515, 196);
            this.agregarPrestamobutton.Name = "agregarPrestamobutton";
            this.agregarPrestamobutton.Size = new System.Drawing.Size(62, 20);
            this.agregarPrestamobutton.TabIndex = 35;
            this.agregarPrestamobutton.Text = "button2";
            this.agregarPrestamobutton.UseVisualStyleBackColor = true;
            this.agregarPrestamobutton.Click += new System.EventHandler(this.agregarPrestamobutton_Click);
            // 
            // RegistroPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 403);
            this.Controls.Add(this.agregarPrestamobutton);
            this.Controls.Add(this.PrestamodataGridView);
            this.Controls.Add(this.SemanaNotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RutacomboBox);
            this.Controls.Add(this.Ruta);
            this.Controls.Add(this.ClientecomboBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.InterestextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ValorCuotatextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FechaFdateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechaIdateTimePicker);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.PrestamoIdtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RegistroPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroPrestamos";
            this.Load += new System.EventHandler(this.RegistroPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrestamodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrestamoIdtextBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.DateTimePicker FechaIdateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FechaFdateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ValorCuotatextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox InterestextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.Label Ruta;
        private System.Windows.Forms.ComboBox RutacomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SemanaNotextBox;
        private System.Windows.Forms.DataGridView PrestamodataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrestamoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemanaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.Button agregarPrestamobutton;
    }
}