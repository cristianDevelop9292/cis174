
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class Assignment7_1ViewModel
    {
        [Required]
        [StringLength(25, MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1900", "12/31/2018", ErrorMessage = "Date is out of range, must be between 1/1/1900 - 12/31/2018")]
        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(25)]
        public string Email { get; set; }

        [Required]
        [Compare("ConfirmPassword")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Country")]
            public string SelectedValue1 { get; set; }
            public string SelectedValue2 { get; set; }
            public IEnumerable<string> Country { get; set; }
            public IEnumerable<SelectListItem> Items { get; set; }
            = new List<SelectListItem>
            {
            new SelectListItem{Value= "csharp", Text="C#"},
            new SelectListItem{Value= "python", Text="Python"},
            new SelectListItem{Value= "cpp", Text="C++"},
            new SelectListItem{Value= "java", Text="Java"},
            };
        
    }
}
