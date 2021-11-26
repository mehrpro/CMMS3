using System.ComponentModel.DataAnnotations;

namespace CMMS3.Models.DTO.CompanyDTO
{
    public class CompanyListDTO
    {
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }
        [Display(Name = "کد شرکت")]
        public byte CompnayIndex { get; set; }
        [Display(Name = "نام شرکت")]
        public string CompanyTitle { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }
    }
}