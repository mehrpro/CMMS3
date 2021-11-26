using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class GroupConfigure : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CompanyIdFk).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250).IsRequired();
            builder.Property(x => x.GroupIndex).IsRequired();
            builder.Property(x => x.GroupTitle).IsRequired().HasMaxLength(150);
            builder.HasMany(x => x.IdentityCodes)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.SubGroups)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupIdFk)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}