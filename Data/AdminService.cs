using Microsoft.EntityFrameworkCore;

namespace MyBlazorApp.Data
{
    public class AdminService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AdminService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Sale>> GetSalesWithDetails()
        {
            var salesWithUsers = await _applicationDbContext.Sales
                .Include(s => s.User)
                .Include(s => s.Product)
                .ToListAsync();

            return salesWithUsers;
        }
    }
}