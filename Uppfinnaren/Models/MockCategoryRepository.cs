using System.Collections.Generic;
using System.Linq;

namespace Uppfinnaren.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Tavlor"},
                new Category{CategoryId=2, CategoryName="Skulpturer"},
                new Category{CategoryId=3, CategoryName="Smycken"},
                new Category{CategoryId=4, CategoryName="Verktyg"},
                new Category{CategoryId=5, CategoryName="Möbler"}
            };
        public Category GetCategoryByName(string categoryName)
        {
            return AllCategories.FirstOrDefault(c => c.CategoryName == categoryName);
        }
    }
}
