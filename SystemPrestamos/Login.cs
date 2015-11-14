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

    public partial class Login : Form
    {
        private string Usuario { get; set; }
        private string contrasena { get; set; }

        public Login()
        {
            InitializeComponent();
            this.Usuario = "";
            this.contrasena = "";
        }

        public Login(string usuario, string contrasena)
        {
            this.Usuario = usuario;
            this.contrasena = contrasena;
        }
       

        private void CancelarButton_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();

            //user.NombreUsuario = usuarioTextBox.Text;
            //user.Contrasena = ContrasenaTextBox.Text;
             if (usuarioTextBox.Text == "deninson" && ContrasenaTextBox.Text=="12345")
             {
                 Principal menu =new Principal();
                 menu.Show();
             }
             else
             {
                 MessageBox.Show("Usuario o Contraseña Incorrectas");
             }
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
