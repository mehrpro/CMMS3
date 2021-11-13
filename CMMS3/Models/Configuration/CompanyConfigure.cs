using System.Security.Cryptography.X509Certificates;
using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class CompanyConfigure : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.CompanyTitle).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.CompnayIndex).IsRequired();
            builder.HasMany(x => x.Applicants)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.Groups)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.RequestRepairs)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.SubGroups)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.UserApplications)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.IdentityCodes)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyID_FK)
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}