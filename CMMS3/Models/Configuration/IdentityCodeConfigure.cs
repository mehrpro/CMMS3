using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class IdentityCodeConfigure : IEntityTypeConfiguration<IdentityCode>
    {
        public void Configure(EntityTypeBuilder<IdentityCode> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CompanyIdFk).IsRequired();
            builder.Property(x => x.GroupIdFk).IsRequired();
            builder.Property(x => x.SubGroupIdFk).IsRequired();
            builder.Property(x => x.UserIdFk).IsRequired();
            builder.Property(x => x.CodeIndex).IsRequired();
            builder.Property(x => x.Code).IsRequired();
            builder.Property(x => x.CodeTitle).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.HasMany(x => x.Machineries)
                .WithOne(x => x.IdentityCode)
                .HasForeignKey(x => x.IdentityCodeIdFk)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}