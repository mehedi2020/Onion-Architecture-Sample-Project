using Microsoft.EntityFrameworkCore;
using SampleArchi.Core.Domain.Entities;

namespace SampleArchi.Core.Application.Services.ProductService
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
