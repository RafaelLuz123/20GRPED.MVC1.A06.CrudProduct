using _20GRPED.MVC1.A06.CrudProduct.Models;
using System.Collections.Generic;

namespace _20GRPED.MVC1.A06.CrudProduct.Repositories
{
    public class ProductRepository
    {
        public static List<ProductModel> Products { get; set; }
            = new List<ProductModel>
            {
                new ProductModel
                {
                    Id = 1,
                    Nome = "SampleProduct1"
                }
            };

        public List<ProductModel> GetAll()
        {
            return Products;
        }
    }
}
