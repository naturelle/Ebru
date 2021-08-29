﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiProject.Models;

namespace RestApiProject.Services
{
    interface IProductDataService
    {
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string searchTerm);
        ProductModel GetProductById(int id);
        int Insert(ProductModel product);
        int Delete(ProductModel product);
        int Update(ProductModel product);

    }
}
