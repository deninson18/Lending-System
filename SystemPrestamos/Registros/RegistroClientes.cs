﻿using System;
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

    public partial class RegistroClientes : Form

    {

        public RegistroClientes()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (idCtextBox.TextLength > 0)
            {
                Clientes cliente = new Clientes();
                cliente.ClienteId = int.Parse(idCtextBox.Text);
                if (cliente.Eliminar())
                {
                    MessageBox.Show("Cliente ha sido Eliminado");
                }
                else
                {
                    MessageBox.Show("Cliente no ha sido Eliminado");
                }

            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            idCtextBox.Clear();
            nombreCtextBox.Clear();
            apellidoCtextBox.Clear();
            apodoCtextBox.Clear();
            direccionCtextBox.Clear();
            referenciaCtextBox.Clear();
            cedulaCtextBox.Clear();
            telefonoCtextBox.Clear();
            celularCtextBox.Clear();
        }


        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            if (nombreCtextBox.Text.Length == 0 || apellidoCtextBox.Text.Length == 0 || direccionCtextBox.Text.Length == 0 || direccionCtextBox.Text.Length == 0 || cedulaCtextBox.Text.Length == 0)
            {
                MessageBox.Show("No puede dejar ningun campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                if(idCtextBox.TextLength == 0) { 
                cliente.Nombres = nombreCtextBox.Text;
            cliente.Apellidos = apellidoCtextBox.Text;
            cliente.Apodos = apodoCtextBox.Text;
            cliente.Direccion = direccionCtextBox.Text;
            cliente.Referencia = referenciaCtextBox.Text;
                cliente.Cedula = cedulaCtextBox.Text;
                cliente.Telefono = telefonoCtextBox.Text;
                cliente.Celular = celularCtextBox.Text;
                if (MasculinoradioButton.Checked)
            {
                cliente.Sexo = 1;
            }
            else
            {
                cliente.Sexo = 0;
            }

           
                if (cliente.Insertar())
                {
                    MessageBox.Show("Cliente ha sido Registrado");
                }
                else
                {
                    MessageBox.Show("Cliente no ha sido Registrado");
                }

            }
            else if (idCtextBox.TextLength > 0)
            {
                int CliId;
                int.TryParse(idCtextBox.Text, out CliId);
                cliente.ClienteId = CliId;
                cliente.Nombres = nombreCtextBox.Text;
                cliente.Apellidos = apellidoCtextBox.Text;
                cliente.Apodos = apodoCtextBox.Text;
                cliente.Direccion = direccionCtextBox.Text;
                cliente.Referencia = referenciaCtextBox.Text;
                cliente.Cedula = cedulaCtextBox.Text;
                cliente.Telefono = telefonoCtextBox.Text;
                cliente.Celular = celularCtextBox.Text;

                if (cliente.Editar())
                {
                    MessageBox.Show("Cliente ha sido Editado");
                }
                else
                {
                    MessageBox.Show("Cliente no ha sido Editado");
                }
            }
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            if (idCtextBox.Text.Trim() == "")
            {
                ClienteerrorProvider.SetError(idCtextBox, "Especifica el Cliente Id");
                idCtextBox.Focus();
            }
            else
            {
                ClienteerrorProvider.Clear();
            }
            
            if(idCtextBox.TextLength > 0) { 
                int id;
                int.TryParse(idCtextBox.Text, out id);
                cliente.Buscar(id);
                
                   nombreCtextBox.Text = cliente.Nombres;
                    apellidoCtextBox.Text = cliente.Apellidos;
                    apodoCtextBox.Text = cliente.Apodos;
                    direccionCtextBox.Text = cliente.Direccion;
                    referenciaCtextBox.Text = cliente.Referencia;
                    cedulaCtextBox.Text = cliente.Cedula;
                    celularCtextBox.Text = cliente.Celular;
                    telefonoCtextBox.Text = cliente.Telefono;
                    if (cliente.Sexo == 1)
                    {
                        MasculinoradioButton.Checked = true;

                    }
                    else
                    {
                        FemeninoradioButton.Checked = true;
                    }
                }
              
            }

        private void nombreCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Letras(e);
        }

        private void apellidoCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Letras(e);
        }

        private void apodoCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Letras(e);
        }

        private void idCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void cedulaCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void telefonoCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void celularCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }
    }
}
