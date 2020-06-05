using Microsoft.EntityFrameworkCore;
using SumaPlus.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumaPlus.Web.Data
{
    public class DataContext : DbContext
   
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Agenda> Agendas { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<SupplierType> SupplierTypes { get; set; }

        public DbSet<SumaPlus.Web.Data.Entities.Pais> Pais { get; set; }

        public DbSet<SumaPlus.Web.Data.Entities.Provincia> Provincia { get; set; }

        public DbSet<SumaPlus.Web.Data.Entities.Municipio> Municipio { get; set; }
    }
}
