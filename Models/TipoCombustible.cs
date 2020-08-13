using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class TipoCombustible
    {
        public TipoCombustible()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }

        public int IdTipoCombustible { get; set; }

        public string Descripcion { set; get; }

        public int Estado { get; set; }

        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}