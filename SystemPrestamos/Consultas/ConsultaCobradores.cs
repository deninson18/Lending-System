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
    public partial class ConsultaCobradores : Form
    {
        ErrorProvider error = new ErrorProvider();
        public ConsultaCobradores()
        {
            InitializeComponent();
            error = new ErrorProvider();
            buscaCobradorcomboBox.SelectedIndex = 0;
        }
        public int Error()
        {
            int cont = 0;
            if (buscaCobradortextBox.TextLength == 0)
            {
                error.SetError(buscaCobradortextBox, "Completar el Campo");
                cont = 1;
            }
            else
            {
                error.SetError(buscaCobradortextBox, " ");
            }
            return cont;
        }


        private void buscaCobradorbutton_Click(object sender, EventArgs e)
        {
            Cobradores cobrador = new Cobradores();
            DataTable data = new DataTable();
            string condicion;
            if(Error() == 0)
            {
                if (buscaCobradorcomboBox.SelectedIndex == 0)
                {
                    if (buscaCobradortextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        int id;
                        int.TryParse(buscaCobradortextBox.Text, out id);
                        condicion = "CobradorId = " + id.ToString();
                    }

                    data = cobrador.Listado("CobradorId,Nombres,Apellidos,Direccion,Telefono,Celular,Cedula", condicion, "");
                    CobradordataGridView.DataSource = data;
                }
                if (buscaCobradorcomboBox.SelectedIndex == 1)
                {
                    if (buscaCobradortextBox.Text.Trim().Length == 1)
                    {
                        condicion = "2=2";
                    }
                    else
                    {

                        condicion = string.Format( "Nombres ='{0}' ", buscaCobradortextBox.Text);

                    }
                    data = cobrador.Listado("CobradorId,Nombres,Apellidos,Direccion,Telefono,Celular,Cedula", condicion, "");
                    CobradordataGridView.DataSource = data;
                }
                if (buscaCobradorcomboBox.SelectedIndex == 2)
                {
                    if (buscaCobradortextBox.Text.Trim().Length == 2)
                    {
                        condicion = "3=3";
                    }
                    else
                    {

                        condicion = string.Format("Apellidos ='{0}' ", buscaCobradortextBox.Text);

                    }
                    data = cobrador.Listado("CobradorId,Nombres,Apellidos,Direccion,Telefono,Celular,Cedula", condicion, "");
                    CobradordataGridView.DataSource = data;
                }
                if (buscaCobradorcomboBox.SelectedIndex == 3)
                {
                    if (buscaCobradortextBox.Text.Trim().Length == 3)
                    {
                        condicion = "4=4";
                    }
                    else
                    {

                        condicion = string.Format("Direccion ='{0}' ", buscaCobradortextBox.Text);

                    }
                    data = cobrador.Listado("CobradorId,Nombres,Apellidos,Direccion,Telefono,Celular,Cedula", condicion, "");
                    CobradordataGridView.DataSource = data;
                }
               

            }
            if (buscaCobradorcomboBox.SelectedIndex == 4)
            {
                if (buscaCobradortextBox.Text.Trim().Length == 4)
                {
                    condicion = "5=5";
                }


                data = cobrador.Listado("CobradorId,Nombres,Apellidos,Direccion,Telefono,Celular,Cedula", "1=1", "");
                CobradordataGridView.DataSource = data;
            }
        }
    }
}
