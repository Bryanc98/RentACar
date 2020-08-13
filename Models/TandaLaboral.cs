using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class TandaLaboral
    {
        [Key]
        public int IdTanda { get; set; }

        public string TandaHorario { get; set; }

        public int Estado { get; set; }

        public TandaLaboral()
        {
            this.Empleado = new HashSet<Empleado>();
            this.Estados = new HashSet<Estado>();

        }

        public virtual ICollection<Empleado> Empleado { get; set; }

        public virtual ICollection<Estado> Estados { get; set; }
    }
}