using GameHub.Domain;
using GameHub.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameHub.API.Models
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
