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
        Atrasos atraso = new Atrasos();
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

            if (MontotextBox.Text.Length == 0  || ValorCuotatextBox.TextLength== 0 || InterestextBox.TextLength==0 || SemanaNotextBox.TextLength==0)
            {
                MessageBox.Show("El campos Por Llenar ");

            } else
                if(PrestamoIdtextBox.TextLength == 0) { 

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

                if (prestamo.Insertar())
                {
                    MessageBox.Show("prestamo se agrego Correctamente");
                }
                else
                {
                    MessageBox.Show("prestamo no se agrego Correctamente");
                }
            }
            else
                if (PrestamoIdtextBox.TextLength > 0)
            {
                int preId;
                int.TryParse(PrestamoIdtextBox.Text, out preId);
                prestamo.PrestamoId = preId;

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
                if (prestamo.Editar())
                {
                    MessageBox.Show("Prestamo se Edito Correctamente");
                }
                else
                {
                    MessageBox.Show("Prestamo no se Edito Correctamente");
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
            prestamo.Cuota = Convert.ToDouble(MontotextBox.Text) * Convert.ToDouble(InterestextBox.Text);
            PrestamodataGridView.Rows.Add(PrestamoIdtextBox.Text,ClientecomboBox.SelectedValue,RutacomboBox.SelectedValue,SemanaNotextBox.Text,MontotextBox.Text, prestamo.Cuota);
        }

        public bool LlenarDatos()
        {
            if (true)
            {
                MontotextBox.Text = prestamo.Monto.ToString();
                ValorCuotatextBox.Text = prestamo.Valorcuota.ToString();
                SemanaNotextBox.Text = prestamo.SemanaNo.ToString();
                ClientecomboBox.Text = cliente.Listado(" Nombres "," ClienteId ="+prestamo.ClienteId,"").Rows[0]["Nombres"].ToString();
                RutacomboBox.Text = ruta.Listado("NombreRuta", "RutaId =" + prestamo.RutaId, "").Rows[0]["NombreRuta"].ToString();
              
                return true;
            }
        } 

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (prestamo.Buscar(Convert.ToInt32(PrestamoIdtextBox.Text)))
            {
                LlenarDatos();
            }
    }

        private void PrestamoIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void MontotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void SemanaNotextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ValorCuotatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void InterestextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void SemanaNotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }
    }
}
