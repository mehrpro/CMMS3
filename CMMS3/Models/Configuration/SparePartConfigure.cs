using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class SparePartConfigure : IEntityTypeConfiguration<SparePart>
    {
        public void Configure(EntityTypeBuilder<SparePart> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.MachineryID_FK).IsRequired();
            builder.Property(x => x.Minimal).IsRequired();
            builder.Property(x => x.SparePartNumber).HasMaxLength(150);
            builder.Property(x => x.SparePartTitle).IsRequired().HasMaxLength(250);
            builder.Property(x => x.UnitID_FK).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.IsActive).IsRequired();
        }
    }
}