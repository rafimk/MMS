using Microsoft.EntityFrameworkCore;
using MMS.Modules.Nationalities.Core.Entities;

namespace MMS.Modules.Nationalities.Core.DAL;

internal sealed class NationalityDbContext : DbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Madalam> Madalams { get; set; }
    public DbSet<Panchayath> Panchayaths { get; set; }
    public DbSet<State> States { get; set; }

    public NationalityDbContext(DbContextOptions<NationalityDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("nationality");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}