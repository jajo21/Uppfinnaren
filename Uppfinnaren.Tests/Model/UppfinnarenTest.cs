using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Uppfinnaren.Models;
using Xunit;

namespace Uppfinnaren.Tests
{
    public class UppfinnarenTest
    {
        [Fact]
        public void CanFilterProductsByCategoryMock() //Checking if method can get all products in a category
        {
            MockProductRepository testProductRepository = new();
            MockCategoryRepository testCategoryRepository = new();

            var category = testCategoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Verktyg");
            var products = testProductRepository.GetProductsByCategory(category);

            int expectedCategoryId = 4; // Verktygs kategori id är nummer 4 och bör stämma överens med verktygen som befinner sig i den kategorin
            int actualCategoryId = products.FirstOrDefault().CategoryId; // Hämtar första produktens information och tar fram CategoryId för att jämföra, bör vara 4
            int expectedProductCount = 2; // Finns endast 2 produkter i den kategorin för stunden
            int actualProductCount = products.Count(); // Räknar antalet produkter i kategorin

            Assert.Equal(expectedCategoryId, actualCategoryId); // Går detta test igenom betyder det att man kan filtrera produkterna via kategorier
            Assert.Equal(expectedProductCount, actualProductCount); // Går detta test igenom betyder det att den har fått med alla produkter i kategorin
        }
        [Fact]
        public void CanFilterProductsByCategoryMock2()
        {
            MockProductRepository testProductRepository = new();

            var products = testProductRepository.AllProducts.Where(p => p.Category.CategoryName == "Verktyg");

            int expectedCategoryId = 4; 
            int actualCategoryId = products.FirstOrDefault().CategoryId;
            int expectedProductCount = 2; 
            int actualProductCount = products.Count();

            Assert.Equal(expectedCategoryId, actualCategoryId); // Går detta test igenom betyder det att man kan filtrera produkterna via kategorier
            Assert.Equal(expectedProductCount, actualProductCount); // Går detta test igenom betyder det att den har fått med alla produkter i kategorin
        }

        [Fact]
        public void CanGetProductById() // Kollar om metoden kan hämta en produkt genom rätt id
        {
            MockProductRepository testProductRepository = new();

            var actualProductName = testProductRepository.GetProductById(1).Name;
            string expectedProductName = "Skottkärra";

            Assert.Equal(expectedProductName, actualProductName);
        }
        [Fact]
        public void CanGetAllProducts() // Kollar om metoden kan hämta alla produkter
        {
            MockProductRepository testProductRepository = new();

            var actualNumberOfProducts = testProductRepository.AllProducts.Count();
            int expectedNumberOfProducts = 6;

            Assert.Equal(expectedNumberOfProducts, actualNumberOfProducts);
        }

        [Fact]
        public void CanGetAllCategories() // Kollar om metoden kan hämta alla produkter
        {
            MockCategoryRepository testCategoryRepository = new();

            var actualNumberOfProducts = testCategoryRepository.AllCategories.Count();
            int expectedNumberOfProducts = 5;

            Assert.Equal(expectedNumberOfProducts, actualNumberOfProducts);
        }

        [Fact]
        public void CanFilterProductsByCategoryDataBase()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("test").Options;

            using var _appDbContext = new AppDbContext(options);
            ProductRepository productRepository = new(_appDbContext);
            CategoryRepository categoryRepository = new(_appDbContext);

            var category = categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Tavlor");
            var products = productRepository.GetProductsByCategory(category);

            int actualCategoryId = 1;
            int expectedCategoryId = products.FirstOrDefault().CategoryId;

            Assert.Equal(actualCategoryId, expectedCategoryId);
        }
    }
}
