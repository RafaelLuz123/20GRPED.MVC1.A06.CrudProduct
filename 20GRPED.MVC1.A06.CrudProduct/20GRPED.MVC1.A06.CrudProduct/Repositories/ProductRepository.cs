using _20GRPED.MVC1.A06.CrudProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public ProductModel GetById(int id)
        {
            var product = Products.FirstOrDefault(x => x.Id == id);

            //foreach (var item in Products)
            //{
            //    if (item.Id == id)
            //        return item;
            //}
            //return null;

            return product;
        }
    }
}
