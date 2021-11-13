using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class PowerElectricalMachineryConfigure : IEntityTypeConfiguration<PowerElectricalMachinery>
    {
        public void Configure(EntityTypeBuilder<PowerElectricalMachinery> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.MachineryID_FK).IsRequired();
            builder.Property(x => x.Manifactor).HasMaxLength(250);
            builder.Property(x => x.Title).HasMaxLength(250);
            builder.Property(x => x.KW).HasMaxLength(10);
            builder.Property(x => x.Voltag).HasMaxLength(10);
            builder.Property(x => x.Amper).HasMaxLength(10);
            builder.Property(x => x.IsDelete).IsRequired();
        }
    }
}