using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Cobradores : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        public int CobradorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public int RutaId { get; set; }

        public Cobradores()
        {
            this.CobradorId = 0;
            this.Nombre = "";
            this.Apellido = "";
            this.Direccion = "";
            this.Telefono = "";
            this.Celular = "";
            this.Cedula = "";
            this.RutaId = 0;
           // Rutas = new List<Rutas>();
        }

        public Cobradores(int cobradorid, string nombre, string apellido,string direccion,string telefono,string celular,string cedula, int rutaid)
        {
            this.CobradorId = cobradorid;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Celular = celular;
            this.Cedula = cedula;
            this.RutaId = rutaid;
        }

        /*public List<Rutas> Rutas { get; set; }

        public void AgregarRuta(int RutaId, string NombreRuta)
        {
            this.Rutas.Add(new Rutas(RutaId, NombreRuta));
        }*/
        public override bool Insertar()
        {
            try
            {
                bool retorno = false;
                retorno=conexion.Ejecutar(String.Format("Insert Into Cobradores(Nombres,Apellidos, Direccion,Telefono,Celular,Cedula) values('{0}','{1}','{2}','{3}','{4}','{5}')",this.Nombre,this.Apellido,this.Direccion,this.Telefono,this.Celular,this.Cedula));
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Editar()
        {
           
            try
            {
                bool retorno = false;
                retorno= conexion.Ejecutar(String.Format("Update Cobradores set Nombres='{0}',Apellidos='{1}', Direccion='{2}',Telefono='{3}',Celular='{4}',Cedula='{5}'", this.Nombre, this.Apellido, this.Direccion, this.Telefono, this.Celular, this.Cedula));
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Eliminar()
        {
            try {

                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("delete from Cobradores where CobradorId={0}", this.CobradorId));
                return retorno;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            DataTable dtRuta = new DataTable();
            dt = conexion.ObtenerDatos(String.Format("Select CobradorId,Nombres,Apellidos, Direccion,Telefono,Celular from Cobradores where CobradorId= {0} ", IdBuscado));
            if(dt.Rows.Count > 0)
            {
                this.CobradorId = (int)dt.Rows[0]["CobradorId"];
                this.Nombre = dt.Rows[0]["Nombres"].ToString();
                this.Apellido = dt.Rows[0]["Apellidos"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();
                this.Telefono = dt.Rows[0]["Telefono"].ToString();
                this.Celular = dt.Rows[0]["Celular"].ToString();
            }
            return dt.Rows.Count > 0;
        } 
         
        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = ""; //!orden.Equals("") ? " orden by  " + orden : "";
            if (!Orden.Equals(""))
                ordenFinal = " orden by  " + Orden;

            return conexion.ObtenerDatos(("Select " + Campos +
                " from Cobradores where " + Condicion + ordenFinal));
        }
    }
}
