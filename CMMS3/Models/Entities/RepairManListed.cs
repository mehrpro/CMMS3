namespace CMMS3.Models.Entities
{
    public class RepairManListed
    {


        public long ID { get; set; }
        public int RepairManIdFk { get; set; }
        public RepairMan RepairMan { get; set; }
        public long WorkOrderIdFk { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public bool IsDelete { get; set; }

    }
}