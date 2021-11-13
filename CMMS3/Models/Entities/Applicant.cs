using System.Collections.Generic;

namespace CMMS3.Models.Entities
{
    /// <summary>
    /// واحد درخواست کننده
    /// </summary>
    public class Applicant
    {

        public Applicant()
        {
            RequestRepairs = new HashSet<RequestRepair>();
            Machineries = new HashSet<Machinery>();
        }

        public int ID { get; set; }
        public string ApplicantTitle { get; set; }
        public string Description { get; set; }
        public int CompanyID_FK { get; set; }
        public Company Company { get; set; }


        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }
        public virtual ICollection<Machinery> Machineries { get; set; }




    }
}
