using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperDrogueriaFenix.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public String Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
