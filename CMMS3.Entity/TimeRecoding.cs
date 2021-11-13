namespace PME.Models.Entities
{
    public class TimeRecoding
    {
        public long ID { get; set; }
        public int SubCounterDeviceID_FK { get; set; }
        public int TotalMin { get; set; }
        public System.DateTime Registerd { get; set; }
        public bool IsActive { get; set; }
        public bool IsRecord { get; set; }
        public bool IsDelete { get; set; }
    }
}