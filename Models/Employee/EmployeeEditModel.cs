using System.ComponentModel.DataAnnotations;

namespace ExamASP.Models.Employee
{
    public class EmployeeEditModel
    {
        [Required]
        public int id { get; set; }

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
