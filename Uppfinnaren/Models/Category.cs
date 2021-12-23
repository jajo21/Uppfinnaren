using System.Collections.Generic;

namespace Uppfinnaren.Models
{
    public class Category
    {
        int categoryId;
        string categoryName;
        List<Product> products;

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
    }
}
