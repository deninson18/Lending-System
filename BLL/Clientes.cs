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
        public int RutaId { get; set; }
        
        public List<Rutas> Rutas { get; set; }

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
            this.RutaId = 0;
        }
        public Clientes(int clienteId, string nombres)
        {
            this.ClienteId = clienteId;
            this.Nombres = nombres;
        }

        public Clientes( int ClienteId, string Nombres, string Apellidos, string Apodos, string Direccion, string Referencia, int Sexo, string Cedula, string Telefono, string Celular,int RutaId)
        {
            this.ClienteId = ClienteId;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Apodos = Apodos;
            this.Direccion = Direccion;
            this.Referencia = Referencia;
            this.Sexo = Sexo;
            this.Cedula = Cedula;
            this.Telefono = Telefono;
            this.Celular = Celular;
            this.RutaId = RutaId;

        }

        public void AgregarRutas(int rutaId,string nombreRuta)
        {
            this.Rutas.Add(new Rutas(rutaId,nombreRuta));
        }

        public override bool Buscar(int IdBuscado)
        {
            try { 
            DataTable dt = new DataTable();
            ConexionDb conexion = new ConexionDb();
               
            dt = conexion.ObtenerDatos(String.Format(" Select * from Clientes where ClienteId = {0} ", IdBuscado));
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
                    return dt.Rows.Count > 0;

                }catch(Exception ex)
                {
                    throw ex;
                }
        }
        
        public override bool Editar()
        {
            try {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(string.Format("update Clientes set Nombres='{0}', Apellidos='{1}',Apodos='{2}',Direccion='{3}',Referencia='{4}',Sexo='{5}',Cedula='{6}',Telefono='{7}',Celular='{8}', where ClienteId={9} ",
                this.Nombres,this.Apellidos,this.Apodos,this.Direccion,this.Referencia,this.Sexo,this.Cedula,this.Telefono,this.Celular,this.ClienteId));
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
            retorno = conexion.Ejecutar(string.Format("insert into Clientes(Nombres,Apellidos,Apodos,Direccion,Referencia,Sexo,Cedula,Telefono,Celular,RutaId) values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}',{9})",
            this.Nombres,this.Apellidos,this.Apodos,this.Direccion,this.Referencia,this.Sexo,this.Cedula,this.Telefono,this.Celular,RutaId));
            return retorno;
            }catch(Exception ex)
            {
                throw ex;
            }

        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            return conexion.ObtenerDatos("Select " + Campos + " from Clientes where " + Condicion +" "+ Orden);
        }
    }
}
