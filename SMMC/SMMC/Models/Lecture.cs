using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMMC.Models
{
    public class Lecture 
    {
        [Required(ErrorMessage = "person ID is Required!")]
        public int personID { get; set; }

        [Required(ErrorMessage = "Firstname is Required!")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Surname is Required!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Skill is Required!")]
        public string skill { get; set; }

        [Required(ErrorMessage = "role is Required!")]
        public string role { get; set; }
        [Required(ErrorMessage = "Salary is Required!")]
        public decimal salary { get; set; }
        [Required(ErrorMessage = "Phone Number is Required!")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Email is Required!")]
        public string email { get; set; }

        [Required(ErrorMessage = "Qualification is Required!")]
        public string qualificationType { get; set; }
        [Required(ErrorMessage = "Qualification ID is Required!")]
        public int qualificationTypeID { get; set; }
        [Required(ErrorMessage = "Instrument is Required!")]
        public int instrumentID { get; set; }
        [Required(ErrorMessage = "Instrument is Required!")]
        public string instrument { get; set; }


    }
}
