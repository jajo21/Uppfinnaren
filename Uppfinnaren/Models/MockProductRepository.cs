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
                new Product
                {
                    ProductId = 1,
                    Name = "Skottkärra",
                    Price = 899,
                    Description = "Den ultimata skottkärran som väcker snack i trädgårdarna!",
                    CategoryId = 4,
                    ImageUrl = "~/images/skottkärra.jpg",
                    InStock = true,
                    Category = _categoryRepository.AllCategories.ToList()[3]
                },
                new Product 
                {                 
                    ProductId = 2,
                    Name = "Bord",
                    Price = 1399,
                    Description = "En fantastisk pjäs hemma i köket att hacka salladen på!",
                    CategoryId = 5,
                    ImageUrl = "~/images/bord.jpg",
                    InStock = true,
                    Category = _categoryRepository.AllCategories.ToList()[4]
                },
                new Product 
                {                 
                    ProductId = 3,
                    Name = "Verktygslåda",
                    Price = 349,
                    Description = "En låda att ha verktygen i!",
                    CategoryId = 4,
                    ImageUrl = "~/images/verktygslåda.jpg",
                    InStock = true,
                    Category = _categoryRepository.AllCategories.ToList()[3]
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Vackert halsband",
                    Price = 1999,
                    Description = "Ett vackert halsband",
                    CategoryId = 3,
                    ImageUrl = "~/images/halsband.jpg",
                    InStock = true,
                    Category = _categoryRepository.AllCategories.ToList()[2]
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Huvudskulptur",
                    Price = 3999,
                    Description = "En härlig skupltur till ett pangpris",
                    CategoryId = 2,
                    ImageUrl = "~/images/skulptur.jpg",
                    InStock = true,
                    Category = _categoryRepository.AllCategories.ToList()[1]
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Fågeltavlan",
                    Price = 1499,
                    Description = "Ett vackert verk på fåglar",
                    CategoryId = 1,
                    ImageUrl = "~/images/tavla.jpg",
                    InStock = true,
                    Category = _categoryRepository.AllCategories.ToList()[0]
                },
            };

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(x => x.ProductId == productId);
        }

        public IEnumerable<Product> GetProductsByCategory(Category category)
        {
            return AllProducts.Where(p => p.CategoryId == category.CategoryId);
        }
    }
}
