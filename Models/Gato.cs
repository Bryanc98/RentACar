using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class Gato
    {
        public int idGato { get; set; }

        public string TieneGato { get; set; }

        public Gato()
        {
            this.Inspeccion = new HashSet<Inspeccion>();
        }

        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
    }
}