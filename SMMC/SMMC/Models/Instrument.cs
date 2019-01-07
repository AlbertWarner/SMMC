using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SMMC.Models
{
    public class Instrument
    {
        public int ID { get; set; }
        public int CostID { get; set; }
        public int EnrolmentID { get; set; }
        public int InstrumentID { get; set; }

        [Required(ErrorMessage = "Instrument name is Required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Firstname is Required!")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Surname is Required!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Instrument name is Required!")]
        public string InstrumentName { get; set; }

        [Required(ErrorMessage = "Fee is Required!")]
        public double Fee { get; set; }

        [Required(ErrorMessage = "Repair value is Required!")]
        public bool Repair { get; set; }

        [Required(ErrorMessage = "Returned value is Required!")]
        public bool Returned { get; set; }

        [Required(ErrorMessage = "Hire date is Required!")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }
    }
}
