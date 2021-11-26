using System;
using CMMS3.Services;
using Microsoft.EntityFrameworkCore;

namespace CMMS3.Infrastructure
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : class
    {
        ICompanyRepository CompanyRep { get; }
        void Commit();
    }

    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext, new()
    {

        private readonly DbContext _db;
        private ICompanyRepository _companyRepository;
        public UnitOfWork()
        {
            _db = new TContext();
        }
        public ICompanyRepository CompanyRep => _companyRepository ??= new CompanyRepository(_db);






        public void Commit()
        {
            _db.SaveChanges();
        }


        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
