namespace Uppfinnaren.Models
{
    public class Product
    {
        int productId;
        string name;
        string description;
        double price;
        string imageUrl;
        bool inStock;
        int categoryId;
        Category category;
        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public string ImageUrl
        {
            get { return this.imageUrl; }
            set { this.imageUrl = value; }
        }
        public bool InStock
        {
            get { return this.inStock; }
            set { this.inStock = value; }
        }
        public int CategoryId
        {
            get { return this.categoryId; }
            set { this.categoryId = value; }
        }
        public Category Category
        {
            get { return this.category; }
            set { this.category = value; }
        }
    }
}
