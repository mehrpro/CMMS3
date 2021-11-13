
namespace CMMS3.Models.Entities
{
    public class SparePart
    {
        public int ID { get; set; }
        public int MachineryID_FK { get; set; }
        public Machinery Machinery { get; set; }
        public string SparePartTitle { get; set; }
        public string SparePartNumber { get; set; }
        public int Minimal { get; set; }
        public int UnitID_FK { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
