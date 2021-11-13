using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class ConsumablePartConfigure : IEntityTypeConfiguration<ConsumablePart>
    {
        public void Configure(EntityTypeBuilder<ConsumablePart> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.ConsumablePartTitel).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.UnitID_FK).IsRequired();
            builder.Property(x => x.RequestID_FK).IsRequired();

        }
    }
}