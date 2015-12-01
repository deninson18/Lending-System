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
    public partial class ConsultaAtrasos : Form
    {
        public ConsultaAtrasos()
        {
            InitializeComponent();
        }

        private void consultaAtrasobutton_Click(object sender, EventArgs e)
        {
            Atrasos atraso = new Atrasos();
            DataTable data = new DataTable();
            string condicion;

            if (AtrasocomboBox.SelectedIndex == 0)
            {
                if (AtrasotextBox.Text.Trim().Length == 0)
                {
                    condicion = "1=1 ";
                }
                else
                {
                    int id;
                    int.TryParse(AtrasotextBox.Text, out id);
                    condicion = "AtrasoId= " + id.ToString();
                }

                data = atraso.Listado("PrestamoId,Cantidad,Atraso", condicion, "");
                AtrasodataGridView.DataSource = data;
            }
            if (AtrasocomboBox.SelectedIndex == 1)
            {
                if (AtrasotextBox.Text.Trim().Length == 1)
                {
                    condicion = "2=2 ";
                }
                else
                {
                    int id;
                    int.TryParse(AtrasotextBox.Text, out id);
                    condicion = "Atraso = " + id.ToString();
                }

                data = atraso.Listado("PrestamoId,Cantidad,Atraso", condicion, "");
                AtrasodataGridView.DataSource = data;
            }
        }
    }
}
