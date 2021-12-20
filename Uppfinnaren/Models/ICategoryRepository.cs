using System.Collections.Generic;

namespace Uppfinnaren.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
