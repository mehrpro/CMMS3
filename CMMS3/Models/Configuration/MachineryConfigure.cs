using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class MachineryConfigure : IEntityTypeConfiguration<Machinery>
    {
        public void Configure(EntityTypeBuilder<Machinery> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.CompanyId).IsRequired();
            builder.Property(x => x.IdentityCodeIdFk).IsRequired();
            builder.Property(x => x.ApplicantIdFk).IsRequired();
            builder.Property(x => x.MachineryTitle).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.HasMany(x => x.RequestRepairs)
                .WithOne(x => x.Machinery)
                .HasForeignKey(x => x.MachineryIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.SpareParts)
                 .WithOne(x => x.Machinery)
                 .HasForeignKey(x => x.MachineryIdFk)
                 .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.ServicePeriodes)
                 .WithOne(x => x.Machinery)
                 .HasForeignKey(x => x.MachineryIdFk)
                 .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.PowerElectricalMachineries)
                .WithOne(x => x.Machinery)
                .HasForeignKey(x => x.MachineryIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.IdentityMachineries)
               .WithOne(x => x.Machinery)
               .HasForeignKey(x => x.MachinerIdFk)
               .OnDelete(DeleteBehavior.NoAction);


        }
    }
}