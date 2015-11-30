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
    public partial class RegistroPrestamos : Form
    {
        Prestamos prestamo = new Prestamos();
        Clientes cliente = new Clientes();
        Rutas ruta = new Rutas();
        public RegistroPrestamos()
        {
            InitializeComponent();
        }

       

        private void RegistroPrestamos_Load(object sender, EventArgs e)
        {
           
            ClientecomboBox.DataSource = cliente.Listado("*", "1=1", "");
            ClientecomboBox.DisplayMember = "Nombres";
            ClientecomboBox.ValueMember = "ClienteId";

           
            RutacomboBox.DataSource = ruta.Listado("*", "1=1", "");
            RutacomboBox.DisplayMember = "NombreRuta";
            RutacomboBox.ValueMember = "RutaId";
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (PrestamoIdtextBox.TextLength == 0)
            {

                prestamo.ClienteId = Convert.ToInt32(ClientecomboBox.SelectedValue);
                prestamo.RutaId = Convert.ToInt32(RutacomboBox.SelectedValue);
                prestamo.FechaInicial = FechaIdateTimePicker.Text;
                prestamo.FechaVencimiento = FechaFdateTimePicker.Text;
                double id;
                double.TryParse(MontotextBox.Text, out id);
                prestamo.Monto = id;

                int semId;
                int.TryParse(SemanaNotextBox.Text, out semId);
                prestamo.SemanaNo = semId;

                int vlCuota;
                int.TryParse(ValorCuotatextBox.Text, out vlCuota);
                prestamo.Valorcuota = vlCuota;

                double interes;
                double.TryParse(InterestextBox.Text, out interes);
                prestamo.Interes = interes;

                prestamo.Cuota = Convert.ToDouble(MontotextBox.Text) * Convert.ToDouble(InterestextBox.Text);

                if (prestamo.Insertar())
                {
                    MessageBox.Show("prestamo se agrego Correctamente");
                }
                else
                {
                    MessageBox.Show("prestamo no se agrego Correctamente");
                }
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            PrestamoIdtextBox.Clear();
            MontotextBox.Clear();
            SemanaNotextBox.Clear();
            ValorCuotatextBox.Clear();
            PrestamodataGridView.Rows.Clear();

        }

        private void agregarPrestamobutton_Click(object sender, EventArgs e)
        {
            PrestamodataGridView.Rows.Add();
        }

        public bool LlenarDatos()
        {
            if (true)
            {
                MontotextBox.Text = prestamo.Monto.ToString();
                ClientecomboBox.Text = cliente.Listado(" Nombres "," ClienteId ="+prestamo.ClienteId,"").Rows[0]["Nombres"].ToString();
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (prestamo.Buscar(Convert.ToInt32(PrestamoIdtextBox.Text)))
                {
                    LlenarDatos();
                }
            
        }
    }
}
