using System.Collections.Generic;

namespace PME.Models.Entities
{
    /// <summary>
    /// کاربران
    /// </summary>
    public class ApplicationUser
    {
        public ApplicationUser()
        {
            RequestRepairs = new HashSet<RequestRepair>();
            Codings = new HashSet<Coding>();
            Cleams = new HashSet<Cleam>();
            Repairouts = new HashSet<Repairout>();
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FullName { get; set; }

        public string Editor { get; set; }
        public bool LimetedCompany { get; set; }

        public bool Enabled { get; set; }
        public int CompanyID_FK { get; set; }
        public Company Company { get; set; }

        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }
        public virtual ICollection<Coding> Codings { get; set; }
        public virtual ICollection<Cleam> Cleams { get; set; }
        public virtual ICollection<Repairout> Repairouts { get; set; }
        }
}