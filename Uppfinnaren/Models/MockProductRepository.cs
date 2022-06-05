using System.Collections.Generic;
using System.Linq;

namespace Uppfinnaren.Models
{
    public class MockProductRepository : IProductRepository
    {
        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product { ProductId = 1, Name = "Skottkärra", Price = 899, Description = "Den ultimata skottkärran som väcker snack i trädgårdarna!", ImageUrl = "~/images/skottkärra.jpg", InStock = true},
                new Product { ProductId = 2, Name = "Bord", Price = 1399, Description = "En fantastisk pjäs hemma i köket att hacka salladen på!", ImageUrl = "~/images/bord.jpg", InStock = true},
                new Product { ProductId = 3, Name = "Verktygslåda", Price = 349, Description = "En låda att ha verktygen i!", ImageUrl = "~/images/verktygslåda.jpg", InStock = true}
            };

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(x => x.ProductId == productId);
        }
    }
}
