using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class RequestRepairConfigure : IEntityTypeConfiguration<RequestRepair>
    {
        public void Configure(EntityTypeBuilder<RequestRepair> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.EM).IsRequired();
            builder.Property(x => x.IsClose).IsRequired();
            builder.Property(x => x.IsRepairOut).IsRequired();
            builder.Property(x => x.PublicTypeID_FK).IsRequired();
            builder.Property(x => x.MachineryID_FK).IsRequired();
            builder.Property(x => x.UserID_FK).IsRequired();
            builder.Property(x => x.CompanyID_FK).IsRequired();
            builder.Property(x => x.RequestDataTime).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.ApplicantID_FK).IsRequired();
            builder.Property(x => x.RequestTitle).HasMaxLength(500).IsRequired();
            builder.HasMany(x => x.ConsumableParts)
                .WithOne(x => x.RequestRepair)
                .HasForeignKey(x => x.RequestID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.WorkOrders)
                .WithOne(x => x.RequestRepair)
                .HasForeignKey(x => x.RequestID_FK)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.Repairouts)
                .WithOne(x => x.RequestRepair)
                .HasForeignKey(x => x.RequestID_FK)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}