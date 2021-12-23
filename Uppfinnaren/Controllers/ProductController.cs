using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Uppfinnaren.Models;
using Uppfinnaren.ViewModels;

namespace Uppfinnaren.Controllers
{
    public class ProductController : Controller //Controller = en bas-controller klass som kommer från ASP.MVC
    {
        //Behöver komma åt datan från model-repositorys, använder interface för det.
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        //Konstrukturn tar två inparametrar som redan är "registrerade" i startup-filen under services.
        //Det här gör att vi kommer åt modelklasserna genom controllern
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        // Det här är en "action-method" som hanterar de inkommande anropen(requests) och returnerar en vy beroende
        // på värdet i category som beror på vilken produkt-kategori användaren klickar på i menyn.
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
                Category chosenCategory = _categoryRepository.GetCategoryByName(category);
                products = _productRepository.GetProductsByCategory(chosenCategory).OrderBy(p => p.ProductId);
                currentCategory = chosenCategory.CategoryName;
            }

            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }
    }
}
