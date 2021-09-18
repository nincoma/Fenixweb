using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperDrogueriaFenix.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        [StringLength(100)]
        public String Codigo { get; set; }

        [Required]
        public decimal ValorCodigo { get; set; }

        [Required]
        [StringLength(100)]
        public String Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public String Descripcion { get; set; }

        [Required]
        public int IdCategoria { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        [Display(Name = "Fecha de Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistro { get; set; }

        public ICollection<Categoria> Categorias { get; set; }
        public Proveedor Proveedor { get; set; }




        /*public Categoria oCategoria { get; set; }
        public bool Activo { get; set; }*/
    }
}
