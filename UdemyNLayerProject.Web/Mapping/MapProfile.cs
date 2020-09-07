using AutoMapper;

using UdemyNLayerProject.Core.Models;
using UdemyNLayerProject.Web.DTOs;

namespace UdemyNLayerProject.Web.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<CategoryWithProductDto, Category>();
            CreateMap<Category, CategoryWithProductDto>();
            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<ProductWithCategoryDto, Product>();
        }
    }
}