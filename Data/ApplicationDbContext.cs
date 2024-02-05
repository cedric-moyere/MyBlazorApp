using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyBlazorApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options)
        {
        }
    }
}