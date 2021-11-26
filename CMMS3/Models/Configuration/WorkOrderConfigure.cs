using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class WorkOrderConfigure : IEntityTypeConfiguration<WorkOrder>
    {
        public void Configure(EntityTypeBuilder<WorkOrder> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.WorkingTotalMin).IsRequired();
            builder.Property(x => x.StopTotalMin).IsRequired();
            builder.Property(x => x.RequestIdFk).IsRequired();
            builder.Property(x => x.RepairOutside).IsRequired();
            builder.Property(x => x.CauseExhaustion).IsRequired();
            builder.Property(x => x.CauseOperatorNegligence).IsRequired();
            builder.Property(x => x.CauseQualityofSpareParts).IsRequired();
            builder.Property(x => x.Other).IsRequired();
            builder.Property(x => x.OtherError).IsRequired();
            builder.Property(x => x.PersonHours).IsRequired();
            builder.Property(x => x.ProductionPlanning).IsRequired();
            builder.Property(x => x.NoSpareParts).IsRequired();
            builder.Property(x => x.CloseRequest).IsRequired();
            builder.Property(x => x.StartWorking).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.EndWorking).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.OtherErrorDescription).HasMaxLength(250);
            builder.Property(x => x.ReportRepair).HasMaxLength(700).IsRequired();
            builder.Property(x => x.PersonHoursDescription).HasMaxLength(250);
            builder.Property(x => x.NoSparePartsDescription).HasMaxLength(250);
            builder.Property(x => x.OtherDescription).HasMaxLength(250);
            builder.Property(x => x.ProductionPlanningDescription).HasMaxLength(250);
            builder.HasMany(x => x.RepairManListeds)
                .WithOne(x => x.WorkOrder)
                .HasForeignKey(x => x.WorkOrderIdFk)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}