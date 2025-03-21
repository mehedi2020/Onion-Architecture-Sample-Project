using SampleArchi.Core.Domain.Entities;

namespace SampleArchi.Core.Domain.Interfaces
{
    public interface IProductRepository
    {
        Product GetById(int id);
        void Add(Product product);
    }
}
