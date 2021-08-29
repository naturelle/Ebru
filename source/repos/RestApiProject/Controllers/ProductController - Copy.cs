//using Bogus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiProject.Models;
using RestApiProject.Services;

namespace RestApiProject.Controllers
{
    [ApiController]
    [Route("api/")]
    public class ProductControllerAPI : ControllerBase
    {
        ProductsDAO products;
        public ProductControllerAPI ()
        {
            products = new ProductsDAO();
        }

        //define what kind of request can be used in this event
        //views dont work with restapi
        [HttpGet]
        public ActionResult <IEnumerable <ProductModel>> Index()
        {
              return products.GetAllProducts();
        }

        [HttpGet("searchproducts/{searchTerm}")]
        public ActionResult<IEnumerable<ProductModel>> SearchResults(string searchTerm)
        {
           
            return products.SearchProducts(searchTerm);
        }
        [HttpGet("ShowDetails/{Id}")]
        public ActionResult <ProductModel> ShowDetails(int id)
        {
            
            return products.GetProductById(id);
        }

        [HttpPost("ProcessCreate")]
        public ActionResult <int> ProcessCreate(ProductModel product)
        {
            
            int newId =  products.Insert(product);
            return newId;
        }
        [HttpPut("ProcessEdit")]
        public ActionResult <ProductModel> ProcessEdit(ProductModel product)
        {
            products.Update(product);
            return products.GetProductById(product.Id);
        }
        

        [HttpDelete("Delete/{Id}")]
        public ActionResult<bool> Delete(int Id)
        {
            bool success = false;
            ProductModel product = products.GetProductById(Id);
           products.Delete(product);
             success = true;
            return success;

        }


    }
}
