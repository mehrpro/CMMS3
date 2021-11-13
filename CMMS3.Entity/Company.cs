using System.Collections.Generic;

namespace PME.Models.Entities
{
    /// <summary>
    /// شرکت ها
    /// </summary>
    public class Company
    {
        public Company()
        {

            this.SubGroups = new HashSet<SubGroup>();
            this.Groups = new HashSet<Group>();
            this.Codings = new HashSet<Coding>();
            Applicants = new HashSet<Applicant>();
            RequestRepairs = new HashSet<RequestRepair>();
            ApplicationUsers = new HashSet<ApplicationUser>();

        }

        public int ID { get; set; }
        public byte CompnayIndex { get; set; }
        public string CompanyTitle { get; set; }
        public string Description { get; set; }



        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<SubGroup> SubGroups { get; set; }
        public virtual ICollection<Coding> Codings { get; set; }
        public virtual ICollection<Applicant> Applicants { get; set; }
        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
