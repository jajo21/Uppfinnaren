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
        public void FilterProductsByCategoryMockData() //Testar att metoderna GetCategoryByName och GetProductByCategory kan h�mta alla produkter i specifik kategori.
        {
            MockCategoryRepository _categoryRepository = new();
            MockProductRepository _productRepository = new();

            var category = _categoryRepository.GetCategoryByName("Verktyg");
            var products = _productRepository.GetProductsByCategory(category);

            int expectedCategoryId = 4; // Verktygs kategori id �r nummer 4 och b�r st�mma �verens med verktygen som befinner sig i den kategorin
            int actualCategoryId = products.FirstOrDefault().CategoryId; // H�mtar f�rsta produktens information och tar fram CategoryId f�r att j�mf�ra, b�r vara 4
            int expectedProductCount = 2; // Finns endast 2 produkter i den kategorin f�r stunden
            int actualProductCount = products.Count(); // R�knar antalet produkter i kategorin

            Assert.Equal(expectedCategoryId, actualCategoryId); // G�r detta test igenom betyder det att man kan filtrera produkterna via kategorier
            Assert.Equal(expectedProductCount, actualProductCount); // G�r detta test igenom betyder det att den har f�tt med alla produkter i kategorin
        }
        [Fact]
        public void FilterProductsByCategoryDataBase() // I stort s�tt samma funktionalitet som testas som ovan. Fast mot InMemoryDatabasen ist�llet.
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
            int actualCategories = _categoryRepository.AllCategories.Count();    // H�r kollar jag d�remot att alla kategorier finns i InMemoryDatabas-listan
                                                                                
            Assert.Equal(expectedCategoryId,actualCategoryId);
            Assert.Equal(expectedCategories,actualCategories);
        }
        [Fact]
        public void GetAllProducts() // Testar att AllProducts inneh�ller r�tt antal kategorier
        {
            MockProductRepository _productRepository = new();

            var actualNumberOfProducts = _productRepository.AllProducts.Count();
            int expectedNumberOfProducts = 6;

            Assert.Equal(expectedNumberOfProducts, actualNumberOfProducts);
        }
        [Fact]
        public void GetAllCategories() // Testar att AllCategories inneh�ller r�tt antal kategorier
        {
            MockCategoryRepository _categoryRepository = new();

            var actualNumberOfProducts = _categoryRepository.AllCategories.Count();
            int expectedNumberOfProducts = 5;

            Assert.Equal(expectedNumberOfProducts, actualNumberOfProducts);
        }
    }
}
