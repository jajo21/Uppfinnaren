using System.Collections.Generic;

namespace Uppfinnaren.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        Product GetProductById(int productId);
        public IEnumerable<Product> GetProductsByCategory(Category category);
    }
}
