using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class PublicTypeConfigure : IEntityTypeConfiguration<PublicType>
    {
        public void Configure(EntityTypeBuilder<PublicType> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Group).IsRequired();
            builder.HasMany(x => x.RequestRepairs)
                .WithOne(x => x.PublicType)
                .HasForeignKey(x => x.PublicTypeID_FK)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}