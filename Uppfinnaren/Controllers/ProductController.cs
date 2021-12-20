using Microsoft.AspNetCore.Mvc;
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
            ProductListViewModel productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.AllProducts;

            productListViewModel.CurrentCategory = "Uppfinningar till salu";
            return View(productListViewModel);
        }
    }
}
