using TranGiaBao_0230_lab02.Models;
using System.Collections.Generic;

namespace TranGiaBao_0230_lab02.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);

    }
}
