using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactoryDesignPatternCoreMvc_Demo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Position { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "EMP Number")]
        public string EmployeeNumber { get; set; }

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        [Required]
        [Display(Name = "Hourly Pay")]
        public decimal HourlyPay { get; set; }

        [Required]
        public decimal Bonus { get; set; }

        [Required]
        [Display(Name = "EMP Type")]
        public int EmployeeTypeId { get; set; }
        [ForeignKey("EmployeeTypeId")]
        public EmployeeType EmployeeType { get; set; }
    }
}
