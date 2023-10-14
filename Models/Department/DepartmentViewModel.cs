using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamASP.Models.Department
{
    public class DepartmentViewModel
    {
        [Required(ErrorMessage = "Enter ten")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter code")]
        [Display(Name = "Price")]
        public string code { get; set; }

        [Column(TypeName = "text")]
        [Required(ErrorMessage = "Enter address")]
        [Display(Name = "Location")]
        public string location { get; set; }

        [Required(ErrorMessage = "Enter code")]
        [Display(Name = "numberOfPersonals")]
        public int numberOfPersonals { get; set; }


    }
}
