using Microsoft.EntityFrameworkCore;
using RazorPizzaria.Models;

namespace RazorPizzaria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrders> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
