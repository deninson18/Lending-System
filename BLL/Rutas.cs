using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class Rutas : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        public int RutaId { set; get; }
        public string NombreRuta { set; get; }
        public int CobradorId { set; get; }
        public string Detalle { set; get; }
        public List<Cobradores> Cobradores { get; set; }

        public Rutas()
        {
            this.NombreRuta = "";
            this.CobradorId = 0;
            this.Detalle = "";
            this.RutaId = 0;
            this.Cobradores = new List<Cobradores>();
        }

        public Rutas(int rutaId, string nombreRuta)
        {
            this.RutaId = rutaId;
            this.NombreRuta = nombreRuta;
        }


        public Rutas(int RutaId, string NombreRuta, string Detalle, int CobradorId)
        {
            this.RutaId = RutaId;
            this.NombreRuta = NombreRuta;
            this.Detalle = Detalle;
            this.CobradorId = CobradorId;
        }

        public void AgregarCobrador(int CobradorId, string Nombres, string Apellidos)
        {
            this.Cobradores.Add(new Cobradores(CobradorId, Nombres, Apellidos));
        }

        public override bool Insertar()
        {
            bool retorno = false;
            StringBuilder Comando = new StringBuilder();
            try
            {
                retorno = conexion.Ejecutar(String.Format("insert into Rutas(NombreRuta,RutaDetalle,CobradorId) values('{0}','{1}',{2}) ",
                this.NombreRuta, this.Detalle, this.CobradorId));
                if (retorno)
                {
                    this.RutaId = (int)conexion.ObtenerDatos(String.Format("Select Max(RutaId) as RutaId from Rutas ")).Rows[0]["RutaId"];

                    foreach (var cobrador in this.Cobradores)
                    {
                        Comando.AppendLine(String.Format("insert into RutasCobradores(RutaId,CobradorId) values({0},{1})", this.RutaId, cobrador.CobradorId));
                    }
                }
                retorno = conexion.Ejecutar(Comando.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public override bool Editar()
        {
            try
            {
                bool retorno = false;
                StringBuilder Comando = new StringBuilder();
                conexion.Ejecutar(String.Format("Updte Rutas set NombreRuta='{0}',RutaDetalle='{2}',CobradorId={1} ", this.NombreRuta, this.Detalle, this.CobradorId));

                if (retorno)
                {
                    conexion.Ejecutar("Delete From RutasCobradores Where RutaId=" + this.RutaId);

                    foreach (var cobrador in this.Cobradores)
                    {
                        Comando.AppendLine(String.Format("insert into RutasCobradores(RutaId,CobradorId) Values({0},{1});", this.RutaId, cobrador.CobradorId));
                    }
                    retorno = conexion.Ejecutar(Comando.ToString());
                }
                return retorno;
            }
            catch (Exception) { return false; }
        }

        public override bool Eliminar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("Delete from Rutas where RutaId={0})", this.RutaId + ";" + "Delete from RutasCobradores where RutaId={0}", this.RutaId));
                return retorno = true;
            }
            catch (Exception) { return false; }
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dtRuta = new DataTable();
            DataTable dtRut = new DataTable();
          
                dtRuta = conexion.ObtenerDatos(String.Format("select * from  Rutas where RutaId={0}", IdBuscado));
                if (dtRuta.Rows.Count > 0)
                {
                    this.RutaId = (int)dtRuta.Rows[0]["RutaId"];
                    this.NombreRuta = dtRuta.Rows[0]["NombreRuta"].ToString();
                    this.CobradorId = (int)dtRuta.Rows[0]["CobradorId"];
                    this.Detalle = dtRuta.Rows[0]["RutaDetalle"].ToString();

                dtRut = conexion.ObtenerDatos(String.Format("Select r.RutaId,r.CobradorId From Rutas r Inner Join RutasCobradores c On r.CobradorId = c.CobradorId Where r.RutaId={0} ", IdBuscado));
                foreach (DataRow row in dtRut.Rows)
                    {
                        this.AgregarCobrador((int)row["CobradorId"], "", "");
                    }
                }
           
            return dtRuta.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            try
            {
                return conexion.ObtenerDatos(("Select " + Campos + " from Rutas where " + Condicion + Orden));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
