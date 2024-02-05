using Microsoft.EntityFrameworkCore;

namespace MyBlazorApp.Data
{
    public class ProductService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _applicationDbContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductAsync(string Id)
        {
            Product product = await _applicationDbContext.Products.FirstOrDefaultAsync(c => c.ProductId.Equals(Id));
            return product;
        }
    }
}