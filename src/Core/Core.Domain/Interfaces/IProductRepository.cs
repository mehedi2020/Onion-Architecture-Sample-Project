using SampleArchi.Core.Application.DTOS.Product;
using SampleArchi.Core.Domain.Entities;

namespace SampleArchi.Core.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<ProductDto> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product); 
        Task DeleteAsync(int id); 
    }
}
