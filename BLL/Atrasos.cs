using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL  
{
    public class Atrasos : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        public int AtrasosId { get; set; }
        public int PrestamoId { get; set; }
        public int Cantidad { get; set; }
        public double Atraso { get; set; }
        public double Total { get; set; }

        public List<Prestamos> Prestamos { get; set; }

        public Atrasos()
        {
            this.AtrasosId = 0;
            this.PrestamoId = 0;
            this.Cantidad = 0;
            this.Atraso = 0;
            this.Total = 0;
        }

        public Atrasos(int atrasoId, int prestamoId, int cantidad, double atraso, double total)
        {
            this.AtrasosId = atrasoId;
            this.PrestamoId = prestamoId;
            this.Cantidad = cantidad;
            this.Atraso = atraso;
            this.Total = total;
        }

        public void AgregarPrestamos(int PrestamoId)
        {
            this.Prestamos.Add(new Prestamos(PrestamoId));
        }

        public override bool Insertar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(string.Format("insert into Atrasos (PrestamoId,Cantidad,Atraso,Total) values ({0},{1},{2},{3})", this.PrestamoId, this.Cantidad, this.Atraso, this.Total));
            return retorno;
        }
        public override bool Editar()
        {

            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("update Atrasos set PrestamoId={0}, Cantidad={1}, Atraso={2},Total={3} where AtrasoId={3}", this.PrestamoId, this.Cantidad, this.Atraso, this.Total, this.AtrasosId));
            return retorno;

        }

        public override bool Eliminar()
        {

            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("delete from Atrasos where AtrasoId={0} ", this.AtrasosId));
            return retorno;

        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos(String.Format("Select * from Atrasos where AtrasoId= {0} ", IdBuscado));

            if (dt.Rows.Count > 0)
            {
                this.AtrasosId = (int)dt.Rows[0]["AtrasoId"];
                this.PrestamoId = (int)dt.Rows[0]["PrestamoId"];
                this.Cantidad = (int)dt.Rows[0]["Cantidad"];
                this.Atraso = (double)dt.Rows[0]["Atraso"];
                this.Total = (double)dt.Rows[0]["Total"];
            }
            return dt.Rows.Count > 0;

        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {

            return conexion.ObtenerDatos(("Select " + Campos + " from Atrasos where " + Condicion + Orden));
        }
    }
}
