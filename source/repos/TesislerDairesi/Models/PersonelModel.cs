using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesislerDairesi.Models
{
    public class PersonelModel
    {
        
        public int Id { get; set; }

        [DisplayName("Ad Soyad")]
        public string Name { get; set; }

        [DisplayName("Sicil No")]
        public int Sicil { get; set; }

        [DisplayName("Daire")]
        public string Department { get; set; }

        [DisplayName("Ünvan")]
        public string JobTitle { get; set; }

        [DisplayName("Meslek")]
        public string Education { get; set; }

        [DisplayName("Başlangıç Tarihi")]
        [DataType(DataType.Date)]
        public int StartDate { get; set; }


    }
}
