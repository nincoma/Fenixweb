using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperDrogueriaFenix.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }
        public String Ruc { get; set; }
        public String RazonSocial { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public String Direccion { get; set; }
        public bool Activo { get; set; }

    }
}
