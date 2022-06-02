using Food_delivery_app_LabCouse1.Models;
using Microsoft.EntityFrameworkCore;

namespace Food_delivery_app_LabCouse1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Restoranti> Restoranti { get; set; }

        public DbSet<Qyteti> Qyteti { get; set; }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<Roli> Roli { get; set; }

        public DbSet<Useri> Useri { get; set; }

        public DbSet<Perdoruesi> Perdoruesi { get; set; }
    }
}
