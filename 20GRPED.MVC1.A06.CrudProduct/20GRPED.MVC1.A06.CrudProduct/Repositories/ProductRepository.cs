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
                    Name = "SampleProduct1"
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

        public List<ProductModel> SearchByName(string name)
        {
            var results = Products.Where(x => x.Name.Contains(
                name, StringComparison.OrdinalIgnoreCase));

            //var results2 = new List<ProductModel>();
            //foreach (var item in Products)
            //{
            //    if (item.Nome.Contains(name, StringComparison.OrdinalIgnoreCase))
            //    {
            //        results2.Add(item);
            //    }
            //}
            //return results2;

            return results.ToList();
        }

        public void Add(ProductModel newProductModel)
        {
            Products.Add(newProductModel);
        }

        public void Update(ProductModel updatedProductModel)
        {
            var oldProductModel = GetById(updatedProductModel.Id);

            oldProductModel.Name = updatedProductModel.Name;
        }

        public void Remove(int id)
        {
            var productToRemove = GetById(id);

            Products.Remove(productToRemove);
        }
    }
}
