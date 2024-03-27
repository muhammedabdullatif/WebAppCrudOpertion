using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCrudOpertion.Models
{
    [Table("Departments",Schema ="HR")]
    public class Department
    {
        [Key]
        [Display(Name = "ID")]
        public int DepartmentId{ get; set; }
        [Required]
        [Display(Name = "Depatment Name")]
        [Column(TypeName = "varchar(200)")]
        public string DepartmentName { get; set; }
    }
}
