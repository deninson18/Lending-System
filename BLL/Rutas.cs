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
        ConexionDb conexion=new ConexionDb();

        public int RutaId { set; get; }
        public string NombreRuta { set; get; }
        public int CobradorId { set; get;  }
        public string Detalle { set; get; }
       

        public List<Cobradores> Cobradores { get; set; }

        public Rutas()
        {
            this.NombreRuta = "";
            this.CobradorId = 0;
            this.Detalle = "";
            this.RutaId = 0;

            Cobradores = new List<Cobradores>();
        }    

        public Rutas(string NombreRuta,int CobradorId,string Detalle,int RutaId)
        {
            this.NombreRuta = NombreRuta;
            this.CobradorId = CobradorId;
            this.Detalle = Detalle;
            this.RutaId = RutaId;
        }

   

       public void AgregarCobrador(int CobradorId, string Nombres,string Apellidos)
       {
           this.Cobradores.Add(new Cobradores(CobradorId, Nombres,Apellidos));
       }
       
        public override bool Insertar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("Insert Into Rutas(NombreRuta,RutaDetalle,CobradorId) values('{0}','{1}','{2}')",this.NombreRuta,this.Detalle,this.CobradorId));
                return retorno;

            }catch(Exception ex)
            { throw ex; }
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

            _____________________________________ */
                DataTable dtRuta = new DataTable();
                DataTable dtCobradores = new DataTable();

            dtRuta = conexion.ObtenerDatos(String.Format("select * from  Rutas wher RutaId={0}", IdBuscado));
            if (dtRuta.Rows.Count > 0)
            {
                
                this.NombreRuta = dtRuta.Rows[0]["NombreRuta"].ToString();
                this.CobradorId = (int)dtRuta.Rows[0]["CobradorId"];
                this.Detalle = dtRuta.Rows[0]["RutaDetalle"].ToString();
                this.RutaId = (int)dtRuta.Rows[0]["RutaId"];


                dtCobradores = conexion.ObtenerDatos("Select c.Nombre, c.Apellidos" +
                                                    "From Cobradores " +
                                                    "Inner Join Rutas r On c.CobradorId=r.CobradorId" +
                                                    "Where c.CobradorId=" + this.CobradorId);

                foreach (DataRow row in dtCobradores.Rows)
                {
                    this.AgregarCobrador( (int)row["CobradorId"], row["Nombres"].ToString(),row["Apellidos"].ToString());
                }
            }

                return dtRuta.Rows.Count > 0;
          
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
