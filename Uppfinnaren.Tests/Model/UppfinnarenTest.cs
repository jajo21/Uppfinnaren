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
        public void SeeIfConnectionWithModelsWorks()
        {
            var products = new MockProductRepository();
            Assert.True(products != null);
        }

        [Fact]
        public void CanFilterProductsByCategoryMock() //Checking if method can get all products in a category
        {
            MockProductRepository testProductRepository = new();
            MockCategoryRepository testCategoryRepository = new();

            var category = testCategoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "Verktyg");
            var products = testProductRepository.GetProductsByCategory(category);

            int expectedCategoryId = 4; // Verktygs kategori id �r nummer 4 och b�r st�mma �verens med verktygen som befinner sig i den kategorin
            int actualCategoryId = products.FirstOrDefault().CategoryId; // H�mtar f�rsta produktens information och tar fram CategoryId f�r att j�mf�ra, b�r vara 4
            int expectedProductCount = 2; // Finns endast 2 produkter i den kategorin f�r stunden
            int actualProductCount = products.Count(); // R�knar antalet produkter i kategorin

            Assert.Equal(expectedCategoryId, actualCategoryId); // G�r detta test igenom betyder det att man kan filtrera produkterna via kategorier
            Assert.Equal(expectedProductCount, actualProductCount); // G�r detta test igenom betyder det att den har f�tt med alla produkter i kategorin
        }

        [Fact]
        public void CanGetProductById() // Checking if method can get product by id
        {
            MockProductRepository testProductRepository = new();

            var actualProductName = testProductRepository.GetProductById(1).Name;

            string expectedProductName = "Skottk�rra";

            Assert.Equal(expectedProductName, actualProductName);
        }
        [Fact]
        public void CanGetAllProducts() // Checking if method can get all products
        {
            MockProductRepository testProductRepository = new();

            var actualNumberOfProducts = testProductRepository.AllProducts.Count();

            int expectedNumberOfProducts = 6;

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