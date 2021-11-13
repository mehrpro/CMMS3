using System;
using System.Collections.Generic;
namespace CMMS3.Models.Entities
{
    /// <summary>
    /// درخواست تعمیر
    /// </summary>
    public class RequestRepair
    {

        public RequestRepair()
        {
            ConsumableParts = new HashSet<ConsumablePart>();
            WorkOrders = new HashSet<WorkOrder>();
            Repairouts = new HashSet<Repairout>();

        }

        public long ID { get; set; }
        public bool IsActive { get; set; }
        public bool IsRepairOut { get; set; }
        public bool IsDelete { get; set; }
        public bool IsClose { get; set; }
        public bool EM { get; set; }
        public int CompanyID_FK { get; set; }
        public Company Company { get; set; }
        public int MachineryID_FK { get; set; }
        public Machinery Machinery { get; set; }
        public string UserID_FK { get; set; }
        public UserApplication UserApplication { get; set; }
        public DateTime RequestDataTime { get; set; }
        public int PublicTypeID_FK { get; set; }
        public PublicType PublicType { get; set; }
        public int ApplicantID_FK { get; set; }
        public Applicant Applicant { get; set; }
        public string RequestTitle { get; set; }


        public virtual ICollection<ConsumablePart> ConsumableParts { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        public virtual ICollection<Repairout> Repairouts { get; set; }






    }
}