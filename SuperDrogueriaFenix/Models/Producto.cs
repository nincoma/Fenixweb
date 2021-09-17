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
        public String Codigo { get; set; }
        public int ValorCodigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public int Activo { get; set; }


        /*public Categoria oCategoria { get; set; }
        public bool Activo { get; set; }*/
    }
}
