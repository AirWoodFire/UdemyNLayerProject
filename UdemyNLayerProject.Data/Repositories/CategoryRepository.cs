using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyNLayerProject.Core.Models;
using UdemyNLayerProject.Core.Repositories;

namespace UdemyNLayerProject.Data.Repositories
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        private  AppDbContext _appDbContext {get=> _Context as AppDbContext;}

        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int id)
        {
            return await _appDbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}