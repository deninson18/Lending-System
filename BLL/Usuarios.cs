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
          
        ConexionDb conexion = new ConexionDb();
         
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string AreaUsuario { get; set; }
        public string Fecha { get; set; }

        public Usuarios()
        {  

            UsuarioId = 0;
            Nombres = "";
            NombreUsuario = "";
            Contrasena = "";
            AreaUsuario = "";
            Fecha = "";
            UsuarioId = 0;
        }

        public Usuarios(string nombre, string nombreUsuario, string contrasena, string areaUsuario,string fecha, int usuarioId)
        {
            Nombres = nombre;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            AreaUsuario = areaUsuario;
            Fecha = fecha;
            UsuarioId = usuarioId;
        }

        public override bool Insertar()
        {
            
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("Insert Into Usuarios(Nombres,NombresUsuarios,Contrasena,AreaUsuarios,Fecha) values('{0}','{1}','{2}','{3}','{4}')", this.Nombres, this.NombreUsuario, this.Contrasena, this.AreaUsuario,this.Fecha));
                return retorno;
           
        }

        public override bool Editar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("Update Usuarios set Nombres='{0}',NombresUsuarios='{1}',Contrasena='{2}',AreaUsuarios='{3}',Fecha='{4}' where UsuarioId={5}", this.Nombres, this.NombreUsuario, this.Contrasena, this.AreaUsuario, this.Fecha, this.UsuarioId));
                return retorno;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Eliminar()
        {
            
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("delete from Usuarios where UsuarioId={0}", this.UsuarioId));
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
                DataTable datatable = new DataTable();
                datatable = conexion.ObtenerDatos(String.Format("select  UsuarioId,Nombres,NombresUsuarios,Contrasena,AreaUsuarios,Fecha from Usuarios where UsuarioId= {0} ", IdBuscado));
                if(datatable.Rows.Count > 0)
                {
                    this.UsuarioId = (int)datatable.Rows[0]["UsuarioId"];
                this.Nombres = datatable.Rows[0]["Nombres"].ToString();
                this.NombreUsuario = datatable.Rows[0]["NombresUsuarios"].ToString();
                this.Contrasena = datatable.Rows[0]["Contrasena"].ToString();
                this.AreaUsuario = datatable.Rows[0]["AreaUsuarios"].ToString();
                }
                return datatable.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            return conexion.ObtenerDatos(("Select " + Campos + " from Usuarios where " + Condicion + Orden));
        }

        public bool Login(string nombre, string contrasena)
        {
               DataTable datatable = new DataTable();
               datatable = conexion.ObtenerDatos(String.Format("select  NombresUsuarios from Usuarios where NombresUsuarios = '{0}' and  Contrasena = '{1}'",nombre,contrasena));
               if (datatable.Rows.Count > 0)
               {
                return true;
               }
            return false;
        }
    }
}
