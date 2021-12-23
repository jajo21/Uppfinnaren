using System.Collections.Generic;
using Uppfinnaren.Models;

namespace Uppfinnaren.ViewModels
{
    //Här adderas en property för varje typ av data som vi kommer att behöva i vår view
    public class ProductListViewModel
    {
        IEnumerable<Product> products;
        string currentCategory;
        public IEnumerable<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }   
        }
        public string CurrentCategory
        {
            get { return this.currentCategory; }
            set { this.currentCategory = value; }  
        }
    }
}
