using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Clientes : ClaseMaestra
    {
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string  Apellidos { get; set; }
        public string  Apodos { get; set; }
        public string Direccion { get; set; }
        public string Referencia { get; set; }
        public int Sexo { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }


        public Clientes()
        {
            this.ClienteId = 0;
            this.Nombres = "";
            this.Apellidos = "";
            this.Apodos = "";
            this.Direccion = "";
            this.Referencia = "";
            this.Sexo = 0;
            this.Cedula = "";
            this.Telefono = "";
            this.Celular = "";

        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            ConexionDb conexion = new ConexionDb();
            try {
               
                dt = conexion.ObtenerDatos(string.Format("select ClienteId,Nombres,Apellidos,Apodos,Direccion,Referencia,Sexo,Cedula,Telefono,Celular from Clientes where ClienteId={0}", IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.ClienteId = (int)dt.Rows[0]["ClienteId"];
                    this.Nombres = dt.Rows[0]["Nombres"].ToString();
                    this.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                    this.Apodos = dt.Rows[0]["Apodos"].ToString();
                    this.Direccion = dt.Rows[0]["Direccion"].ToString();
                    this.Referencia = dt.Rows[0]["Referencia"].ToString();
                    this.Sexo = (int)dt.Rows[0]["Sexo"];
                    this.Cedula = dt.Rows[0]["Cedula"].ToString();
                    this.Telefono = dt.Rows[0]["Telefono"].ToString();
                    this.Celular = dt.Rows[0]["Celular"].ToString();

                }
            }catch(Exception ex)
            {
                throw ex;

            }
            return dt.Rows.Count > 0;

        }


        public override bool Editar()
        {
            try {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(string.Format("update Clientes set Nombres='{0}', Apellidos='{1}',Apodos='{2}',Direccion='{3}',Referencia='{4}',Sexo='{5}',Cedula='{6}',Telefono='{7}',Celular='{8}', where ClienteId={0} ",
                this.Nombres,this.Apellidos,this.Apodos,this.Direccion,this.Referencia,this.Sexo,this.Cedula,this.Telefono,this.Celular));

            return retorno;

            }catch(Exception ex)
            {
                throw ex;
            }
        }


        public override bool Eliminar()
        {
            try { 
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(string.Format("delete from Clientes where ClienteId={0}",this.ClienteId));
            return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Insertar()
        {
            try { 
            bool retorno= false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(string.Format("insert into Clientes(Nombres,Apellidos,Apodos,Direccion,Referencia,Sexo,Cedula,Telefono,Celular) values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}')",
                this.Nombres,this.Apellidos,this.Apodos,this.Direccion,this.Referencia,this.Sexo,this.Cedula,this.Telefono,this.Celular));
            return retorno;
            }catch(Exception ex)
            {
                throw ex;
            }

        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            try { 
            ConexionDb conexion = new ConexionDb();
            return conexion.ObtenerDatos(string.Format("select "+ Campos + "from Clientes" + "where "+ Condicion + Orden));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
