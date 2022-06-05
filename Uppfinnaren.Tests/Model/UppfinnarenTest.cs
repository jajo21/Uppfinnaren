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
        public void FilterProductsByCategoryMockData() //Testar att metoderna GetCategoryByName och GetProductByCategory kan hämta alla produkter i specifik kategori.
        {
            MockCategoryRepository _categoryRepository = new();
            MockProductRepository _productRepository = new();

            var category = _categoryRepository.GetCategoryByName("Verktyg");
            var products = _productRepository.GetProductsByCategory(category);

            int expectedCategoryId = 4; // Verktygs kategori id är nummer 4 och bör stämma överens med verktygen som befinner sig i den kategorin
            int actualCategoryId = products.FirstOrDefault().CategoryId; // Hämtar första produktens information och tar fram CategoryId för att jämföra, bör vara 4
            int expectedProductCount = 2; // Finns endast 2 produkter i den kategorin för stunden
            int actualProductCount = products.Count(); // Räknar antalet produkter i kategorin

            Assert.Equal(expectedCategoryId, actualCategoryId); // Går detta test igenom betyder det att man kan filtrera produkterna via kategorier
            Assert.Equal(expectedProductCount, actualProductCount); // Går detta test igenom betyder det att den har fått med alla produkter i kategorin
        }
        [Fact]
        public void FilterProductsByCategoryDataBase() // I stort sätt samma funktionalitet som testas som ovan. Fast mot InMemoryDatabasen istället.
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("test").Options;

            using var _appDbContext = new AppDbContext(options);
            ProductRepository _productRepository = new(_appDbContext);
            CategoryRepository _categoryRepository = new(_appDbContext);

            var category = _categoryRepository.GetCategoryByName("Tavlor");
            var products = _productRepository.GetProductsByCategory(category);

            int expectedCategoryId =  1;
            int actualCategoryId = products.FirstOrDefault().CategoryId;
            int expectedCategories = 5;
            int actualCategories = _categoryRepository.AllCategories.Count();    // Här kollar jag däremot att alla kategorier finns i InMemoryDatabas-listan
                                                                                
            Assert.Equal(expectedCategoryId,actualCategoryId);
            Assert.Equal(expectedCategories,actualCategories);
        }
        [Fact]
        public void GetAllProducts() // Testar att AllProducts innehåller rätt antal kategorier
        {
            MockProductRepository _productRepository = new();

            var actualNumberOfProducts = _productRepository.AllProducts.Count();
            int expectedNumberOfProducts = 6;

            Assert.Equal(expectedNumberOfProducts, actualNumberOfProducts);
        }
        [Fact]
        public void GetAllCategories() // Testar att AllCategories innehåller rätt antal kategorier
        {
            MockCategoryRepository _categoryRepository = new();

            var actualNumberOfProducts = _categoryRepository.AllCategories.Count();
            int expectedNumberOfProducts = 5;

            Assert.Equal(expectedNumberOfProducts, actualNumberOfProducts);
        }
    }
}
