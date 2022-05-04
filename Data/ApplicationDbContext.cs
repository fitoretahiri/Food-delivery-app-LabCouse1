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
    }
}
