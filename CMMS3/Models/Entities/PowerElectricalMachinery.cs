namespace CMMS3.Models.Entities
{
    public class PowerElectricalMachinery
    {
        public int Id { get; set; }
        public int MachineryIdFk { get; set; }
        public Machinery Machinery { get; set; }
        public string Title { get; set; }
        public string Manifactor { get; set; }
        public string Kw { get; set; }
        public int Rpm { get; set; }
        public string Voltag { get; set; }
        public string Amper { get; set; }
        public bool IsDelete { get; set; }

    }
}
