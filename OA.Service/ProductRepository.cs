using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OA.Domain;
using OA.Repository;

namespace OA.Service
{
    public class ProductRepository : IProductRepository
    {
        private readonly IRepository<Product> _repository;
        public ProductRepository(IRepository<Product> repository)
        {
            _repository = repository;
        }

        
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
        public async Task AddAsync(Product entity)
        {
            await _repository.AddAsync(entity);
        }
        public async Task UpdateAsync(Product entity)
        {
            await _repository.UpdateAsync(entity);
        }
        public async Task DeleteAsync(Product entity)
        {
            await _repository.DeleteAsync(entity);
        }
    }
}
