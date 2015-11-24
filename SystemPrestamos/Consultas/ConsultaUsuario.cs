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

namespace SystemPrestamos.Consultas
{
    public partial class ConsultaUsuario : Form
    {
     
        public ConsultaUsuario()
        {
            InitializeComponent();

            
        }
      

        private void buscaUsuariobutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            DataTable data = new DataTable();
            string condicion;
           
                if (buscaUscomboBox.SelectedIndex == 0)
                {
                    if (buscaUstextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        int id;
                        int.TryParse(buscaUstextBox.Text, out id);
                        condicion = "UsuarioId = " + id.ToString();
                    }
                    data = usuario.Listado("UsuarioId, Nombres,NombresUsuarios,AreaUsuarios,Fecha", condicion, "");
                    UsdataGridView.DataSource = data;

                }
                if (buscaUscomboBox.SelectedIndex == 1)
                {
                    if (buscaUstextBox.Text.Trim().Length == 1)
                    {
                        condicion = "2=2";
                    }
                    else
                    {

                        condicion = string.Format("Nombres ='{0}' ", buscaUstextBox.Text);
                    }
                    data = usuario.Listado("UsuarioId, Nombres,NombresUsuarios,AreaUsuarios,Fecha", condicion, "");
                    UsdataGridView.DataSource = data;

                }

        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
