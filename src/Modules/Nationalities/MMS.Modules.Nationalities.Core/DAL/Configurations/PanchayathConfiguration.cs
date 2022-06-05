using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMS.Modules.Nationalities.Core.Entities;
using MMS.Modules.Nationalities.Core.ValueObjects;

namespace MMS.Modules.Nationalities.Core.DAL.Configurations;

internal sealed class PanchayathConfiguration : IEntityTypeConfiguration<Panchayath>
{
    public void Configure(EntityTypeBuilder<Panchayath> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100)
            .HasConversion(x => x.Value, x => new PanchayathName(x));
    }
}