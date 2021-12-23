using System.Collections.Generic;

namespace Uppfinnaren.Models
{
    //Kategori-interface, alla klasser som ärver det här interfacet behöver inkludera samma metoder.
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
        public Category GetCategoryByName(string categoryName);
    }
}
