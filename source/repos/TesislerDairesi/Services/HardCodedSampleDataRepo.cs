using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesislerDairesi.Models;

namespace TesislerDairesi.Services
{
    //implement interface :IProductDataService
    public class HardCodedSampleDataRepo : IProductDataService
    {
        static List<ProductModel> productsList = new List<ProductModel>();
        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            if(productsList.Count == 0)
            {
                productsList.Add(new ProductModel { Id = 1, Name = "mouse", Price = 5.99m, Description = "mfdndmn" });
                productsList.Add(new ProductModel { Id = 2, Name = "tt", Price = 15.99m, Description = "ffsf sds" });
                productsList.Add(new ProductModel { Id = 3, Name = "rr", Price = 25.99m, Description = "kkghfd" });
                productsList.Add(new ProductModel { Id = 4, Name = "ff", Price = 35.99m, Description = "mm" });

                for (int i = 0; i < 100; i++)
                {
                    productsList.Add(new Faker<ProductModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review())
                        );
                }
            }
      
          
            return productsList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
