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
        public int RutaId { get; set; }
        public string FechaInicial { get; set; }
        public string FechaVencimiento { get; set; }
        public double Monto { get; set; }
        public int SemanaNo { get; set; }
        public double Cuota { get; set; }
        public int Valorcuota { get; set; }
        public double Interes { get; set; }

        public List<Clientes> Clientes{ get; set; }
        public List<Rutas> Rutas { get; set; }


        public Prestamos()
        {
            this.PrestamoId = 0;
            this.ClienteId = 0;
            this.RutaId = 0;
            this.FechaInicial = "";
            this.FechaVencimiento = "";
            this.Monto = 0;
            this.SemanaNo = 0;
            this.Cuota = 0;
            this.Valorcuota = 0;
            this.Interes = 0;

        }

        public Prestamos(int prestamoId, int clienteId, int rutaId, string fechaInicial, string fechaVencimiento, double monto, int SemanaNo, double cuota, int Valorcuota, double interes)
        {
            this.PrestamoId = prestamoId;
            this.ClienteId = clienteId;
            this.RutaId = rutaId;
            this.FechaInicial = fechaInicial;
            this.FechaVencimiento = fechaVencimiento;
            this.Monto = monto;
            this.SemanaNo = SemanaNo;
            this.Cuota = cuota;
            this.Interes = interes;

        }

        public void AgregarClientes(int clienteId, string nombres)
        {
            this.Clientes.Add(new Clientes(clienteId, nombres));
        }
        public void AgregarRutas(int rutaId, string nombreRuta)
        {
            this.Rutas.Add(new Rutas(rutaId, nombreRuta));
        }
        public override bool Insertar()
        { 
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("Insert Into Prestamos(ClienteId,RutaId,FechaInicial,FechaVencimiento,Monto,SemanaNo,Cuota,ValorCuota,Interes) values({0},{1},'{2}','{3}',{4},{5},{6},{7},{8})",this.ClienteId,this.RutaId,this.FechaInicial,FechaVencimiento,Monto,this.SemanaNo,this.Cuota,this.Valorcuota,this.Interes));
                return retorno;
                    
       }

        public override bool Editar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(string.Format("update Clientes set ClienteId={0},RutaId={1} Fechainical='{2}', Fechainical='{3}',Monto={4},SemanaNo={5},Cuota={6},ValorCuota={7},Interes={8} where PrestamoId={9} ",
              this.FechaInicial, FechaVencimiento, Monto, this.SemanaNo, this.Cuota, this.Valorcuota, this.Interes,this.PrestamoId));
            return retorno;
        }

        public override bool Eliminar()
        {
                bool retorno = false;
                ConexionDb conexion = new ConexionDb();
                retorno = conexion.Ejecutar(String.Format("Delete from Prestamos where PrestamoId={0}", this.PrestamoId));
                return retorno;
           
        }

        public override bool Buscar(int IdBuscado)
        {
                 DataTable dt = new DataTable();
                 DataTable dtRuta = new DataTable();
                 dt = conexion.ObtenerDatos(String.Format("Select * from Prestamos where PrestamoId= {0} ", IdBuscado));
                 if (dt.Rows.Count > 0)
                 {
                    this.PrestamoId = (int)dt.Rows[0]["PrestamoId"];
                    this.ClienteId = (int)dt.Rows[0]["ClienteId"];
                     this.RutaId = (int)dt.Rows[0]["RutaId"];
                     this.FechaInicial = dt.Rows[0]["FechaInicial"].ToString();
                     this.FechaVencimiento = dt.Rows[0]["FechaVencimiento"].ToString();
                     this.Monto = (double)dt.Rows[0]["Monto"];
                    this.SemanaNo = (int)dt.Rows[0]["SemanaNo"];
                    this.Cuota = (double)dt.Rows[0]["Cuota"];
                    this.Valorcuota = (int)dt.Rows[0]["ValorCuota"];
                }
               return dt.Rows.Count > 0;           
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
    
            return conexion.ObtenerDatos(("Select " + Campos + " from Prestamos where " + Condicion + Orden));
        }
    }
}
