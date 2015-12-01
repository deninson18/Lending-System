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
    public partial class RegistroUsuarios : Form
    {
        Usuarios user = new Usuarios();

        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            UsuarioIdtextBox.Clear();
            NombretextBox.Clear();
            NombreUsuariotextBox.Clear();
            ContrasenatextBox.Clear();
            AreaUsuariotextBox.Clear();
            InsertarImgpictureBox.Image = null;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (NombretextBox.TextLength == 0 || NombreUsuariotextBox.TextLength == 0 || ContrasenatextBox.TextLength == 0 || AreaUsuariotextBox.TextLength == 0)

            {
                MessageBox.Show("Faltan Campos Por Llenar ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if (UsuarioIdtextBox.TextLength == 0)
            {
                user.Nombres = NombretextBox.Text;
                user.NombreUsuario = NombreUsuariotextBox.Text;
                user.Contrasena = ContrasenatextBox.Text;
                user.AreaUsuario = AreaUsuariotextBox.Text;
                user.Fecha = dateTimePicker.Text;

                if (user.Insertar())
                {
                    MessageBox.Show("Usuario guardado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevobutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error! no se guardo el Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                if (UsuarioIdtextBox.TextLength > 0)
            {

                int usId;
                int.TryParse(UsuarioIdtextBox.Text, out usId);
                user.UsuarioId = usId;
                user.Nombres = NombretextBox.Text;
                user.NombreUsuario = NombreUsuariotextBox.Text;
                user.Contrasena = ContrasenatextBox.Text;
                user.AreaUsuario = AreaUsuariotextBox.Text;
                user.Fecha = dateTimePicker.Text;

            if (user.Editar())
                {
                    MessageBox.Show("Usuario Edito Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error! no se  Edito el Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AgregarImgbutton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\user\\Pictures";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                InsertarImgpictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {


            if (UsuarioIdtextBox.TextLength == 0)
            {
                MessageBox.Show("Debe especificar el ID", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (UsuarioIdtextBox.Text.Length > 0)
                {

                    int usId;
                    int.TryParse(UsuarioIdtextBox.Text, out usId);
                    user.UsuarioId = usId;
                    if (user.Eliminar())
                    {
                        MessageBox.Show("Usuario Eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Nuevobutton.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (UsuarioIdtextBox.Text.Trim() == "")
            {
                errorProvider.SetError(UsuarioIdtextBox, "especificar Id");
                UsuarioIdtextBox.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
            if (UsuarioIdtextBox.TextLength >  0)
            {
                int id;
                int.TryParse(UsuarioIdtextBox.Text, out id);
                user.Buscar(id);
                NombretextBox.Text = user.Nombres;
                NombreUsuariotextBox.Text = user.NombreUsuario;
                ContrasenatextBox.Text = user.Contrasena;
                AreaUsuariotextBox.Text = user.AreaUsuario;
            }
            
            
        }

        private void UsuarioIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Letras(e);
        }

        private void AreaUsuariotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Letras(e);
        }

        private void UsuarioIdtextBox_Validated(object sender, EventArgs e)
        {
           
        }

        private void NombretextBox_Validated(object sender, EventArgs e)
        {

        }
    }
}
