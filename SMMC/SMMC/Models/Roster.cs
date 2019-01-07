using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SMMC.Models
{
    public class Roster
    {
        public int RosterID { get; set; }

        [Required(ErrorMessage = "Roster date is Required!")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RosterDate { get; set; }



        public int LessonID { get; set; }

        [Required(ErrorMessage = "Lesson Name is Required!")]
        public string LessonName { get; set; }

        [Required(ErrorMessage = "Size is Required!")]
        public int Size { get; set; }

        [Required(ErrorMessage = "Start Time is Required!")]
        //[DisplayFormat(DataFormatString = "{hh:mm}", ApplyFormatInEditMode = true)]
        public string StartTime { get; set; }

        public string InstrumentName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LessonDate { get; set; }



        public int PersonID { get; set; }

        [Required(ErrorMessage = "Firstname is Required!")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Surname is Required!")]
        public string Surname { get; set; }

        public string Role { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public int Skill { get; set; }



        public int EnsemblesID { get; set; }

        [Required(ErrorMessage = "Ensembles Name value is Required!")]
        public string EnsemblesName { get; set; }
    }
}
