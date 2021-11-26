
namespace CMMS3.Models.Entities
{
    public class SparePart
    {
        public int Id { get; set; }
        public int MachineryIdFk { get; set; }
        public Machinery Machinery { get; set; }
        public string SparePartTitle { get; set; }
        public string SparePartNumber { get; set; }
        public int Minimal { get; set; }
        public int UnitIdFk { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
