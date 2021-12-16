using System.Collections.Generic;

namespace Uppfinnaren.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts 
        { 
            get { return this.AllProducts; } 
        }
        Product GetProductById(int productId); 
    }
}
