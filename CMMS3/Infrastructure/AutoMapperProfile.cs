using AutoMapper;
using CMMS3.Models.DTO;
using CMMS3.Models.DTO.CompanyDTO;
using CMMS3.Models.Entities;

namespace CMMS3.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Company, CompanyListDTO>();
        }
    }
}