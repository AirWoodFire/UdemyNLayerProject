using UdemyNLayerProject.Web.DTOs;

namespace UdemyNLayerProject.Web.DTOs
{
    public class ProductWithCategoryDto:ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}