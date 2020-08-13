using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class TipoDocumento
    {
        public int IdDocumento { get; set; }

        public string Tipo { get; set; }

        public TipoDocumento()
        {
            this.Cliente = new HashSet<Cliente>();
            this.Empleado = new HashSet<Empleado>();
        }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}