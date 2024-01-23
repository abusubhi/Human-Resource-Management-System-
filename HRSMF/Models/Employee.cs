using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRSMF.Models
{
    public class Employee
    {
        [Key]
        [Required]
        [Display(Name = "Employee Id")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string LastName { get; set; }

        [Required]
        public DateTime Birth_Date { get; set; }

        [Required]
        public DateTime Hire_Date { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Phone { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string JopTitle { get; set; }

        public decimal Salary { get; set; }
        public int VacationDays { get; set; }
        public int SickDays { get; set; }

        [Required]
        public int ManagerId { get; set; }

        public bool IsActive { get; set; } = true;


        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }


    }
}