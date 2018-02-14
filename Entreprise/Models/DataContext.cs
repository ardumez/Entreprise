using Microsoft.EntityFrameworkCore;

namespace Entreprise.Models
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> opts)
            : base(opts) { }

        public DbSet<Lead> Leads { get; set; }
        public DbSet<Provider> Providers { get; set; }
    }
}