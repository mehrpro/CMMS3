using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class MachineryConfigure : IEntityTypeConfiguration<Machinery>
    {
        public void Configure(EntityTypeBuilder<Machinery> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.CompanyID).IsRequired();
            builder.Property(x => x.IdentityCode).IsRequired();
            builder.Property(x => x.ApplicantID_FK).IsRequired();
            builder.Property(x => x.MachineryTitle).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.HasMany(x => x.RequestRepairs)
                .WithOne(x => x.Machinery)
                .HasForeignKey(x => x.MachineryID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.SpareParts)
                 .WithOne(x => x.Machinery)
                 .HasForeignKey(x => x.MachineryID_FK)
                 .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.ServicePeriodes)
                 .WithOne(x => x.Machinery)
                 .HasForeignKey(x => x.MachineryID_FK)
                 .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.PowerElectricalMachineries)
                .WithOne(x => x.Machinery)
                .HasForeignKey(x => x.MachineryID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.IdentityMachineries)
               .WithOne(x => x.Machinery)
               .HasForeignKey(x => x.MachinerID_FK)
               .OnDelete(DeleteBehavior.SetNull);


        }
    }
}