using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMMC.Models
{
    public class Student
    {
        [Required(ErrorMessage = "person ID is Required!")]
        public int personID { get; set; }
        public int parentID { get; set; }

        [Required(ErrorMessage = "Firstname is Required!")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Parent Firstname is Required!")]
        public string ParentName { get; set; }


        [Required(ErrorMessage = "Surname is Required!")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Parent Surname is Required!")]
        public string ParentSurname { get; set; }

        [Required(ErrorMessage = "Skill is Required!")]
        public string skill { get; set; }

        [Required(ErrorMessage = "role is Required!")]
        public string role { get; set; }

        [Required(ErrorMessage = "Parent Role is Required!")]
        public string ParentRole { get; set; }

        [Required(ErrorMessage = "school name is Required!")]
        public string schoolName { get; set; }

        [Required(ErrorMessage = "enrolled is Required!")]
        public bool enrolled { get; set; }

        public int costID { get; set; }
        [Required(ErrorMessage = "Cost is Required!")]
        public int costOpenID { get; set; }

        [Required(ErrorMessage = "Instrument is Required!")]
        public string instrumentName { get; set; }
        [Required(ErrorMessage = "Student Fee is Required!")]
        public decimal studentFee { get; set; }
        [Required(ErrorMessage = "Open Fee is Required!")]
        public decimal OpenFee { get; set; }

        [Required(ErrorMessage = "Email is Required!")]
        public string emailAddress { get; set; }
        [Required(ErrorMessage = "Phone Number is Required!")]
        public int phone { get; set; }

    }
}
