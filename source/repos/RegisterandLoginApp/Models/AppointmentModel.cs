using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterandLoginApp.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Patient's app date")]
        public DateTime AppointmentDate { get; set; }

        [DataType(DataType.Currency)]
        [DisplayName("Patient's net worth")]
        public decimal  PatientNetWorth{ get; set; }

        [DisplayName("Patient's doctor name")]
        public string DoctorName { get; set; }

        [Range(1,10)]
        [DisplayName("Patient's perceived levelof pain")]
        public int PainLevel { get; set; }



    }
}
