using System.Collections.Generic;

namespace CMMS3.Models.Entities
{
    /// <summary>
    /// واحدهای اندازه گیری
    /// </summary>
    public class UnitOfMeasurement
    {

        public UnitOfMeasurement()
        {
            ConsumableParts = new HashSet<ConsumablePart>();
            ServicePeriodes = new HashSet<ServicePeriode>();
            SpareParts = new HashSet<SparePart>();
        }


        public int Id { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }


        public virtual ICollection<ConsumablePart> ConsumableParts { get; set; }
        public virtual ICollection<ServicePeriode> ServicePeriodes { get; set; }
        public virtual ICollection<SparePart> SpareParts { get; set; }
    }
}
