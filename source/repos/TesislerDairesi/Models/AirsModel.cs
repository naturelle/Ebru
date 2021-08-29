using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesislerDairesi.Models
{
    public class AirsModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Air Code")]
        public string Code { get; set; }

        [DisplayName("Air Title")]

        public decimal Title { get; set; }

        [DisplayName("Air Body")]
        public string Body { get; set; }

        [DisplayName("Category")]
        public string Category { get; set; }

        [DisplayName("Relevant to")]
        [Range(1,int.MaxValue, ErrorMessage ="deneme errormesajı")]
        public string Relevant { get; set; }

        //başta boş olacak
        public AirsModel()
        {
                
        }

    }
}
