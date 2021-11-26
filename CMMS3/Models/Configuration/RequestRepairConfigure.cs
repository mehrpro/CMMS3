using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class RequestRepairConfigure : IEntityTypeConfiguration<RequestRepair>
    {
        public void Configure(EntityTypeBuilder<RequestRepair> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Em).IsRequired();
            builder.Property(x => x.IsClose).IsRequired();
            builder.Property(x => x.IsRepairOut).IsRequired();
            builder.Property(x => x.PublicTypeIdFk).IsRequired();
            builder.Property(x => x.MachineryIdFk).IsRequired();
            builder.Property(x => x.UserIdFk).IsRequired();
            builder.Property(x => x.CompanyIdFk).IsRequired();
            builder.Property(x => x.RequestDataTime).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.ApplicantIdFk).IsRequired();
            builder.Property(x => x.RequestTitle).HasMaxLength(500).IsRequired();
            builder.HasMany(x => x.ConsumableParts)
                .WithOne(x => x.RequestRepair)
                .HasForeignKey(x => x.RequestIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.WorkOrders)
                .WithOne(x => x.RequestRepair)
                .HasForeignKey(x => x.RequestIdFk)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Repairouts)
                .WithOne(x => x.RequestRepair)
                .HasForeignKey(x => x.RequestIdFk)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}