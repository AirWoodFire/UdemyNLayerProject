﻿using System.Threading.Tasks;
using UdemyNLayerProject.Core.Repositories;
using UdemyNLayerProject.Core.UnitOfWorks;
using UdemyNLayerProject.Data.Repositories;

namespace UdemyNLayerProject.Data.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IProductRepository Products => _productRepository ?? new ProductRepository(_context);
        public ICategoryRepository Categories => _categoryRepository ?? new CategoryRepository(_context);
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}