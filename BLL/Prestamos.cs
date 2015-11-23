using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Prestamos : ClaseMaestra
    {

        ConexionDb conexion = new ConexionDb();

        public int PrestamoId { get; set; }
        public int ClienteId { get; set; } 
        public string Direccion { get; set; }
        public string FechaInicial { get; set; }
        public string FechaVencimiento { get; set; }
        public int RutaId { get; set; }
        public double Capital { get; set; }
        public float Cuotas { get; set; }
        public float Interes { get; set; }
        public string TipoPrestamos { get; set; }

        public Prestamos()
        {
            this.PrestamoId = 0;
            this.ClienteId = 0;
            this.Direccion = "";
            this.FechaInicial = "";
            this.FechaVencimiento = "";
            this.RutaId = 0;
            this.Capital = 0;
            this.Cuotas = 0;
            this.Interes = 0;
            this.TipoPrestamos = "";
        }

        public Prestamos(int prestamoId, int clienteId,string direccion,string fechaInicial, string fechaVencimiento, int rutaId ,float capital, float cuotas, float interes, string tipoPrestamos)
        {
            this.PrestamoId = prestamoId;
            this.ClienteId = clienteId;
            this.Direccion = direccion;
            this.FechaInicial = fechaInicial;
            this.FechaVencimiento = fechaVencimiento;
            this.RutaId = rutaId;
            this.Capital = capital;
            this.Cuotas = cuotas;
            this.Interes = interes;
            this.TipoPrestamos = tipoPrestamos;
        }
        public override bool Insertar()
        {
            /* 
            try
            {
                bool retorno = false;
                StringBuilder Comando = new StringBuilder();
                retorno = conexion.Ejecutar(String.Format("Insert Into Rutas(NombreRuta,RutaDetalle,CobradorId) values('{0}','{1}',{2})",this.NombreRuta,this.Detalle,1));
                if (retorno)
                {
                    this.RutaId = (int)conexion.ObtenerDatos("Select Max(CobradorId) as CobradorId from Cobradores").Rows[0]["CobradorId"];

                    foreach (var cobrador in this.Cobradores)
                    {
                        Comando.AppendLine(String.Format("insert into RutasCobradores(RutaId,CobradorId) Values({0},{1})", this.RutaId, cobrador.CobradorId));

                    }

                    retorno = conexion.Ejecutar(Comando.ToString());
                }
                return retorno;

            }catch(Exception ex)
            {
                throw ex;
            }
            */
            return true;
        }

        public override bool Editar()
        {
            /*
            bool retorno = false;
            StringBuilder Comando = new StringBuilder();

            retorno = conexion.Ejecutar(string.Format("update Peliculas set Titulo = '{0}',Descripcion = '{1}',Ano = '{2}', Calificacion = '{3}',IMDB = '{4}' where PeliculaId = '{5}'", 
                Titulo, Descripcion, Ano, Calificacion, IMDB, this.PeliculaId));


            if (retorno)
            {
                conexion.Ejecutar("Delete From PeliculasActores Where PeliculaId=" + this.PeliculaId );

                foreach (var autor in this.Actores)
                {
                    Comando.AppendLine(String.Format("insert into PeliculasActores(PeliculaId,ActorId) Values({0},{1});", this.PeliculaId, autor.ActorId));

                }

                retorno = conexion.Ejecutar(Comando.ToString());
            }
            return retorno;
            */
            return true;
        }

        public override bool Eliminar()
        {
            try
            {
                bool retorno = false;
                ConexionDb conexion = new ConexionDb();
                retorno = conexion.Ejecutar(String.Format("Delete from Prestamos where PrestamoId={0}", this.PrestamoId));
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Buscar(int IdBuscado)
        {
            /* try
             {
                 DataTable dt = new DataTable();
                 DataTable dtRuta = new DataTable();
                 dt = conexion.ObtenerDatos(String.Format("Select CobradorId,Nombres,Apellidos, Direccion,Telefono,Celular,Cedula from Cobradores where CobradorId= {0} ", IdBuscado));
                 if (dt.Rows.Count > 0)
                 {
                     this.CobradorId = (int)dt.Rows[0]["CobradorId"];
                     this.Nombres = dt.Rows[0]["Nombres"].ToString();
                     this.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                     this.Direccion = dt.Rows[0]["Direccion"].ToString();
                     this.Telefono = dt.Rows[0]["Telefono"].ToString();
                     this.Celular = dt.Rows[0]["Celular"].ToString();
                     this.Cedula = dt.Rows[0]["Cedula"].ToString();
                 }
                 return dt.Rows.Count > 0;
             }
             catch (Exception ex)
             {
                 throw ex;
             }*/
            return true;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = ""; //!orden.Equals("") ? " orden by  " + orden : "";
            if (!Orden.Equals(""))
                ordenFinal = " orden by  " + Orden;

            return conexion.ObtenerDatos(("Select " + Campos + " from RutasPrestamos where " + Condicion + ordenFinal));
        }
    }
}
