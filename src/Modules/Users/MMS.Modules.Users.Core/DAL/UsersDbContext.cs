using Microsoft.EntityFrameworkCore;
using MMS.Modules.Users.Core.Entities;

namespace MMS.Modules.Users.Core.DAL;

internal sealed class UsersDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
        
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("users");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}