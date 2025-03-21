using SampleArchi.Core.Application.DTOS.Product;

namespace SampleArchi.Core.Application.Services.ProductService
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return products.Select(p => new ProductDto { Id = p.Id, Name = p.Name, Price = p.Price });
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return new ProductDto { Id = product.Id, Name = product.Name, Price = product.Price };
        }

        public async Task AddProductAsync(ProductDto productDto)
        {
            var product = new Product { Name = productDto.Name, Price = productDto.Price };
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(ProductDto productDto)
        {
            var product = new Product { Id = productDto.Id, Name = productDto.Name, Price = productDto.Price };
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }
    }
}
