﻿using System.Collections.Generic;
using System.Linq;

namespace Uppfinnaren.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;

        public Category GetCategoryByName(string categoryName)
        {
            return _appDbContext.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
        }
    }
}
