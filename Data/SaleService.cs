using Microsoft.EntityFrameworkCore;

namespace MyBlazorApp.Data
{
    public class SaleService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SaleService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Sale>> GetAllSalesAsync()
        {
            return await _applicationDbContext.Sales.ToListAsync();
        }

        public async Task<Sale> AddSaleAsync(Sale sale)
        {
            // TODO: transaction
            Sale saleSended = (await _applicationDbContext.Sales.AddAsync(sale)).Entity;
            await _applicationDbContext.SaveChangesAsync();
            return saleSended;
        }
    }
}