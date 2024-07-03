using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 1,ImageUrl="/images/1.jfif", ProductName = "HP Bilgisayar", Price = 17_000,ShowCase = true },
                new Product() { ProductId = 2, CategoryId = 2,ImageUrl="/images/2.jfif", ProductName = "Klavye", Price = 500,ShowCase = true },
                new Product() { ProductId = 3, CategoryId = 2,ImageUrl="/images/3.jfif", ProductName = "Fare", Price = 1_000,ShowCase = true },
                new Product() { ProductId = 4, CategoryId = 2,ImageUrl="/images/4.jfif", ProductName = "Monitor", Price = 1_200,ShowCase = true },
                new Product() { ProductId = 5, CategoryId = 2,ImageUrl="/images/5.jfif", ProductName = "Adaptor", Price = 1_850,ShowCase = true },
                new Product() { ProductId = 6, CategoryId = 1,ImageUrl="/images/6.jfif", ProductName = "Laptop", Price = 19_000,ShowCase = true }
           );
          
        }
    }
}
