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

        public ViewResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.AllProducts.OrderBy(p => p.ProductId);
                currentCategory = "Alla uppfinningar";
            }
            else
            {
                Category actualCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category);
                products = _productRepository.GetProductsByCategory(actualCategory)
                    .OrderBy(p => p.ProductId);
                currentCategory = actualCategory.CategoryName;
            }

            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        // GAMMAL KOD, spara tills innan inlämning och du har fått svar på vad som är bäst och inte
        //public ViewResult List()
        //{
        //    ProductListViewModel productListViewModel = new()
        //    {
        //        Products = _productRepository.AllProducts,
        //        CurrentCategory = "Alla uppfinningar"
        //    };
        //    return View(productListViewModel);
        //}
        //public ViewResult Category(int id)
        //{
        //    var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == id);
        //    var products = _productRepository.GetProductsByCategory(category);
        //    return View(category);
        //}
        //public ViewResult Pictures()
        //{
        //    var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Tavlor");
        //    var pictures = _productRepository.GetProductsByCategory(category);
        //    ProductListViewModel productListViewModel = new()
        //    {
        //        Products = pictures,
        //        CurrentCategory = category.CategoryName
        //    };
        //    return View(productListViewModel);
        //}
        //public ViewResult Sculptures()
        //{
        //    var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Skulpturer");
        //    var sculptures = _productRepository.GetProductsByCategory(category);
        //    ProductListViewModel productListViewModel = new() 
        //    { 
        //        Products = sculptures,
        //        CurrentCategory = category.CategoryName
        //    };
        //    return View(productListViewModel);
        //}
        //public ViewResult Jewelry()
        //{
        //    var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Smycken");
        //    var jewelry = _productRepository.GetProductsByCategory(category);
        //    ProductListViewModel productListViewModel = new()
        //    {
        //        Products = jewelry,
        //        CurrentCategory = category.CategoryName
        //    };
        //    return View(productListViewModel);
        //}
        //public ViewResult Tools()
        //{
        //    var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Verktyg");
        //    var tools = _productRepository.GetProductsByCategory(category);
        //    ProductListViewModel productListViewModel = new()
        //    {
        //        Products = tools,
        //        CurrentCategory = category.CategoryName
        //    };
        //    return View(productListViewModel);
        //}

        //public ViewResult Furniture()
        //{
        //    var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Skulpturer");
        //    var furniture = _productRepository.GetProductsByCategory(category);
        //    ProductListViewModel productListViewModel = new()
        //    {
        //        Products = furniture,
        //        CurrentCategory = category.CategoryName
        //    };
        //    return View(productListViewModel);
        //}
    }
}
