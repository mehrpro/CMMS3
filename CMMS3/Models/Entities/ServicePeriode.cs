using System;

namespace CMMS3.Models.Entities
{
    public class ServicePeriode
    {
        public int Id { get; set; }
        public int MachineryIdFk { get; set; }
        public Machinery Machinery { get; set; }
        public string ServiceTitle { get; set; }
        public int Periode { get; set; }
        public int UnitIdFk { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime Registred { get; set; }
    }
}
