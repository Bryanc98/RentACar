using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class Modelo
    {
        public Modelo()
        {
            this.Marca = new HashSet<Marca>();

        }

        public int IdModelo { get; set; }

        public string Descripcion { set; get; }



        public int Estado { get; set; }

        public virtual ICollection<Marca> Marca { get; set; }
    }
}