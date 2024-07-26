
using Authorizationdocs.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authorizationdocs.Data
{
    //public class ApplicationDbContext : DbContext
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<LoginModel> loginModel { get; set; } = default!;
        public DbSet<RegisterModel> registerModel { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<LoginModel>().HasKey(l => l.Id);
            base.OnModelCreating(modelbuilder);
        }

    }
}

