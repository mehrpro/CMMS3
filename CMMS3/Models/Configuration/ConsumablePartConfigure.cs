using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class ConsumablePartConfigure : IEntityTypeConfiguration<ConsumablePart>
    {
        public void Configure(EntityTypeBuilder<ConsumablePart> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.ConsumablePartTitel).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.UnitIdFk).IsRequired();
            builder.Property(x => x.RequestIdFk).IsRequired();

        }
    }
}