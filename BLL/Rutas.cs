using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Rutas : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        private int RutaId { set; get; }
        private string NombreRuta { set; get; }
        private int CobradorId { set; get;  }
        private string Detalle { set; get; }
       

        public Rutas()
        {
            this.NombreRuta = "";
            this.CobradorId = 0;
            this.Detalle = "";
            this.RutaId = 0;
        }    

        public Rutas(string nombreruta,int cobradorid,string detalle,int rutaid)
        {
            this.NombreRuta = nombreruta;
            this.CobradorId = cobradorid;
            this.Detalle = detalle;
            this.RutaId = rutaid;
        }

        public override bool Insertar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Insert Into Rutas(NombreRuta,CobradorId,RutaDetalle) values('{0}','{1}','{2}')",this.NombreRuta,this.CobradorId,this.Detalle));
                return true;
            }catch(Exception){ return false; }
        }

        public override bool Editar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Updte Rutas set NombreRuta='{0}',CobradorId='{1}',RutaDetalle='{2}'", this.NombreRuta, this.CobradorId, this.Detalle));
                return true;
            }
            catch (Exception) { return false; }
        }

        public override bool Eliminar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Delete from Rutas(NombreRuta,CobradorId,RutaDetalle) where RutaId)", this.RutaId));
                return true;
            }
            catch (Exception) { return false; }
        }

        public override bool Buscar(int IdBuscado)
        {
            try
            {
                DataTable datatable;
                datatable = conexion.ObtenerDatos(String.Format("select * from Rutas whele RutaId = {0}", RutaId));
                this.NombreRuta = datatable.Rows[0]["NombreRuta"].ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            /*
                DataTable dt = new DataTable();
                DataTable dtCobradores = new DataTable();

            dt = conexion.ObtenerDatos(String.Format("select  NombreRuta,CobradorId,RutaDetalle from Rutas where RutaId='{0}'", IdBuscado));
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

            return conexion.ObtenerDatos(("Select " + Campos + " from Rutas where " + Condicion + ordenFinal));
        }
    }
}
