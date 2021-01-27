using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExperimentApp2.models
{
    public class GradesModel 
    {
        // GET: /<controller>/ // required fields and range set for every input
        [Required(ErrorMessage = "{0} is required")]
        [Range(typeof(int), "0", "100",
               ErrorMessage = "{0} can only be between {1} and {2}")]

        public double exam { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(typeof(int), "0", "100",
               ErrorMessage = "{0} can only be between {1} and {2}")]

        public double quiz { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(typeof(int), "0", "100",
               ErrorMessage = "{0} can only be between {1} and {2}")]

        public double assignment { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(typeof(int), "0", "100",
               ErrorMessage = "{0} can only be between {1} and {2}")]

        public double project { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(typeof(int), "0", "100",
               ErrorMessage = "{0} can only be between {1} and {2}")]

        public double intex { get; set; }
    }
}
