using System.Collections.Generic;

namespace CMMS3.Models.Entities
{

    /// <summary>
    /// لیست ماشین آلات
    /// </summary>
    public class Machinery
    {
        public Machinery()
        {
            RequestRepairs = new HashSet<RequestRepair>();
            ServicePeriodes = new HashSet<ServicePeriode>();
            SpareParts = new HashSet<SparePart>();
            PowerElectricalMachineries = new HashSet<PowerElectricalMachinery>();
            IdentityMachineries = new HashSet<IdentityMachinery>();

        }

        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public int CompanyId { get; set; }
        public long IdentityCodeIdFk { get; set; }
        public IdentityCode IdentityCode { get; set; }
        public int ApplicantIdFk { get; set; }
        public Applicant Applicant { get; set; }

        public string MachineryTitle { get; set; }
        public string Description { get; set; }



        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }
        public virtual ICollection<ServicePeriode> ServicePeriodes { get; set; }
        public virtual ICollection<SparePart> SpareParts { get; set; }
        public virtual ICollection<PowerElectricalMachinery> PowerElectricalMachineries { get; set; }
        public virtual ICollection<IdentityMachinery> IdentityMachineries { get; set; }




    }
}
