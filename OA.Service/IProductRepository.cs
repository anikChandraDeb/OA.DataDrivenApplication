using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OA.Domain;

namespace OA.Service
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task AddAsync(Product entity);
        Task UpdateAsync(Product entity);
        Task DeleteAsync(Product entity);
    }
}
