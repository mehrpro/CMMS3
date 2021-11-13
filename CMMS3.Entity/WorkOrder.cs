using System;
using System.Collections.Generic;

namespace PME.Models.Entities
{
    /// <summary>
    /// گزارش تعمیر
    /// </summary>
    public class WorkOrder
    {
        public WorkOrder()
        {
            RepairManListeds = new HashSet<RepairManListed>();
        }

        public long ID { get; set; }
        public bool IsDelete { get; set; }

        public long RequestID_FK { get; set; }
        public RequestRepair RequestRepair { get; set; }



        public int WorkingTotalMin { get; set; }
        public int StopTotalMin { get; set; }

        public bool RepairOutside { get; set; }
        public int? RepairOutSideReportID_FK { get; set; }

        public DateTime StartWorking { get; set; }
        public DateTime EndWorking { get; set; }
        public bool Cause_Exhaustion { get; set; }
        public bool Cause_OperatorNegligence { get; set; }
        public bool Cause_QualityofSpareParts { get; set; }

        public bool OtherError { get; set; }
        public string OtherErrorDescription { get; set; }
        public string ReportRepair { get; set; }
        public bool PersonHours { get; set; }
        public short PersonHoursTime { get; set; }
        public string PersonHoursDescription { get; set; }
        public bool ProductionPlanning { get; set; }
        public short ProductionPlanningTime { get; set; }
        public string ProductionPlanningDescription { get; set; }
        public bool NoSpareParts { get; set; }
        public short NoSparePartsTime { get; set; }
        public string NoSparePartsDescription { get; set; }
        public bool Other { get; set; }
        public short OtherTime { get; set; }
        public string OtherDescription { get; set; }
        public bool CloseRequest { get; set; }
        public DateTime DateTimeClosing { get; set; }

        public virtual ICollection<RepairManListed> RepairManListeds { get; set; }
    }
}
