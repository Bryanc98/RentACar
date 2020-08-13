using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class Combustible
    {
        public int IdCombustible { get; set; }

        public string CantCombustible { get; set; }

        public Combustible()
        {
            this.Inspeccion = new HashSet<Inspeccion>();
        }

        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
    }
}