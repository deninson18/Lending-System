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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrestamoIdtextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
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
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.Ruta = new System.Windows.Forms.Label();
            this.RutacomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SemanaNotextBox = new System.Windows.Forms.TextBox();
            this.PrestamodataGridView = new System.Windows.Forms.DataGridView();
            this.PrestamoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemanaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.agregarPrestamobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
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
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto";
            // 
            // PrestamoIdtextBox
            // 
            this.PrestamoIdtextBox.Location = new System.Drawing.Point(15, 27);
            this.PrestamoIdtextBox.MaxLength = 10;
            this.PrestamoIdtextBox.Name = "PrestamoIdtextBox";
            this.PrestamoIdtextBox.Size = new System.Drawing.Size(139, 20);
            this.PrestamoIdtextBox.TabIndex = 5;
            this.PrestamoIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrestamoIdtextBox_KeyPress);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::SystemPrestamos.Properties.Resources._1442277587_search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(160, 6);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(45, 39);
            this.Buscarbutton.TabIndex = 7;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(17, 157);
            this.MontotextBox.MaxLength = 10;
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(347, 20);
            this.MontotextBox.TabIndex = 10;
            this.MontotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MontotextBox_KeyPress);
            // 
            // FechaIdateTimePicker
            // 
            this.FechaIdateTimePicker.Location = new System.Drawing.Point(388, 27);
            this.FechaIdateTimePicker.Name = "FechaIdateTimePicker";
            this.FechaIdateTimePicker.Size = new System.Drawing.Size(275, 20);
            this.FechaIdateTimePicker.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha Inicial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Final:";
            // 
            // FechaFdateTimePicker
            // 
            this.FechaFdateTimePicker.Location = new System.Drawing.Point(388, 63);
            this.FechaFdateTimePicker.Name = "FechaFdateTimePicker";
            this.FechaFdateTimePicker.Size = new System.Drawing.Size(275, 20);
            this.FechaFdateTimePicker.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor Cuota:";
            // 
            // ValorCuotatextBox
            // 
            this.ValorCuotatextBox.Location = new System.Drawing.Point(383, 157);
            this.ValorCuotatextBox.MaxLength = 2;
            this.ValorCuotatextBox.Name = "ValorCuotatextBox";
            this.ValorCuotatextBox.Size = new System.Drawing.Size(138, 20);
            this.ValorCuotatextBox.TabIndex = 16;
            this.ValorCuotatextBox.Text = "13";
            this.ValorCuotatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorCuotatextBox_KeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 98);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 15);
            this.label.TabIndex = 20;
            this.label.Text = "Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(524, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "lnteres";
            // 
            // InterestextBox
            // 
            this.InterestextBox.Enabled = false;
            this.InterestextBox.Location = new System.Drawing.Point(527, 157);
            this.InterestextBox.MaxLength = 5;
            this.InterestextBox.Name = "InterestextBox";
            this.InterestextBox.Size = new System.Drawing.Size(136, 20);
            this.InterestextBox.TabIndex = 22;
            this.InterestextBox.Text = "0.10";
            this.InterestextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InterestextBox_KeyPress);
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(15, 114);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(349, 21);
            this.ClientecomboBox.TabIndex = 28;
            // 
            // Ruta
            // 
            this.Ruta.AutoSize = true;
            this.Ruta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ruta.Location = new System.Drawing.Point(380, 101);
            this.Ruta.Name = "Ruta";
            this.Ruta.Size = new System.Drawing.Size(37, 15);
            this.Ruta.TabIndex = 29;
            this.Ruta.Text = "Ruta";
            // 
            // RutacomboBox
            // 
            this.RutacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RutacomboBox.FormattingEnabled = true;
            this.RutacomboBox.Location = new System.Drawing.Point(383, 117);
            this.RutacomboBox.Name = "RutacomboBox";
            this.RutacomboBox.Size = new System.Drawing.Size(280, 21);
            this.RutacomboBox.TabIndex = 30;
            this.RutacomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Semana No:";
            // 
            // SemanaNotextBox
            // 
            this.SemanaNotextBox.Location = new System.Drawing.Point(17, 196);
            this.SemanaNotextBox.MaxLength = 2;
            this.SemanaNotextBox.Name = "SemanaNotextBox";
            this.SemanaNotextBox.Size = new System.Drawing.Size(347, 20);
            this.SemanaNotextBox.TabIndex = 33;
            this.SemanaNotextBox.Text = "1";
            this.SemanaNotextBox.TextChanged += new System.EventHandler(this.SemanaNotextBox_TextChanged);
            this.SemanaNotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SemanaNotextBox_KeyPress);
            // 
            // PrestamodataGridView
            // 
            this.PrestamodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrestamodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrestamoId,
            this.ClienteId,
            this.RutaId,
            this.SemanaNo,
            this.Monto,
            this.Cuota});
            this.PrestamodataGridView.Location = new System.Drawing.Point(15, 236);
            this.PrestamodataGridView.Name = "PrestamodataGridView";
            this.PrestamodataGridView.Size = new System.Drawing.Size(648, 115);
            this.PrestamodataGridView.TabIndex = 34;
            // 
            // PrestamoId
            // 
            this.PrestamoId.HeaderText = "PrestamoId";
            this.PrestamoId.Name = "PrestamoId";
            // 
            // ClienteId
            // 
            this.ClienteId.HeaderText = "ClienteId";
            this.ClienteId.Name = "ClienteId";
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
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // Cuota
            // 
            this.Cuota.HeaderText = "Cuota";
            this.Cuota.Name = "Cuota";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // agregarPrestamobutton
            // 
            this.agregarPrestamobutton.Image = global::SystemPrestamos.Properties.Resources.agregar1;
            this.agregarPrestamobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarPrestamobutton.Location = new System.Drawing.Point(580, 196);
            this.agregarPrestamobutton.Name = "agregarPrestamobutton";
            this.agregarPrestamobutton.Size = new System.Drawing.Size(83, 34);
            this.agregarPrestamobutton.TabIndex = 35;
            this.agregarPrestamobutton.Text = "Agregar";
            this.agregarPrestamobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarPrestamobutton.UseVisualStyleBackColor = true;
            this.agregarPrestamobutton.Click += new System.EventHandler(this.agregarPrestamobutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::SystemPrestamos.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(383, 357);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(60, 59);
            this.Eliminarbutton.TabIndex = 27;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::SystemPrestamos.Properties.Resources.save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(294, 357);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(59, 59);
            this.Guardarbutton.TabIndex = 26;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::SystemPrestamos.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(208, 357);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(60, 59);
            this.Nuevobutton.TabIndex = 25;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // RegistroPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 428);
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
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.PrestamoIdtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RegistroPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroPrestamos";
            this.Load += new System.EventHandler(this.RegistroPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrestamodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrestamoIdtextBox;
        private System.Windows.Forms.Button Buscarbutton;
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
        private System.Windows.Forms.Button agregarPrestamobutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrestamoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemanaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}