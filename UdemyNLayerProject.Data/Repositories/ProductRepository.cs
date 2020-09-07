using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyNLayerProject.Core.Models;
using UdemyNLayerProject.Core.Repositories;

namespace UdemyNLayerProject.Data.Repositories
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        private AppDbContext appDbContext {get=>_Context as  AppDbContext;}

        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int id)
        {
            var product = await appDbContext.Products.Include((x => x.Category)).FirstOrDefaultAsync(x => x.Id == id);
            return product;
        }
    }
}