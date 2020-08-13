using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class TipoPersona
    {
        public int IdTiPersona { get; set; }

        public string TiPersona { get; set; }

        public TipoPersona()
        {
            this.Cliente = new HashSet<Cliente>();
        }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}