using CMMS3.Infrastructure;
using CMMS3.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CMMS3.Services
{
    public interface ICompanyRepository : IRepasitoryBase<Company>
    {

    }

    public class CompanyRepository : RepasitoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(DbContext context) : base(context)
        {
        }
    }
}