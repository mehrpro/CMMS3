using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class RepairManListedConfigure : IEntityTypeConfiguration<RepairManListed>
    {
        public void Configure(EntityTypeBuilder<RepairManListed> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.RepairManIdFk).IsRequired();
            builder.Property(x => x.WorkOrderIdFk).IsRequired();
        }
    }
}