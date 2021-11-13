using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class RepairManConfigure : IEntityTypeConfiguration<RepairMan>
    {
        public void Configure(EntityTypeBuilder<RepairMan> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.Repairman_FullName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.RepairMan_Status).IsRequired().HasMaxLength(250);
            builder.HasMany(x => x.RepairManListeds)
                .WithOne(x => x.RepairMan)
                .HasForeignKey(x => x.RepairManIdFk)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}