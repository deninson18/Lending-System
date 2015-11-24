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
    public partial class ConsultaRutas : Form
    {
       
        public ConsultaRutas()
        {
            InitializeComponent();
          
          
        }
     
       

        private void buscaRutabutton_Click(object sender, EventArgs e)
        {
            Rutas ruta = new Rutas();
            DataTable data = new DataTable();
            string condicion;
           
                if (buscaRutacomboBox.SelectedIndex == 0)
                {
                    if (buscaRutatextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1 ";
                    }
                    else
                    {
                        int id;
                        int.TryParse(buscaRutatextBox.Text, out id);
                        condicion = "RutaId= " + id.ToString();
                    }

                    data = ruta.Listado("RutaId,NombreRuta", condicion, "");
                    RutasdataGridView.DataSource = data;
                }
                if (buscaRutacomboBox.SelectedIndex == 1)
                {
                    if (buscaRutatextBox.Text.Trim().Length == 1)
                    {
                        condicion = "2=2";
                    }
                    else
                    {

                        condicion = string.Format("NombreRuta ='{0}' ", buscaRutatextBox.Text);

                    }
                    data = ruta.Listado("RutaId,NombreRuta", condicion, "");
                    RutasdataGridView.DataSource = data;
                }
            
           
        }
    }
}
