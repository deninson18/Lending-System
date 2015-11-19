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
            if(NombreRutatextBox.TextLength > 0 && RutaDetalletextBox.TextLength > 0)
            {
                //ruta.NombreRuta = NombreRutatextBox.Text;
            }
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
    }
}
