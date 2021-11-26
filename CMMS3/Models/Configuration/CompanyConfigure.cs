using System;
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
            builder.HasData(
                new Company
                {
                    Id = 1,
                    CompanyTitle = "PSG",
                    CompnayIndex = 1,
                    Description = "شرکت پدیده شیمی غرب",
                    IsActive = true,
                    IsDelete = false,
                    DateDelete = DateTime.Now,

                });
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CompanyTitle).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.CompnayIndex).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.DateDelete).HasColumnType("datetime");
            builder.HasMany(x => x.Applicants)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Groups)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.RequestRepairs)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.SubGroups)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.UserApplications)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.IdentityCodes)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyIdFk)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}