using System.Collections.Generic;

namespace Uppfinnaren.Models
{
    //Produkt-interface, alla klasser som ärver det här interfacet behöver inkludera samma metoder.
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        public IEnumerable<Product> GetProductsByCategory(Category category);
    }
}
