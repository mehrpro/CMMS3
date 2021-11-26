using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class RepairManConfigure : IEntityTypeConfiguration<RepairMan>
    {
        public void Configure(EntityTypeBuilder<RepairMan> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.RepairmanFullName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.RepairManStatus).IsRequired().HasMaxLength(250);
            builder.HasMany(x => x.RepairManListeds)
                .WithOne(x => x.RepairMan)
                .HasForeignKey(x => x.RepairManIdFk)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}