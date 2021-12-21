using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Uppfinnaren.Models;
using Uppfinnaren.ViewModel;

namespace Uppfinnaren.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            ProductListViewModel productListViewModel = new()
            {
                Products = _productRepository.AllProducts,
                CurrentCategory = "Uppfinningar till salu"
            };
            return View(productListViewModel);
        }
        public ViewResult Pictures()
        {
            var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Tavlor");
            var pictures = _productRepository.GetProductsByCategory(category);
            ProductListViewModel productListViewModel = new()
            {
                Products = pictures,
                CurrentCategory = "Tavlor",
            };
            return View(productListViewModel);
        }
        public ViewResult Sculptures()
        {
            var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Skulpturer");
            var sculptures = _productRepository.GetProductsByCategory(category);
            ProductListViewModel productListViewModel = new() 
            { 
                Products = sculptures,
                CurrentCategory = "Skulpturer"
            };
            return View(productListViewModel);
        }
        public ViewResult Jewelry()
        {
            var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Smycken");
            var jewelry = _productRepository.GetProductsByCategory(category);
            ProductListViewModel productListViewModel = new()
            {
                Products = jewelry,
                CurrentCategory = "Smycken"
            };
            return View(productListViewModel);
        }
        public ViewResult Tools()
        {
            var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Verktyg");
            var tools = _productRepository.GetProductsByCategory(category);
            ProductListViewModel productListViewModel = new()
            {
                Products = tools,
                CurrentCategory = "Verktyg"
            };
            return View(productListViewModel);
        }

        public ViewResult Furniture()
        {
            var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Skulpturer");
            var furniture = _productRepository.GetProductsByCategory(category);
            ProductListViewModel productListViewModel = new()
            {
                Products = furniture,
                CurrentCategory = "Möbler"
            };
            return View(productListViewModel);
        }
    }
}
