using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SMMC.Models
{
    public class Performance
    {
        [Required(ErrorMessage = "Performance is Required!")]
        public int PerformanceID { get; set; }

        public int EnrolmentID { get; set; }

        public int EnsemblesID { get; set; }

        [Required(ErrorMessage = "Firstname is Required!")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Ensembles Name is Required!")]
        public string EnsemblesName { get; set; }

        [Required(ErrorMessage = "Surname is Required!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Venue is Required!")]
        public string Venue { get; set; }

        [Required(ErrorMessage = "Performance Type is Required!")]
        public string PerformanceType { get; set; }

        [Required(ErrorMessage = "Performance Title is Required!")]
        public string PerformanceTitle { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Performance Date is Required!")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? PerformanceDate { get; set; }
    }
}
