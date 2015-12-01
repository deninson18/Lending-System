using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SystemPrestamos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
            
        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes registro = new RegistroClientes();
          
            registro.Show();
        }

        private void cobradoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroCobradores cobrador = new RegistroCobradores();
            cobrador.Show();
        }

        private void rutasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroRutas ruta = new RegistroRutas();
            ruta.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void cobradoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaCobradores cobrador = new Consultas.ConsultaCobradores();
            cobrador.Show();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login usuario = new Login();
            usuario.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuarios usuario = new RegistroUsuarios();
            usuario.Show();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuario usuario = new Consultas.ConsultaUsuario();
            usuario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaClientes cliente = new Consultas.ConsultaClientes();
            cliente.Show();
        }

        private void rutasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaRutas ruta = new Consultas.ConsultaRutas();
            ruta.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPrestamos prestamos = new RegistroPrestamos();
            prestamos.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.PrestamosReportes pr = new Reportes.PrestamosReportes();
            pr.Show();
        }

        private void atrasosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroAtrasos atraso = new RegistroAtrasos();
            atraso.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaPrestamos prestamo = new Consultas.ConsultaPrestamos();
            prestamo.Show();
        }

        private void atrasosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaAtrasos atraso = new Consultas.ConsultaAtrasos();
            atraso.Show();
        }
    }
}
