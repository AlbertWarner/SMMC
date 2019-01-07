using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SMMC.Models
{
    public class Piece
    {
        public int PieceID { get; set; }

        [Required(ErrorMessage = "Piece Type is Required!")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Part is Required!")]
        public string Part { get; set; }

        [Required(ErrorMessage = "License is Required!")]
        public string License { get; set; }

        [Required(ErrorMessage = "Total Copies is Required!")]
        public int TotalCopies { get; set; }

        [Required(ErrorMessage = "Distributed Copies is Required!")]
        public int DistributedCopies { get; set; }

        [Required(ErrorMessage = "Returned Copies is Required!")]
        public int ReturnedCopies { get; set; }

        public int PieceHireID { get; set; }

        public int PerformanceID { get; set; }

        public int EnrolmentID { get; set; }

        [Required(ErrorMessage = "Returned value is Required!")]
        public bool Returned { get; set; }

        [Required(ErrorMessage = "Firstname is Required!")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Venue is Required!")]
        public string Venue { get; set; }

        [Required(ErrorMessage = "Surname is Required!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Piece hire date is Required!")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PieceHireDate { get; set; }

        [Required(ErrorMessage = "Performance date is Required!")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PerformanceDate { get; set; }
    }
}
