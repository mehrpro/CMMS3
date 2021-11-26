using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMMS3.Models.Configuration
{
    public class RoleConfigure : IEntityTypeConfiguration<RoleApplication>
    {
        public void Configure(EntityTypeBuilder<RoleApplication> builder)
        {
            builder.HasData(
                new RoleApplication
                {
                    Id = "d4ea52ed-d66e-466b-86d6-5c699c05b546",
                    Name = "admin",
                    NormalizedName = "ADMIN"
                });
        }
    }
}
