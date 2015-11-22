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
            if (NombretextBox.TextLength == 0 || ApellidotextBox.TextLength == 0 || DirecciontextBox.TextLength == 0 || TelefonotextBox.TextLength == 0 || CelulartextBox.TextLength == 0 || CedulatextBox.TextLength == 0)
            {
                MessageBox.Show("El campo debe estar lleno ");
            }else
            if(CobradorIdtextBox.TextLength == 0)
            {
                cobra.Nombres = NombretextBox.Text;
                cobra.Apellidos = ApellidotextBox.Text;
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
            }else
                if (CobradorIdtextBox.TextLength > 0)
                {
                    cobra.Nombres = NombretextBox.Text;
                    cobra.Apellidos = ApellidotextBox.Text;
                    cobra.Direccion = DirecciontextBox.Text;
                    cobra.Telefono = TelefonotextBox.Text;
                    cobra.Celular = CelulartextBox.Text;
                    cobra.Cedula = CedulatextBox.Text;

                    if (cobra.Editar())
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
                NombretextBox.Text = cobrador.Nombres;
                ApellidotextBox.Text = cobrador.Apellidos;
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

        private void CobradorIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void TelefonotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void CelulartextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void CedulatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Letras(e);
        }

        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Letras(e);
        }
    }
}
