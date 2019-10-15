using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class HouseViewModel
    {
        [Required]
        [StringLength(25)]
        [Display(Name = "Bedrooms")]
        public string Bedrooms { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Square Feet")]
        public string SquareFeet { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Date Built")]
        public string DateBuilt { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Flooring")]
        public string Flooring { get; set; }
    }
}
