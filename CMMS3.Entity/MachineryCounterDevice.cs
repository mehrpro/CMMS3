namespace PME.Models.Entities
{
    public class MachineryCounterDevice
    {

        public int ID { get; set; }

        public int MachineryID_FK { get; set; }
        public Machinery Machinery { get; set; }

        public int SubCounterDeviceID_FK { get; set; }
        public SubCounterDevice SubCounterDevice { get; set; }

        public bool IsActive { get; set; }
    }
}
