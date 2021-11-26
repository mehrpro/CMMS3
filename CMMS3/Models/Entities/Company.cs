using System;
using System.Collections.Generic;

namespace CMMS3.Models.Entities
{
    /// <summary>
    /// شرکت ها
    /// </summary>
    public class Company
    {
        public Company()
        {
            SubGroups = new HashSet<SubGroup>();
            Groups = new HashSet<Group>();
            IdentityCodes = new HashSet<IdentityCode>();
            Applicants = new HashSet<Applicant>();
            RequestRepairs = new HashSet<RequestRepair>();
            UserApplications = new HashSet<UserApplication>();
        }

        public int Id { get; set; }
        public byte CompnayIndex { get; set; }
        public string CompanyTitle { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime DateDelete { get; set; }




        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<SubGroup> SubGroups { get; set; }
        public virtual ICollection<IdentityCode> IdentityCodes { get; set; }
        public virtual ICollection<Applicant> Applicants { get; set; }
        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }
        public virtual ICollection<UserApplication> UserApplications { get; set; }
    }
}
