using CMMS3.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CMMS3
{
    public class CMMSContext : IdentityDbContext
    {
        public CMMSContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<UserApplication> UserApplications { get; set; }
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<IdentityCode> IdentityCodes { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ConsumablePart> ConsumableParts { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Machinery> Machineries { get; set; }
        public virtual DbSet<RequestRepair> RequestRepairs { get; set; }
        public virtual DbSet<SubGroup> SubGroups { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        public virtual DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public virtual DbSet<PublicType> PublicTypes { get; set; }
        public virtual DbSet<RepairMan> RepairMens { get; set; }
        public virtual DbSet<RepairManListed> RepairManListeds { get; set; }
        public virtual DbSet<SparePart> SpareParts { get; set; }
        public virtual DbSet<ServicePeriode> ServicePeriodes { get; set; }
        public virtual DbSet<IdentityMachinery> IdentityMachineries { get; set; }
        public virtual DbSet<PowerElectricalMachinery> PowerElectricalMachineries { get; set; }
        public virtual DbSet<Repairout> Repairouts { get; set; }


    }
}