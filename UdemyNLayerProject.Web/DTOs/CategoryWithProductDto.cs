using System.Collections.Generic;
using UdemyNLayerProject.Web.DTOs;

namespace UdemyNLayerProject.Web.DTOs
{
    public class CategoryWithProductDto:CategoryDto
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}