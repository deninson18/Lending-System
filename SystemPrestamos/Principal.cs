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
            RegistroClientes cliente = new RegistroClientes();
            cliente.Show();
        }
    }
}
