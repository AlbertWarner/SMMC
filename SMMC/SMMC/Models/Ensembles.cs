using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMMC.Models
{
    public class Ensembles
    {
        public int EnsembleID { get; set; }

        [Required(ErrorMessage = "Ensemble name is Required!")]
        public string EnsembleName { get; set; }

    }
}
