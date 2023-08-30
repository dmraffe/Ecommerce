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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            
        }
    }
}
