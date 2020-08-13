using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public int IdDocumento { get; set; }

        public string NoDocumento { get; set; }

        public int TandaLaboral { get; set; }

        public int PorcientoComision { get; set; }

        public DateTime FechaIngreso { get; set; }

        public int EstadoEmpleado { get; set; }

        public Empleado()
        {
          
        }

        public virtual TandaLaboral TandaLaborals { get; set; }

        public virtual TipoDocumento TipoDocumentos { get; set; }

        public virtual EstadoEmpleado EstadoEmpleados { get; set; }
    }
}