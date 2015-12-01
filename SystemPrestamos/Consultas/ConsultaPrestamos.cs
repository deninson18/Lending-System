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
    public partial class ConsultaPrestamos : Form
    {
        public ConsultaPrestamos()
        {
            InitializeComponent();
        }

        private void prestamoConsultabutton_Click(object sender, EventArgs e)
        {
            Prestamos prestamo = new Prestamos();
            DataTable data = new DataTable();
            string condicion;

            if (prestamocomboBox.SelectedIndex == 0)
            {
                if (prestamotextBox.Text.Trim().Length == 0)
                {
                    condicion = "1=1 ";
                }
                else
                {
                    int id;
                    int.TryParse(prestamotextBox.Text, out id);
                    condicion = "PrestamoId= " + id.ToString();
                }

                data = prestamo.Listado("ClienteId,RutaId,SemanaNo,ValorCuota,Monto,Cuota", condicion, "");
                PrestamodataGridView.DataSource = data;
            }
            if (prestamocomboBox.SelectedIndex == 1)
            {
                if (prestamotextBox.Text.Trim().Length == 1)
                {
                    condicion = "2=2 ";
                }
                else
                {
                    int id;
                    int.TryParse(prestamotextBox.Text, out id);
                    condicion = " Monto= " + id.ToString();
                }

                data = prestamo.Listado("ClienteId,RutaId,SemanaNo,ValorCuota,Monto,Cuota", condicion, "");
                PrestamodataGridView.DataSource = data;
            }
        }
    }
}
