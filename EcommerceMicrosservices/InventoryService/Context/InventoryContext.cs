using Microsoft.EntityFrameworkCore;
using InventoryService.Domain;

namespace InventoryService.Context
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}