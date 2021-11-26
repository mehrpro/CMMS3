using System;

namespace CMMS3.Models.Entities
{
    public class IdentityMachinery
    {
        public int Id { get; set; }
        public int MachinerIdFk { get; set; }
        public Machinery Machinery { get; set; }
        public string TypeDevice { get; set; }
        public DateTime DateTimeImport { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime DateStartWaranty { get; set; }
        public DateTime DateEndWaranty { get; set; }
        public bool Calibration { get; set; }
        public bool NewDivice { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Wight { get; set; }
        public string Company { get; set; }
        public string Countery { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyTel { get; set; }
        public string CompanyFax { get; set; }
        public string SupplyName { get; set; }
        public string SupplyAddress { get; set; }
        public string SupplyTel { get; set; }
        public string SupplyFax { get; set; }
        public string CalibrationCompany { get; set; }
        public string CalibrationAddress { get; set; }
        public string CalibrationTel { get; set; }
        public string CalibrationFax { get; set; }



    }
}
