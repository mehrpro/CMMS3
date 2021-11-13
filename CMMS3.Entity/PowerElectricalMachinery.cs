namespace PME.Models.Entities
{
  public  class PowerElectricalMachinery
    {
        public int ID { get; set; }
        public int MachineryID_FK { get; set; }
        public Machinery Machinery { get; set; }
        public string Title { get; set; }
        public string Manifactor { get; set; }
        public string KW { get; set; }
        public int RPM { get; set; }
        public string Voltag { get; set; }
        public string Amper { get; set; }
        public bool IsDelete { get; set; }

    }
}
