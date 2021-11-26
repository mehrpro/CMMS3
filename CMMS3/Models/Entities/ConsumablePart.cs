
namespace CMMS3.Models.Entities
{
    public class ConsumablePart
    {
        public long Id { get; set; }
        public long RequestIdFk { get; set; }
        public RequestRepair RequestRepair { get; set; }
        public string ConsumablePartTitel { get; set; }
        public int Number { get; set; }
        public int UnitIdFk { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
