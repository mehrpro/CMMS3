using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class PowerElectricalMachineryConfigure : IEntityTypeConfiguration<PowerElectricalMachinery>
    {
        public void Configure(EntityTypeBuilder<PowerElectricalMachinery> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.MachineryIdFk).IsRequired();
            builder.Property(x => x.Manifactor).HasMaxLength(250);
            builder.Property(x => x.Title).HasMaxLength(250);
            builder.Property(x => x.Kw).HasMaxLength(10);
            builder.Property(x => x.Voltag).HasMaxLength(10);
            builder.Property(x => x.Amper).HasMaxLength(10);
            builder.Property(x => x.IsDelete).IsRequired();
        }
    }
}