using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMMC.Models
{
    public class Enrolment 
    {

        public int EnrolmentID { get; set; }

        public int PersonID { get; set; }

        [Required(ErrorMessage = "Firstname is Required!")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Surname is Required!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Skill is Required!")]
        public string Skill { get; set; }

        public int LessonID { get; set; }

        [Required(ErrorMessage = "Lesson name is Required!")]
        public string LessonName { get; set; }

        [Required(ErrorMessage = "Instrument is Required!")]
        public string Instrument { get; set; }


        public int EnsemblesID { get; set; }

        [Required(ErrorMessage = "Ensemble name is Required!")]
        public string EnsembleName { get; set; }

        [Required(ErrorMessage = "Lesson date is Required!")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Start time is Required!")]
        public string Start { get; set; }
    }
}
