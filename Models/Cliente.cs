using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public int TipoDocumento { get; set; }

        public string CreditCard { get; set; }

        public double LimitCredito { get; set; }

        public int TipoPersona { get; set; }

        public int Estado { get; set; }

        public Cliente()
        {
            //this.TipoPersonas = new HashSet<TipoPersona>();
            //this.Estados = new HashSet<Estado>();
            //this.TipoDocumentos = new HashSet<TipoDocumento>();
        }

        public virtual Estado Estados { get; set; }

        public virtual TipoPersona TipoPersonas { get; set; }

        public virtual TipoDocumento TipoDocumentos { get; set; }

    }
}