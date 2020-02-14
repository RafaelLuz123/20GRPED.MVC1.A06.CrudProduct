using _20GRPED.MVC1.A06.CrudProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _20GRPED.MVC1.A06.CrudProduct.Repositories
{
    public class ProductDictionaryInMemoryRepository : IProductRepository
    {
        public static Dictionary<int, ProductModel> Products { get; set; }
            = new Dictionary<int, ProductModel>
            {
                { 1, new ProductModel{ Id = 1, Nome = "SampleProduct1" } }
            };

        public void Add(ProductModel newProductModel)
        {
            Products.Add(newProductModel.Id, newProductModel);
        }

        public List<ProductModel> GetAll()
        {
            return Products.Select(x => x.Value).ToList();
        }

        public ProductModel GetById(int id)
        {
            if (Products.TryGetValue(id, out var productModel))
            {
                return productModel;
            }
            return null;
        }

        public void Remove(int id)
        {
            if (Products.ContainsKey(id))
            {
                Products.Remove(id);
            }
        }

        public List<ProductModel> SearchByName(string name)
        {
            var results = Products.Where(x => x.Value.Nome.Contains(
                name, StringComparison.OrdinalIgnoreCase));

            return results.Select(x => x.Value).ToList();
        }

        public void Update(ProductModel updatedProductModel)
        {
            if (Products.TryGetValue(updatedProductModel.Id, out var oldProductModel))
            {
                oldProductModel.Nome = updatedProductModel.Nome;
            }
        }
    }
}
