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
        Usuarios user = new Usuarios();
        public string Usuario { get; set; }
       public string contrasena { get; set; }

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


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            if (user.Login(usuarioTextBox.Text, ContrasenaTextBox.Text) == true)
             {
                Principal menu = new Principal();
                 menu.Show();
                this.Visible = false;
             }
             else
             {
                 MessageBox.Show("Usuario o Contraseña Incorrectas");
        }
        }

        private void SysPrestamoslabel_Click(object sender, EventArgs e)
        {

        }

        private void usuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ContrasenaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContrasenaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
