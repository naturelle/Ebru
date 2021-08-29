using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiProject.Models
{
    public class ProductModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Product name")]
        public string Name { get; set; }
        [DisplayName("Cost")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("What you get")]
        public string Description { get; set; }

    }
}
