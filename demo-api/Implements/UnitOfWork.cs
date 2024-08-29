using demo.api.Implements;
using demo.api.Interfaces;
using demo_api.Data;
using demo_api.Models;

namespace _2Sport_BE.Repository.Implements
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestDeployContext _dbContext;
        public UnitOfWork(TestDeployContext dbContext)
        {
            _dbContext = dbContext;
        }
        private IGenericRepository<Brand> _brandRepository;
        
        public IGenericRepository<Brand> BrandRepository
        {
            get
            {
                if (_brandRepository == null)
                {
                    _brandRepository = new GenericRepository<Brand>(_dbContext);
                }
                return _brandRepository;
            }
        }

        
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public async Task<bool> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
