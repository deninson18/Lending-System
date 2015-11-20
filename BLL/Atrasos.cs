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
        public int CantidadAtraso { get; set; }
        
        public override bool Insertar()
        {
            throw new NotImplementedException();
        }
        public override bool Editar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("update Atrasos set CantidadAtrasos={0} ", this.CantidadAtraso));
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override bool Eliminar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("delete from Atrasos where AtrasoId={0} ",this.AtrasosId));
                return true;
            }catch(Exception e )
            {
                throw e;
            }
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = ""; //!orden.Equals("") ? " orden by  " + orden : "";
            if (!Orden.Equals(""))
                ordenFinal = " orden by  " + Orden;

            return conexion.ObtenerDatos(("Select " + Campos + " from Atrasos where " + Condicion + ordenFinal));
        }
    }
}
