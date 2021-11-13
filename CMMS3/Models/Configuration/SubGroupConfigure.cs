using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class SubGroupConfigure : IEntityTypeConfiguration<SubGroup>
    {
        public void Configure(EntityTypeBuilder<SubGroup> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.CompanyID_FK).IsRequired();
            builder.Property(x => x.GroupID_FK).IsRequired();
            builder.Property(x => x.SubGroupIndex).IsRequired();
            builder.Property(x => x.SubGroupTitle).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.HasMany(x => x.Codings)
                .WithOne(x => x.SubGroup)
                .HasForeignKey(x => x.SubGroupID_FK)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}