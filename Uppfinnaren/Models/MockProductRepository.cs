using System.Collections.Generic;
using System.Linq;

namespace Uppfinnaren.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product { ProductId = 1, Name = "Skottkärra", Price = 899, Description = "Den ultimata skottkärran som väcker snack i trädgårdarna!", Category = _categoryRepository.AllCategories.ToList()[3],  ImageUrl = "~/images/skottkärra.jpg", InStock = true},
                new Product { ProductId = 2, Name = "Bord", Price = 1399, Description = "En fantastisk pjäs hemma i köket att hacka salladen på!", Category = _categoryRepository.AllCategories.ToList()[3], ImageUrl = "~/images/bord.jpg", InStock = true},
                new Product { ProductId = 3, Name = "Verktygslåda", Price = 349, Description = "En låda att ha verktygen i!", Category = _categoryRepository.AllCategories.ToList()[3], ImageUrl = "~/images/verktygslåda.jpg", InStock = true}
            };

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(x => x.ProductId == productId);
        }
    }
}
