using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Xml.Linq;

namespace WebAppCrudOpertion.Models
{
    [Table("Employees", Schema = "HR")]
    public class Employee
    {
        [Key]
        [Display(Name = "ID")]
        public int? EmployeeId { get; set; }
        [Column(TypeName = "varchar(250)")]
        [Display(Name = "Name")]

        public string EmployeeName { get; set; }
        [Column(TypeName = "varchar(250)")]
        [Display(Name = "Image User")]
        public string ImageUser { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Salary")]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Salary { get; set; }

        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MMMM-YYYY}")]
        public DateTime HiringDate { get; set; }
        [Column(TypeName = "varchar(14)")]
        [MaxLength(14)]
        [MinLength(14)]
        [Display(Name = "NationalId")]
        public string NationalId { get; set; }  
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }

    }
}
