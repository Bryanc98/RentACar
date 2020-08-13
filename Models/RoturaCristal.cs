using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class RoturaCristal
    {
        public int idRotura { get; set; }

        public string TieneRotura { get; set; }

        public RoturaCristal()
        {
            this.Inspeccion = new HashSet<Inspeccion>();
        }

        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
    }
}