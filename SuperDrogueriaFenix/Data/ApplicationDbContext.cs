using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperDrogueriaFenix.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDrogueriaFenix.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedor> Proveedors { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public DbSet<SuperDrogueriaFenix.Models.Tienda> Tienda { get; set; }
        public DbSet<SuperDrogueriaFenix.Models.Cliente> Cliente { get; set; }
        public DbSet<SuperDrogueriaFenix.Models.ProductoTienda> ProductoTienda { get; set; }

    }
}
