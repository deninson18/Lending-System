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
using SystemPrestamos.Properties;


namespace SystemPrestamos
{
    public partial class RegistroRutas : Form
    {
        public RegistroRutas()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            RutaIdtextBox.Clear();
            NombreRutatextBox.Clear();
            RutaDetalletextBox.Clear();
            CobradorIdcomboBox.Items.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            Rutas ruta = new Rutas();

            if (NombreRutatextBox.TextLength == 0 || RutaDetalletextBox.TextLength == 0)

            {
                MessageBox.Show("No puede dejar ningun campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
              if (RutaIdtextBox.TextLength == 0)
            {
                ruta.NombreRuta = NombreRutatextBox.Text;
                ruta.Detalle = RutaDetalletextBox.Text;
                ruta.CobradorId = Convert.ToInt32(CobradorIdcomboBox.Text);

                if (ruta.Insertar())
                {
                    MessageBox.Show("Ruta ha sido Registrada");

                }
                else
                {
                    MessageBox.Show("Ruta no ha podido ser Registrada");
                }

             }else if(RutaIdtextBox.TextLength > 0)

            {
                int id;
                int.TryParse(RutaIdtextBox.Text, out id);
                ruta.RutaId = id;
                ruta.NombreRuta = NombreRutatextBox.Text;
                ruta.Detalle = RutaDetalletextBox.Text;
                ruta.CobradorId = Convert.ToInt32(CobradorIdcomboBox.Text);
            }
            if (ruta.Editar())
            {
                MessageBox.Show("Ruta ha sido Editada");

            }
            else
            {
                MessageBox.Show("Ruta no ha sido Editada Correctamente");
            }

        }

        private int TryParse(int textLength, out int id)
        {
            throw new NotImplementedException();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            /*Rutas ruta = new Rutas();
            if (RutaIdtextBox.TextLength == 0)
            {
                ErrorProvider error = new ErrorProvider();
                error.Clear();
                error.SetError(RutaIdtextBox, "Debe especificar el id");
            }
            else
            {
                int id;
                int.TryParse(RutaIdtextBox.Text, out id);
                ruta.Buscar(id);
                RutaIdtextBox.Text = ruta.Cobradores.ToString();
                

            }*/
        }

        private void IdCobradorbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private void RegistroRutas_Load(object sender, EventArgs e)
        {
            Cobradores cobrador = new Cobradores();
            CobradorIdcomboBox.DataSource = cobrador.Listado("*","1=1","");
            CobradorIdcomboBox.DisplayMember = "CobradorId";
            CobradorIdcomboBox.ValueMember = "CobradorId";
        }

        private void RutaIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }
    }
}
