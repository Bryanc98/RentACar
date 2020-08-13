using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class GomaRepuesto
    {
        public int idGomaR { get; set; }

        public string TieneGomaR { get; set; }

        public GomaRepuesto()
        {
            this.Inspeccion = new HashSet<Inspeccion>();
        }

        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
    }
}