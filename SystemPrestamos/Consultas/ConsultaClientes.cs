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
    public partial class ConsultaClientes : Form
    {
       
        public ConsultaClientes()
        {
            InitializeComponent();
          
           
        }
       
        

        private void buscaClientebutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            DataTable data = new DataTable();
            string condicion;

                if (buscaClientecomboBox.SelectedIndex == 0)
                {
                    if (buscaClientetextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        
                        condicion = "ClienteId = " + buscaClientetextBox.Text;
                 
                }
                    data = cliente.Listado("ClienteId,Nombres,Apellidos,Direccion,Cedula",condicion,"");
                    ClientedataGridView.DataSource = data;
                
            }
            if (buscaClientecomboBox.SelectedIndex == 1)
            {
                if (buscaClientetextBox.Text.Trim().Length == 1)
                {
                    condicion = "2=2";
                }
                else
                {

                    condicion = string.Format("Nombres ='{0}' ", buscaClientetextBox.Text);
                }
                data = cliente.Listado("ClienteId,Nombres,Apellidos,Direccion,Cedula", condicion, "");
                ClientedataGridView.DataSource = data;

            }
            if (buscaClientecomboBox.SelectedIndex == 2)
            {
                if (buscaClientetextBox.Text.Trim().Length == 2)
                {
                    condicion = "3=3";
                }
                else
                {

                    condicion = string.Format("Apellidos ='{0}' ", buscaClientetextBox.Text);
                }
                data = cliente.Listado("ClienteId,Nombres,Apellidos,Direccion,Cedula", condicion, "");
                ClientedataGridView.DataSource = data;

            }
            if (buscaClientecomboBox.SelectedIndex == 3)
            {
                if (buscaClientetextBox.Text.Trim().Length == 3)
                {
                    condicion = "4=4";
                }
                else
                {

                    condicion = string.Format("Direccion ='{0}' ", buscaClientetextBox.Text);
                }
                data = cliente.Listado("ClienteId,Nombres,Apellidos,Direccion,Cedula,RutaId", condicion, "");
                ClientedataGridView.DataSource = data;

            }
          


        }
    }
}
