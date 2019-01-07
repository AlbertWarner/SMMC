using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMMC.Models
{
    public class Lesson 
    {
        [Required(ErrorMessage = "Lesson ID is Required!")]
        public int LessonID { get; set; }

        [Required(ErrorMessage = "Lesson name is Required!")]
        public string LessonName { get; set; }

        [Required(ErrorMessage = "Lesson date is Required!")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Class size is Required!")]
        public int Size { get; set; }

        [Required(ErrorMessage = "Time is Required!")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Instrument is Required!")]
        public int InstrumentID { get; set; }

        [Required(ErrorMessage = "Instrument is Required!")]
        public string Instrument { get; set; }

        public int count { get; set; }
    }
}
