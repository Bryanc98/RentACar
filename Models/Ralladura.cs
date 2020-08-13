using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class Ralladura
    {
        public int idRalladura { get; set; }

        public string TieneRalladura { get; set; }

        public Ralladura()
        {
            this.Inspeccion = new HashSet<Inspeccion>();
        }

        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
    }
}