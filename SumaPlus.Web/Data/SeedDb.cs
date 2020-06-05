using SumaPlus.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumaPlus.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async  Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckProductTypesAsync();
        }

        private async Task CheckProductTypesAsync()
        {
            if (!_context.ProductTypes.Any())
            {
                _context.ProductTypes.Add(new ProductType { Name = "Product" });
                _context.ProductTypes.Add(new ProductType { Name = "Tool" });
                _context.ProductTypes.Add(new ProductType { Name = "Accessory" });
                await _context.SaveChangesAsync();
            }

        }
    }
}
