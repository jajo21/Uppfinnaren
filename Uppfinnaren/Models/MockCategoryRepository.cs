using System.Collections.Generic;

namespace Uppfinnaren.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Tavlor", Description="Vackra tavlor."},
                new Category{CategoryId=2, CategoryName="Skulpturer", Description="Fantastiska skulpturer."},
                new Category{CategoryId=3, CategoryName="Smycken", Description="Underbara smycken."},
                new Category{CategoryId=4, CategoryName="Verktyg", Description="Funktionella uppfinningar som fungerar till och för olika verktyg i livet."},
                new Category{CategoryId=5, CategoryName="Möbler", Description ="Uppfinningsrika möbler"}
            };
    }
}
