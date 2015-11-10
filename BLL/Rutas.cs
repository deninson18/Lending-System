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

        private string NombreRuta { set; get; }
        private int CobradorId { set; get;  }
        private string Detalle { set; get; }

        public Rutas()
        {
            this.NombreRuta = "";
            this.CobradorId = 0;
            this.Detalle = "";
        }    

        public Rutas(string nombreruta,int cobradorid,string detalle)
        {
            this.NombreRuta = nombreruta;
            this.CobradorId = cobradorid;
            this.Detalle = detalle;
        }

        public override bool Insertar()
        {
            throw new NotImplementedException();
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
