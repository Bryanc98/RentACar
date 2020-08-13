using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class Estado
    {
        public Estado()
        {
            this.TipoVehiculo = new HashSet<TipoVehiculo>();
            this.Cliente = new HashSet<Cliente>();
            this.Marca = new HashSet<Marca>();
            this.Modelo = new HashSet<Modelo>();
            this.Inspeccion = new HashSet<Inspeccion>();
        }

        [Key]
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TipoVehiculo> TipoVehiculo { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }

        public virtual ICollection<TipoVehiculo> TipoVehiculos { get; set; }

        public virtual ICollection<Marca> Marca { get; set; }

        public virtual ICollection<Modelo> Modelo { get; set; }

        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
    }
}