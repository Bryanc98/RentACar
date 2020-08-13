using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class EstatusGoma
    {
        public int idEstatus { get; set; }

        public bool Goma1 { get; set; }

        public bool Goma2 { get; set; }

        public bool Goma3 { get; set; }

        public bool Goma4 { get; set; }

        public EstatusGoma()
        {
            this.Inspeccion = new HashSet<Inspeccion>();
        }

        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
    }
}