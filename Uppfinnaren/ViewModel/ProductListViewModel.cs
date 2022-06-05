using System.Collections.Generic;
using Uppfinnaren.Models;

namespace Uppfinnaren.ViewModel
{
    public class ProductListViewModel
    {
        IEnumerable<Product> products;
        string currentPage;
        public IEnumerable<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }   
        }
        public string CurrentPage
        {
            get { return this.currentPage; }
            set { this.currentPage = value; }  
        }
    }
}
