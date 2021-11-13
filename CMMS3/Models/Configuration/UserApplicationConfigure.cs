using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class UserApplicationConfigure : IEntityTypeConfiguration<UserApplication>
    {
        public void Configure(EntityTypeBuilder<UserApplication> builder)
        {
            builder.Property(x => x.LimetedCompany).IsRequired();
            builder.Property(x => x.Firstname).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Lastname).IsRequired().HasMaxLength(150);
            builder.Property(x => x.CompanyID_FK).IsRequired();
            builder.HasMany(x => x.IdentityCodes)
                .WithOne(x => x.UserApplication)
                .HasForeignKey(x => x.UserID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.Repairouts)
                .WithOne(x => x.UserApplication)
                .HasForeignKey(x => x.UserID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.RequestRepairs)
                .WithOne(x => x.UserApplication)
                .HasForeignKey(x => x.UserID_FK)
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}