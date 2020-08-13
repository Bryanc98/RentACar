using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class EstadoEmpleado
    {
        public int IdEstado { get; set; }

        public string EstatusEmpleado { get; set; }

        public EstadoEmpleado()
        {
            this.Empleado = new HashSet<Empleado>();
        }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}