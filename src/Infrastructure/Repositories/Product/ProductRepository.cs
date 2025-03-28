﻿using Microsoft.EntityFrameworkCore;
using SampleArchi.Core.Application.DTOS.Product;
using SampleArchi.Core.Domain.Entities;
using SampleArchi.Core.Domain.Interfaces;

namespace SampleArchi.Core.Application.Services.ProductService
{

    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        Task<IEnumerable<ProductDto>> IProductRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<ProductDto> IProductRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
