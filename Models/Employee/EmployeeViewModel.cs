using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamASP.Models.Employee
{
    public class EmployeeViewModel
    {
        [Required(ErrorMessage = "Enter ten")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter code")]
        [Display(Name = "Code")]
        public string code { get; set; }


        [Required(ErrorMessage = "Enter address")]
        [Display(Name = "Rank")]
        public string rank { get; set; }

        [Required(ErrorMessage = "Enter danh muc")]
        [Display(Name = "Department")]
        public int department_id { get; set; }
    }
}
