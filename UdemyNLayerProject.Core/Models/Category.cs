using System.Collections.Generic;

namespace UdemyNLayerProject.Core.Models
{
    public class Category
    {

        public Category()
        {
             Products= new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; }


        public ICollection<Product> Products { get; set; }


    }
}