using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class UnitOfMeasurementConfigure : IEntityTypeConfiguration<UnitOfMeasurement>
    {
        public void Configure(EntityTypeBuilder<UnitOfMeasurement> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(a => a.ID).IsRequired();
            builder.Property(u => u.Unit).HasMaxLength(150).IsRequired();
            builder.Property(u => u.Description).HasMaxLength(250);
            builder
                .HasMany(x => x.ConsumableParts)
                .WithOne(x => x.UnitOfMeasurement)
                .HasForeignKey(x => x.UnitID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder
                .HasMany(x => x.ServicePeriodes)
                .WithOne(x => x.UnitOfMeasurement)
                .HasForeignKey(x => x.UnitID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder
                .HasMany(x => x.SpareParts)
                .WithOne(x => x.UnitOfMeasurement)
                .HasForeignKey(x => x.UnitID_FK)
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}