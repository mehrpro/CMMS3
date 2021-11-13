using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CMMS3.Models.Entities
{
    /// <summary>
    /// کاربران
    /// </summary>
    public class UserApplication : IdentityUser
    {
        public UserApplication()
        {
            RequestRepairs = new HashSet<RequestRepair>();
            IdentityCodes = new HashSet<IdentityCode>();
            Repairouts = new HashSet<Repairout>();
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool LimetedCompany { get; set; }
        public int CompanyID_FK { get; set; }
        public Company Company { get; set; }

        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }
        public virtual ICollection<IdentityCode> IdentityCodes { get; set; }
        public virtual ICollection<Repairout> Repairouts { get; set; }
    }
}