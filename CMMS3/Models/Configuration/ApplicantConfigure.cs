using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class ApplicantConfigure : IEntityTypeConfiguration<Applicant>
    {
        public void Configure(EntityTypeBuilder<Applicant> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.ApplicantTitle).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.CompanyIdFk).IsRequired();
            builder.HasMany(x => x.RequestRepairs)
                .WithOne(x => x.Applicant)
                .HasForeignKey(x => x.ApplicantIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Machineries)
                .WithOne(x => x.Applicant)
                .HasForeignKey(x => x.ApplicantIdFk)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}