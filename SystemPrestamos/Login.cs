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
        public Login()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            string Usuario = "deninson";
            string contrasena = "12345";

            if (usuarioTextBox.Text == Usuario && ContrasenaTextBox.Text==contrasena)
            {
                Principal menu =new Principal();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectas");
            }
            {

            }
            



        }
    }
}
