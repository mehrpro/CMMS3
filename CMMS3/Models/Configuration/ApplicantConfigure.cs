using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class ApplicantConfigure : IEntityTypeConfiguration<Applicant>
    {
        public void Configure(EntityTypeBuilder<Applicant> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.ApplicantTitle).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.CompanyID_FK).IsRequired();
            builder.HasMany(x => x.RequestRepairs)
                .WithOne(x => x.Applicant)
                .HasForeignKey(x => x.ApplicantID_FK)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasMany(x => x.Machineries)
                .WithOne(x => x.Applicant)
                .HasForeignKey(x => x.ApplicantID_FK)
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}