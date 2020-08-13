using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class Marca
    {
        public Marca()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }

        public int IdTipoVehiculo { get; set; }

        public string Descripcion { get; set; }

        public int Estado { get; set; }

        public int Modelo { get; set; }


        public virtual ICollection<Vehiculo> Vehiculo { get; set; }

        public virtual Modelo Modelos { get; set; }

        public virtual Estado Estados { get; set; }
    }
}