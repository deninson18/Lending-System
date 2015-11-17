using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{

    public class Usuarios : ClaseMaestra
    {
        /* public string  Nombre { get; set; }
         public string Apellido { get; set; }
         public string Direccion { get; set; }
         public int Telefono{ get; set; }*/

        ConexionDb conexion = new ConexionDb();

        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Fecha { get; set; }

        public Usuarios()
        {

            Nombre = "";
            NombreUsuario = "";
            Contrasena = "";
            Fecha = "";
            UsuarioId = 0;
        }

        public Usuarios(string nombre, string nombreUsuario, string contrasena, string fecha, int usuarioId)
        {
            Nombre = nombre;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Fecha = fecha;
            UsuarioId = usuarioId;
        }

        public override bool Insertar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Insert Into Usuarios(Nombres,NombresUsuarios,Contrasena,Fecha) values('{0}','{1}','{2}','{3}')", this.Nombre, this.NombreUsuario, this.Contrasena, this.Fecha));
                return true;
            }
            catch (Exception) { return false; }
        }

        public override bool Editar()
        {
            bool retorno = false;
            conexion.Ejecutar(String.Format("Update Usuarios set Nombres='{0}',NombresUsuarios='{1}',Contrasena='{2}',Fecha='{3}'", this.Nombre, this.NombreUsuario, this.Contrasena, this.Fecha));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            conexion.Ejecutar(String.Format("Delete from Usuarios where UsuarioId", this.UsuarioId));
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            try
            {
                DataTable datatable;
                datatable = conexion.ObtenerDatos(String.Format("select * from Usuarios whele UsuarioId = {0}", UsuarioId));
                this.Nombre = datatable.Rows[0]["Nombre"].ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            /*
                DataTable dt = new DataTable();
           DataTable dtActores = new DataTable();

           dt = conexion.ObtenerDatos(String.Format("select  PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId,Foto,Video from Peliculas where PeliculaId='{0}'", IdBuscado));
           if (dt.Rows.Count > 0)
           {
               this.PeliculaId = (int)dt.Rows[0]["PeliculaId"];
               this.Titulo = dt.Rows[0]["Titulo"].ToString();
               this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
               this.Ano = (int)dt.Rows[0]["Ano"];
               this.Calificacion = (int)dt.Rows[0]["Calificacion"];


               dtActores = conexion.ObtenerDatos("Select p.ActorId,a.Nombre " +
                                                   "From PeliculasActores p " +
                                                   "Inner Join Actores a On p.ActorId=a.ActorId" +
                                                   "Where p.PeliculaId=" + this.PeliculaId);

               foreach (DataRow row in dtActores.Rows)
               {
                   this.AgregarActor((int)row["ActorId"], row["Nombre"].ToString());
               }
           }

               return dt.Rows.Count > 0;
           */
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = ""; //!orden.Equals("") ? " orden by  " + orden : "";
            if (!Orden.Equals(""))
                ordenFinal = " orden by  " + Orden;

            return conexion.ObtenerDatos(("Select " + Campos + " from Usuarios where " + Condicion + ordenFinal));
        }
    }
}
