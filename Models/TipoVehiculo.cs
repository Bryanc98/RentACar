using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class TipoVehiculo
    {
        public TipoVehiculo()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }

        [Key]
        public int IdTipoVehiculo { get; set; }

        public string Descripcion { set; get; }

        public int IdEstado { get; set; }

        public virtual ICollection<Vehiculo> Vehiculo { get; set; }

        public virtual Estado Estados { get; set; }
    }
}