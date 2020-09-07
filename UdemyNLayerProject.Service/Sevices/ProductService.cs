using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UdemyNLayerProject.Core.Models;
using UdemyNLayerProject.Core.Repositories;
using UdemyNLayerProject.Core.Services;
using UdemyNLayerProject.Core.UnitOfWorks;

namespace UdemyNLayerProject.Service.Sevices
{
    public class ProductService:Sevice<Product>,IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetWithCategoryByIdAsync(id);
        }
    }
}