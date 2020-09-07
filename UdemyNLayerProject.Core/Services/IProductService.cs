﻿using System.Threading.Tasks;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Core.Services
{
    public interface IProductService:IService<Product>
    {

        Task<Product> GetWithCategoryByIdAsync(int id);
        //bool ControlInnerBarcode(Product product);
    }
}