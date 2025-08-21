using Microsoft.EntityFrameworkCore;
using SalesService.Domain;

namespace SalesService.Context
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options)
        {
            
        }

        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesItem> SalesItems { get; set; }
    }
}