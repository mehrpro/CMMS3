using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class WorkOrderConfigure : IEntityTypeConfiguration<WorkOrder>
    {
        public void Configure(EntityTypeBuilder<WorkOrder> builder)
        {

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.WorkingTotalMin).IsRequired();
            builder.Property(x => x.StopTotalMin).IsRequired();
            builder.Property(x => x.RequestID_FK).IsRequired();
            builder.Property(x => x.RepairOutside).IsRequired();
            builder.Property(x => x.Cause_Exhaustion).IsRequired();
            builder.Property(x => x.Cause_OperatorNegligence).IsRequired();
            builder.Property(x => x.Cause_QualityofSpareParts).IsRequired();
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
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}