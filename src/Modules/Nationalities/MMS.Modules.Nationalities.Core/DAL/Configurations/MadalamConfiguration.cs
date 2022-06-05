using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMS.Modules.Nationalities.Core.Entities;
using MMS.Modules.Nationalities.Core.ValueObjects;

namespace MMS.Modules.Nationalities.Core.DAL.Configurations;

internal sealed class MadalamConfiguration : IEntityTypeConfiguration<Madalam>
{
    public void Configure(EntityTypeBuilder<Madalam> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100)
            .HasConversion(x => x.Value, x => new MadalamName(x));
    }
}