using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL 
{

    public class Usuarios:ClaseMaestra
    {
       /* public string  Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono{ get; set; }*/

        ConexionDb conexion = new ConexionDb();

        public string Nombre { set; get; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Fecha { get; set; }

        public Usuarios()
        {
            Nombre = "";
            NombreUsuario = "";
            Contrasena = "";
            Fecha = "";
        }

        public Usuarios(string nombre,string nombreUsuario,string contrasena,string fecha)
        {
            Nombre = nombre;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Fecha = fecha;
        }

        public override bool Insertar()
        {
            bool retorno = false;
             conexion.Ejecutar(string.Format("insert into Usuarios(Nombres,NombreUsuarios,Contrasena,Facha) values('{1}','{2}','{3}','{4}')", this.Nombre, this.NombreUsuario, this.Contrasena, this.Fecha));
            return retorno;
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
