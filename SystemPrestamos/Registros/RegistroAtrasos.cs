using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace SystemPrestamos
{
    public partial class RegistroAtrasos : Form
    {
        Atrasos atraso = new Atrasos();
        Prestamos prestamo = new Prestamos();
        public RegistroAtrasos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (CantidadtextBox.Text.Length == 0 || AtrasotextBox.TextLength == 0 )
            {
                MessageBox.Show("El campo debe estar lleno ");

            }
            else
                 if (atrasoIdtextBox.TextLength == 0)
            {

                atraso.PrestamoId = Convert.ToInt32(AtrasocomboBox.SelectedValue);
         
            int id;
            int.TryParse(CantidadtextBox.Text, out id);
            atraso.Cantidad = id;

            double atrasos;
            double.TryParse(AtrasotextBox.Text, out atrasos);
            atraso.Atraso = atrasos;

           

                if (atraso.Insertar())
                {
                    MessageBox.Show("Atraso se agrego Correctamente");
                }
                else
                {
                    MessageBox.Show("Atraso no se agrego Correctamente");
                }
            }
            else
                if (atrasoIdtextBox.TextLength > 0)
            {
                atraso.AtrasosId = Convert.ToInt32(atrasoIdtextBox.Text);
                if (atraso.Editar())
                {
                    MessageBox.Show("Atraso se Edito Correctamente");
                }
                else
                {
                    MessageBox.Show("Atraso no se Edito Correctamente");
                }
            }
        }

        private void RegistroAtrasos_Load(object sender, EventArgs e)
        {
            AtrasocomboBox.DataSource = prestamo.Listado("*", "1=1", "");
           AtrasocomboBox.DisplayMember = "PrestamoId";
            AtrasocomboBox.ValueMember = "PrestamoId";
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            atrasoIdtextBox.Clear();
            CantidadtextBox.Clear();
            AtrasotextBox.Clear();
            AtrasodataGridView.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            atraso.Total = Convert.ToInt32(CantidadtextBox.Text) * Convert.ToDouble(AtrasotextBox.Text);
            AtrasodataGridView.Rows.Add(AtrasocomboBox.SelectedValue, CantidadtextBox.Text, AtrasotextBox.Text, atraso.Total);
        }
        private void LlenarDatos()
        {
            CantidadtextBox.Text = atraso.Cantidad.ToString();
            AtrasotextBox.Text = atraso.Atraso.ToString();
            AtrasocomboBox.Text = prestamo.Listado(" PrestamoId ", " PrestamoId =" + atraso.PrestamoId, "").Rows[0]["PrestamoId"].ToString();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (atraso.Buscar(Convert.ToInt32(atrasoIdtextBox.Text)))
            {
                LlenarDatos();
            }
        }

        private void atrasoIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void AtrasocomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void AtrasotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }
    }
}
