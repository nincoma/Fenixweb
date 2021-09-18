using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperDrogueriaFenix.Models
{
    public class ProductoTienda
    {

        [Key]
        public int IdProductoTienda { get; set; }


        [Required]
        public decimal PrecioUnidadCompra { get; set; }

        [Required]
        public decimal PrecioUnidadVenta { get; set; }

        [Required]

        public int Stock { get; set; }

        [Required]
        public bool Activo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }

        public Cliente Cliente { get; set; }

        public Tienda Tienda { get; set; }
    }
}

