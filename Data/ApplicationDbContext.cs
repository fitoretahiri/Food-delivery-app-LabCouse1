using Food_delivery_app_LabCouse1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Food_delivery_app_LabCouse1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<Restaurant_Qyteti>().HasKey(x => new { x.QytetiID, x.RestaurantID });
        }
        public DbSet<Restauranti> Restauranti { get; set; }

        public DbSet<Qyteti> Qyteti { get; set; }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<Roli> Roli { get; set; }

        public DbSet<Perdoruesi> Perdoruesi { get; set; }

        public DbSet<Klienti> Klienti { get; set; }

        //public DbSet<Restaurant_Qyteti> restaurant_Qyteti { get; set; }

        public DbSet<Transportuesi> Transportuesi { get; set; }
        public DbSet<Ushqimi> Ushqimi { get; set; }
        public DbSet<Pija> Pija { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
