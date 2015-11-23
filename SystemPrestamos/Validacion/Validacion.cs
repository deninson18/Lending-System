using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemPrestamos.Validacion
{
    class Validacion
    {
     
       public void Letras(KeyPressEventArgs e)
        {
        try{
            if (char.IsLetter(e.KeyChar))
            {
                    e.Handled = false;

            } else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            } else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                    MessageBox.Show(" SOLO SE ACEPTAN LETRAS ", " Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }catch(Exception ex)
            {
                throw ex;
            }
       }

        public void Numeros(KeyPressEventArgs e)
        {
        try { 

            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                    MessageBox.Show(" SOLO SE ACEPTAN NUMEROS "," Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          }catch(Exception ex)
            {
                throw ex;
            }
       }
    }
}
