using Microsoft.EntityFrameworkCore;

namespace Uppfinnaren.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        DbSet<Product> products;

        DbSet<Category> categories;

        public DbSet<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }

        public DbSet<Category> Categories
        {
            get { return this.categories; }
            set { this.categories = value; }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Tavlor", Description = "Vackra tavlor." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Skulpturer", Description = "Fantastiska skulpturer." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Smycken", Description = "Underbara smycken." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Verktyg", Description = "Funktionella uppfinningar som fungerar till och för olika verktyg i livet." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Möbler", Description = "Uppfinningsrika möbler" });

            //seed pies
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Skottkärra",
                Price = 899,
                Description = "Den ultimata skottkärran som väcker snack i trädgårdarna!",
                CategoryId = 4,
                ImageUrl = "~/images/skottkärra.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Bord",
                Price = 1399,
                Description = "En fantastisk pjäs hemma i köket att hacka salladen på!",
                CategoryId = 5,
                ImageUrl = "~/images/bord.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Verktygslåda",
                Price = 349,
                Description = "En låda att ha verktygen i!",
                CategoryId = 4,
                ImageUrl = "~/images/verktygslåda.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Halsband",
                Price = 1999,
                Description = "Ett vackert halsband",
                CategoryId = 3,
                ImageUrl = "~/images/halsband.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Skulptur",
                Price = 3999,
                Description = "En härlig skupltur till ett pangpris",
                CategoryId = 2,
                ImageUrl = "~/images/skulptur.jpg",
                InStock = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Tavla",
                Price = 1499,
                Description = "Ett vackert verk på fåglar",
                CategoryId = 1,
                ImageUrl = "~/images/tavla.jpg",
                InStock = true
            });
        }
    }
}
