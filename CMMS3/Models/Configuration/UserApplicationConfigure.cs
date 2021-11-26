using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class UserApplicationConfigure : IEntityTypeConfiguration<UserApplication>
    {
        public void Configure(EntityTypeBuilder<UserApplication> builder)
        {
            builder.HasData(
                new UserApplication
                {
                    Id = "cf4b710b-c1eb-4e89-b0f1-bd9e8c5a31dd",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "fm708801@gmail.com",
                    NormalizedEmail = "FM708801@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAELYdrMvR/R78xxYSgTf2yTMjeAdCpCO+BiQTOmym/s4Ye75VuVYPm+YRIwzH2wyv0Q==",
                    Firstname = "Farshid",
                    Lastname = "Mohammadi",
                    CompanyIdFk = 1,
                    LimetedCompany = false,


                });
            builder.Property(x => x.LimetedCompany).IsRequired();
            builder.Property(x => x.Firstname).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Lastname).IsRequired().HasMaxLength(150);
            builder.Property(x => x.CompanyIdFk).IsRequired();
            builder.HasMany(x => x.IdentityCodes)
                .WithOne(x => x.UserApplication)
                .HasForeignKey(x => x.UserIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Repairouts)
                .WithOne(x => x.UserApplication)
                .HasForeignKey(x => x.UserIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.RequestRepairs)
                .WithOne(x => x.UserApplication)
                .HasForeignKey(x => x.UserIdFk)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}