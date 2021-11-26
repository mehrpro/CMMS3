using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class ServicePeriodeConfigure : IEntityTypeConfiguration<ServicePeriode>
    {
        public void Configure(EntityTypeBuilder<ServicePeriode> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.MachineryIdFk).IsRequired();
            builder.Property(x => x.Periode).IsRequired();
            builder.Property(x => x.ServiceTitle).IsRequired().HasMaxLength(250);
            builder.Property(x => x.UnitIdFk).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.Registred).IsRequired().HasColumnType("datetime");
        }
    }
}