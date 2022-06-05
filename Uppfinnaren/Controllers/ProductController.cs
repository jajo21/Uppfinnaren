using Microsoft.AspNetCore.Mvc;
using Uppfinnaren.Models;
using Uppfinnaren.ViewModel;

namespace Uppfinnaren.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ViewResult List()
        {
            ProductListViewModel productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.AllProducts;

            productListViewModel.CurrentPage = "Uppfinningar till salu";
            return View(productListViewModel);
        }
    }
}
