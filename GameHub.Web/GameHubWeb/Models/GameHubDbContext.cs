using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameHubWeb.Models
{
    public class GameHubDbContext : IdentityDbContext<ApplicationUser>
    {
        public GameHubDbContext(DbContextOptions<GameHubDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
