using System.Collections.Generic;
using _20GRPED.MVC1.A06.CrudProduct.Models;

namespace _20GRPED.MVC1.A06.CrudProduct.Repositories
{
    public interface IProductRepository
    {
        void Add(ProductModel newProductModel);
        List<ProductModel> GetAll();
        ProductModel GetById(int id);
        void Remove(int id);
        List<ProductModel> SearchByName(string name);
        void Update(ProductModel updatedProductModel);
    }
}