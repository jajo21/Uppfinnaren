﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Uppfinnaren.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> AllProducts
        {
            get 
            { 
                return _appDbContext.Products.Include(c => c.Category);  
            }
        }
        public IEnumerable<Product> GetProductsByCategory(Category category)
        {
            return _appDbContext.Products.Where(p => p.CategoryId == category.CategoryId);
        }
    }
}
