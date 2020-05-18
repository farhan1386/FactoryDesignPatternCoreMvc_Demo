using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPatternCoreMvc_Demo.Models
{
    public class EmployeeType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name ="Employee Type")]
        public string EmployeeTypeName { get; set; }
    }
}
