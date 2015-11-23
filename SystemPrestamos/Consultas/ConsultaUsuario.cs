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
        ErrorProvider error = new ErrorProvider();
        public ConsultaUsuario()
        {
            InitializeComponent();

            error = new ErrorProvider();
            buscaUscomboBox.SelectedIndex = 0;
        }
        public int Error()
        {
            int cont = 0;
            if (buscaUstextBox.TextLength == 0)
            {
                error.SetError(buscaUstextBox, "Completar el Campo");
                cont = 1;
            }
            else
            {
                error.SetError(buscaUstextBox, "");
            }
            return cont;
        }

        private void buscaUsuariobutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            DataTable data = new DataTable();
            string condicion;
            if (Error() == 0)
            {
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
           
            if (buscaUscomboBox.SelectedIndex == 2)
            {
                if (buscaUstextBox.Text.Trim().Length == 2)
                {
                    condicion = "3=3";
                }

                data = usuario.Listado("UsuarioId, Nombres,NombresUsuarios,AreaUsuarios,Fecha", "3=3", "");
                UsdataGridView.DataSource = data;
            }
        }
        
    }
}
