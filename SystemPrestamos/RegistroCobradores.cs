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
    public partial class RegistroCobradores : Form
    {
        Cobradores cobra = new Cobradores();

        public RegistroCobradores()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            CobradorIdtextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
            CelulartextBox.Clear();
            CedulatextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (NombretextBox.TextLength > 0 && ApellidotextBox.TextLength > 0)
            {
                cobra.Nombre = NombretextBox.Text;
                cobra.Apellido = ApellidotextBox.Text;
                cobra.Direccion = DirecciontextBox.Text;
                cobra.Telefono = TelefonotextBox.Text;
                cobra.Celular = CelulartextBox.Text;
                cobra.Cedula = CedulatextBox.Text;

                if (cobra.Insertar())
                {
                    MessageBox.Show("Cobrador se agrego Correctamente");
                }
                else
                {
                    MessageBox.Show("Cobrador no se agrego Correctamente");
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Cobradores cobrador = new Cobradores();
            if (CobradorIdtextBox.TextLength == 0)
            {
                ErrorProvider error = new ErrorProvider();
                error.Clear();
                error.SetError(CobradorIdtextBox, "Debe especificar el id");
            }
            else
            {
                int id;
                int.TryParse(CobradorIdtextBox.Text, out id);
                cobrador.Buscar(id);
                CobradorIdtextBox.Text = cobrador.CobradorId.ToString();
                NombretextBox.Text = cobrador.Nombre;
                ApellidotextBox.Text = cobrador.Apellido;
                DirecciontextBox.Text = cobrador.Direccion;
                TelefonotextBox.Text = cobrador.Telefono;
                CelulartextBox.Text = cobrador.Celular;
                CedulatextBox.Text = cobrador.Cedula;
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (CobradorIdtextBox.TextLength > 0)
            {
                Cobradores cobrador = new Cobradores();
                cobrador.CobradorId = int.Parse(CobradorIdtextBox.Text);
                if (cobrador.Eliminar())
                {
                    MessageBox.Show("Cobrador se elimino Correctamente");
                }
                else
                {
                    MessageBox.Show("Cobrador no se elimino Correctamente");
                }

            }

        }
    }
}
