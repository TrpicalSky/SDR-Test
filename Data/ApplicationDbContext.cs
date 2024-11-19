using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SDR_Test.Models;

namespace SDR_Test.Data
{
    public class ApplicationDbContext : IdentityDbContext<Customers>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SDR_Test.Models.Job> Job { get; set; } = default!;
    }
}
