using System;

namespace PME.Models.Entities
{
    public class Repairout
    {
        public int ID { get; set; }
        public int CompanyID_FK { get; set; }
        public int UserID_FK { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public long RequestID_FK { get; set; }
        public RequestRepair RequestRepair { get; set; }

        public string RequestRepairOut { get; set; }

        public DateTime Regidtered { get; set; }

        public string RepairOutFullName { get; set; }

        public string RepairReportOut { get; set; }
        public DateTime BackendRequest { get; set; }
        public bool IsClosed { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }


    }
}
