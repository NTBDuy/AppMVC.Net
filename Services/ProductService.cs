using MCVTest01.Models;

namespace App.Services
{
    public class ProductService : List<ProductModel>
    {
        public ProductService()
        {
            this.AddRange(new ProductModel[] {
                new ProductModel { Id = 1, NameOfProduct = "Samsung Galaxy S10", Price = 1000 },
                new ProductModel { Id = 2, NameOfProduct = "Iphone X", Price = 2000 },
                new ProductModel { Id = 3, NameOfProduct = "Sony", Price = 3000 },
                new ProductModel { Id = 4, NameOfProduct = "Samsung Galaxy S40", Price = 4000 },
                new ProductModel { Id = 5, NameOfProduct = "Samsung Galaxy S50", Price = 5000 },
                new ProductModel { Id = 6, NameOfProduct = "Samsung Galaxy S60", Price = 6000 },
                new ProductModel { Id = 7, NameOfProduct = "Samsung Galaxy S70", Price = 7000 },
            });
        }
    }
}