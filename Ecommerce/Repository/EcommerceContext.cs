using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ecommerce.Repository
{
    public class EcommerceContext: DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoImagen> ProductoImagen { get; set; }
        public DbSet<Cateogoria> Cateogorias { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<OrdenProducto> OrdenProductos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            
        }
    }
}
