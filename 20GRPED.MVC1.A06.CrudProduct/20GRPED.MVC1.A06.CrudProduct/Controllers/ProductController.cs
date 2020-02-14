using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20GRPED.MVC1.A06.CrudProduct.Models;
using _20GRPED.MVC1.A06.CrudProduct.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _20GRPED.MVC1.A06.CrudProduct.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(
            IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View(_productRepository.GetAll());
        }

        public ActionResult SearchByName(string name)
        {
            return View("Index", _productRepository.SearchByName(name));
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var product = _productRepository.GetById(id);

            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel newProductModel)
        {
            try
            {
                // TODO: Add insert logic here
                _productRepository.Add(newProductModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _productRepository.GetById(id);
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductModel updatedProductModel)
        {
            try
            {
                // TODO: Add update logic here
                _productRepository.Update(updatedProductModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var product = _productRepository.GetById(id);
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ProductModel productModel)
        {
            try
            {
                // TODO: Add delete logic here
                _productRepository.Remove(productModel.Id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}