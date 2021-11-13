using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class IdentityCodeConfigure : IEntityTypeConfiguration<IdentityCode>
    {
        public void Configure(EntityTypeBuilder<IdentityCode> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.CompanyID_FK).IsRequired();
            builder.Property(x => x.GroupID_FK).IsRequired();
            builder.Property(x => x.SubGroupID_FK).IsRequired();
            builder.Property(x => x.UserID_FK).IsRequired();
            builder.Property(x => x.CodeIndex).IsRequired();
            builder.Property(x => x.Code).IsRequired();
            builder.Property(x => x.CodeTitle).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.HasMany(x => x.Machineries)
                .WithOne(x => x.IdentityCode)
                .HasForeignKey(x => x.IdentityCodeID_FK)
                .OnDelete(DeleteBehavior.SetNull);




        }
    }
}