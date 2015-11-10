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
    public partial class RegistroUsuario : Form
    {
        

        public RegistroUsuario()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            NombreUsuariotextBox.Clear();
            ContrasenatextBox.Clear();
            InsertarImgpictureBox.Image = null;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            if (NombretextBox.TextLength > 0 && NombreUsuariotextBox.TextLength > 0)
            {
                user.Nombre = NombretextBox.Text;
                user.NombreUsuario = NombreUsuariotextBox.Text;
                user.Contrasena = ContrasenatextBox.Text;
                user.Fecha = dateTimePicker.ToString();
            }
            if(user.Insertar())
            {
                MessageBox.Show("Usuario guardado Correctamente");
            }
            else
            {
                MessageBox.Show("Error! no se guardo el Usuario");
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
    }
}
