
using demo_api.Models;

namespace demo.api.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Brand> BrandRepository { get; }
        void Save();
        Task<bool> SaveChanges();
    }
}
