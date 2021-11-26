using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class RepairoutConfigure : IEntityTypeConfiguration<Repairout>
    {
        public void Configure(EntityTypeBuilder<Repairout> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.IsClosed).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Regidtered).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.BackendRequest).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.CompanyIdFk).IsRequired();
            builder.Property(x => x.RequestIdFk).IsRequired();
            builder.Property(x => x.UserIdFk).IsRequired();
            builder.Property(x => x.RepairOutFullName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.RepairReportOut).HasMaxLength(500);
            builder.Property(x => x.RequestRepairOut).IsRequired().HasMaxLength(500);
        }
    }
}