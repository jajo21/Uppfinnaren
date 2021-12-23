using Microsoft.EntityFrameworkCore;

namespace Uppfinnaren.Models
{
    public class AppDbContext : DbContext // DbContext = en bas-DbContext klass som kommer från EF-Core paketet
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        DbSet<Product> products; //Databasen ska hantera produkter

        DbSet<Category> categories; //Databasen ska hantera kategorier

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
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Tavlor" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Skulpturer"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Smycken"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Verktyg"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Möbler"});

            //seed pies
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Skottkärra",
                Price = 899,
                Description = "Den ultimata skottkärran som väcker snack i trädgårdarna!",
                CategoryId = 4,
                ImageUrl = "~/images/skottkärra.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Bord",
                Price = 1399,
                Description = "En fantastisk pjäs hemma i köket att hacka salladen på!",
                CategoryId = 5,
                ImageUrl = "~/images/bord.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Verktygslåda",
                Price = 349,
                Description = "En låda att ha verktygen i!",
                CategoryId = 4,
                ImageUrl = "~/images/verktygslåda.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Vackert halsband",
                Price = 1999,
                Description = "Ett vackert halsband",
                CategoryId = 3,
                ImageUrl = "~/images/halsband.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Huvudskulptur",
                Price = 3999,
                Description = "En härlig skupltur till ett pangpris",
                CategoryId = 2,
                ImageUrl = "~/images/skulptur.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Fågeltavlan",
                Price = 1499,
                Description = "Ett vackert verk på fåglar",
                CategoryId = 1,
                ImageUrl = "~/images/tavla.jpg"
            });
        }
    }
}
