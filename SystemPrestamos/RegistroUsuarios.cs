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
            Usuarios user = new Usuarios();

            if (NombretextBox.TextLength == 0 || NombreUsuariotextBox.TextLength == 0 || ContrasenatextBox.TextLength == 0 || AreaUsuariotextBox.TextLength == 0)
                
            {
                MessageBox.Show("El campo debe llenarse ");
            }else
            if(UsuarioIdtextBox.TextLength == 0)
            {
                user.Nombre = NombretextBox.Text;
                user.NombreUsuario = NombreUsuariotextBox.Text;
                user.Contrasena = ContrasenatextBox.Text;
                user.AreaUsuario = AreaUsuariotextBox.Text;
                user.Fecha = dateTimePicker.Text;

                if (user.Insertar())
                {
                    MessageBox.Show("Usuario guardado Correctamente");
                }
                else
                {
                    MessageBox.Show("Error! no se guardo el Usuario");
                }
            }else 
                if(UsuarioIdtextBox.TextLength > 0)
                {
                    user.Nombre = NombretextBox.Text;
                    user.NombreUsuario = NombreUsuariotextBox.Text;
                    user.Contrasena = ContrasenatextBox.Text;
                    user.AreaUsuario = AreaUsuariotextBox.Text;
                    user.Fecha = dateTimePicker.Text;

                    if (user.Editar())
                    {
                        MessageBox.Show("Usuario Edito Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error! no se ha Editado el Usuario");
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

            if (UsuarioIdtextBox.TextLength > 0)
            {
                Usuarios user = new Usuarios();
                user.UsuarioId = int.Parse(UsuarioIdtextBox.Text);
                if (user.Eliminar())
                {
                    MessageBox.Show("Usuario se ha Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("Usuario no se ha Eliminado Correctamente");
                }

            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            if (UsuarioIdtextBox.TextLength == 0)
            {
                ErrorProvider error = new ErrorProvider();
                error.Clear();
                error.SetError(UsuarioIdtextBox, "Debe especificar el id");
            }
            else
            {
                int id;
                int.TryParse(UsuarioIdtextBox.Text, out id);
                user.Buscar(id);
                UsuarioIdtextBox.Text = user.UsuarioId.ToString();
                NombretextBox.Text = user.Nombre;
                NombreUsuariotextBox.Text = user.NombreUsuario;
                ContrasenatextBox.Text = user.Contrasena;
                AreaUsuariotextBox.Text = user.AreaUsuario; 
            }
        }
    }
}
