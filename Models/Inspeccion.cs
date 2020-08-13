using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class Inspeccion
    {
        public int IdInspeccion { get; set; }

        public int Vehiculo { get; set; }

        public int IdCliente { get; set; }

        public int Ralladura { get; set; }

        public int Combustible { get; set; }

        public int GomaRepuesto { get; set; }

        public int Gato { get; set; }

        public int RoturaCristal { get; set; }

        public int EstatusGoma { get; set; }

        public DateTime Fecha { get; set; }

        public int IdEmpleado { get; set; }

        public int Estado { get; set; }

        public Inspeccion()
        {

        }

        public virtual Vehiculo IdVehiculo { get; set; }

        public virtual Combustible Combustibles { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Gato Gatos { get; set; }

        public virtual Ralladura Ralladuras{ get; set; }

        public virtual GomaRepuesto GomaRepuetos { get; set; }

        public virtual RoturaCristal RoturaCristals { get; set; }

        public virtual EstatusGoma EstatusGomas { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Estado Estados { get; set; }


    }
}