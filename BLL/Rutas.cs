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
        private string Nombre { get; set; }

        List<Cobradores> cobradores;

        public Rutas()
        {
            this.NombreRuta = "";
            this.CobradorId = 0;
            this.Detalle = "";
            this.RutaId = 0;
            cobradores = new List<Cobradores>();
        }    

        public Rutas(string nombreruta,int cobradorid,string detalle,int rutaid)
        {
            this.NombreRuta = nombreruta;
            this.CobradorId = cobradorid;
            this.Detalle = detalle;
            this.RutaId = rutaid;
        }

       public List<Cobradores> Cobradores { get; set; }

       public void AgregarCobrador(int CobradorId, string Nombre)
       {
           this.Cobradores.Add(new Cobradores(CobradorId, Nombre));
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
            /*
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
            _____________________________________*/
                DataTable dt = new DataTable();
                DataTable dtCobradores = new DataTable();

            dt = conexion.ObtenerDatos(String.Format("select  NombreRuta,CobradorId,RutaDetalle from Rutas where RutaId='{0}'", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                
                this.NombreRuta = dt.Rows[0]["NombreRuta"].ToString();
                this.CobradorId = (int)dt.Rows[0]["CobradorId"];
                this.Detalle = dt.Rows[0]["RutaDetalle"].ToString();
                this.RutaId = (int)dt.Rows[0]["RutaId"];


                dtCobradores = conexion.ObtenerDatos("Select c.CobradorId, r.Nombre" +
                                                    "From Rutas r " +
                                                    "Inner Join Cobradores r On c.CobradorId=r.CobradorId" +
                                                    "Where r.RutaId=" + this.RutaId);

                foreach (DataRow row in dtCobradores.Rows)
                {
                    this.AgregarCobrador( (int)row["CobradorId"], row["Nombre"].ToString());
                }
            }

                return dt.Rows.Count > 0;
            
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
