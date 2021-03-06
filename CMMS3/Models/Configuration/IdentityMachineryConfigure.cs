using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class IdentityMachineryConfigure : IEntityTypeConfiguration<IdentityMachinery>
    {
        public void Configure(EntityTypeBuilder<IdentityMachinery> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.DateTimeImport).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.DateTimeStart).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.DateStartWaranty).HasColumnType("datetime");
            builder.Property(x => x.DateEndWaranty).HasColumnType("datetime");
            builder.Property(x => x.Calibration).IsRequired();
            builder.Property(x => x.NewDivice).IsRequired();
            builder.Property(x => x.MachinerIdFk).IsRequired();
            builder.Property(x => x.TypeDevice).HasMaxLength(250);
            builder.Property(x => x.Company).HasMaxLength(250);
            builder.Property(x => x.CompanyAddress).HasMaxLength(250);
            builder.Property(x => x.CompanyFax).HasMaxLength(15);
            builder.Property(x => x.CompanyTel).HasMaxLength(15);
            builder.Property(x => x.CalibrationAddress).HasMaxLength(250);
            builder.Property(x => x.CalibrationCompany).HasMaxLength(250);
            builder.Property(x => x.CalibrationFax).HasMaxLength(15);
            builder.Property(x => x.CalibrationTel).HasMaxLength(15);
            builder.Property(x => x.SupplyAddress).HasMaxLength(250);
            builder.Property(x => x.SupplyName).HasMaxLength(250);
            builder.Property(x => x.SupplyFax).HasMaxLength(15);
            builder.Property(x => x.SupplyTel).HasMaxLength(15);
            builder.Property(x => x.Countery).HasMaxLength(50);
        }
    }
}