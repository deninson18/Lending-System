namespace SystemPrestamos
{
    partial class RegistroAtrasos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.atrasoIdtextBox = new System.Windows.Forms.TextBox();
            this.AtrasocomboBox = new System.Windows.Forms.ComboBox();
            this.AtrasotextBox = new System.Windows.Forms.TextBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.AtrasodataGridView = new System.Windows.Forms.DataGridView();
            this.PrestamoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atrasos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AtrasodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atraso Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PrestamoId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Atraso";
            // 
            // atrasoIdtextBox
            // 
            this.atrasoIdtextBox.Location = new System.Drawing.Point(15, 25);
            this.atrasoIdtextBox.MaxLength = 10;
            this.atrasoIdtextBox.Name = "atrasoIdtextBox";
            this.atrasoIdtextBox.Size = new System.Drawing.Size(146, 20);
            this.atrasoIdtextBox.TabIndex = 5;
            this.atrasoIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.atrasoIdtextBox_KeyPress);
            // 
            // AtrasocomboBox
            // 
            this.AtrasocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AtrasocomboBox.FormattingEnabled = true;
            this.AtrasocomboBox.Location = new System.Drawing.Point(15, 86);
            this.AtrasocomboBox.Name = "AtrasocomboBox";
            this.AtrasocomboBox.Size = new System.Drawing.Size(337, 21);
            this.AtrasocomboBox.TabIndex = 6;
            this.AtrasocomboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AtrasocomboBox_KeyPress);
            // 
            // AtrasotextBox
            // 
            this.AtrasotextBox.Location = new System.Drawing.Point(15, 168);
            this.AtrasotextBox.MaxLength = 5;
            this.AtrasotextBox.Name = "AtrasotextBox";
            this.AtrasotextBox.Size = new System.Drawing.Size(337, 20);
            this.AtrasotextBox.TabIndex = 7;
            this.AtrasotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AtrasotextBox_KeyPress);
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(15, 129);
            this.CantidadtextBox.MaxLength = 2;
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(337, 20);
            this.CantidadtextBox.TabIndex = 8;
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // AtrasodataGridView
            // 
            this.AtrasodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AtrasodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrestamoId,
            this.Cantidad,
            this.Atrasos,
            this.Total});
            this.AtrasodataGridView.Location = new System.Drawing.Point(15, 212);
            this.AtrasodataGridView.Name = "AtrasodataGridView";
            this.AtrasodataGridView.Size = new System.Drawing.Size(441, 120);
            this.AtrasodataGridView.TabIndex = 13;
            // 
            // PrestamoId
            // 
            this.PrestamoId.HeaderText = "PrestamoId";
            this.PrestamoId.Name = "PrestamoId";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Atrasos
            // 
            this.Atrasos.HeaderText = "Atrasos";
            this.Atrasos.Name = "Atrasos";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // button2
            // 
            this.button2.Image = global::SystemPrestamos.Properties.Resources.agregar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(376, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "Agregar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::SystemPrestamos.Properties.Resources.save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(195, 338);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(58, 63);
            this.Guardarbutton.TabIndex = 12;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::SystemPrestamos.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(279, 338);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(60, 60);
            this.Eliminarbutton.TabIndex = 11;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::SystemPrestamos.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(117, 338);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(57, 63);
            this.Nuevobutton.TabIndex = 9;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::SystemPrestamos.Properties.Resources._1442277587_search;
            this.Buscarbutton.Location = new System.Drawing.Point(167, 9);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(39, 39);
            this.Buscarbutton.TabIndex = 4;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistroAtrasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AtrasodataGridView);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.AtrasotextBox);
            this.Controls.Add(this.AtrasocomboBox);
            this.Controls.Add(this.atrasoIdtextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RegistroAtrasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroAtrasos";
            this.Load += new System.EventHandler(this.RegistroAtrasos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AtrasodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox atrasoIdtextBox;
        private System.Windows.Forms.ComboBox AtrasocomboBox;
        private System.Windows.Forms.TextBox AtrasotextBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.DataGridView AtrasodataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrestamoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atrasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button2;
    }
}