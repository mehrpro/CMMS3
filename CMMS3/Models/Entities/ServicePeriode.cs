using System;

namespace CMMS3.Models.Entities
{
    public class ServicePeriode
    {
        public int ID { get; set; }
        public int MachineryID_FK { get; set; }
        public Machinery Machinery { get; set; }
        public string ServiceTitle { get; set; }
        public int Periode { get; set; }
        public int UnitID_FK { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime Registred { get; set; }
    }
}
