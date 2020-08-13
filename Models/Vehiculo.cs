using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace RentACar.Models
{
    public class Vehiculo
    {
        public Vehiculo()
        {
            this.RentaDevolucion = new HashSet<RentaDevolucion>();
        }

        public int IdVehiculo { get; set; }

        public string Descripcion { get; set }

        public string NoChasis { get; set; }

        public string NoMotor { get; set; }

        public int TipoVehiculo { get; set; }

        public int Marca { get; set; }

        public int Modelo { get; set; }

        public int TipoCombustible { get; set; }

        public int Estado { get; set; }

        public virtual ICollection<RentaDevolucion> RentaDevolucion { get; set; }

    }
}