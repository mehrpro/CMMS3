using System;

namespace PME.Models.Entities
{
    public class IdentityMachinery
    {
        public int ID { get; set; }
        public int MachinerID_FK { get; set; }
        public Machinery Machinery { get; set; }
        public string TypeDevice { get; set; }
        public DateTime dateTimeImport { get; set; }
        public DateTime dateTimeStart { get; set; }
        public DateTime dateStartWaranty { get; set; }
        public DateTime dateEndWaranty { get; set; }
        public bool  Calibration { get; set; }
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
