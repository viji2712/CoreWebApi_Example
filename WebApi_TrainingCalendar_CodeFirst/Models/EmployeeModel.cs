using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_TrainingCalendar_CodeFirst.Models
{
    [Table("Employee")]
    public class EmployeeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
       public string? DepartmentName { get; set; }

       // public virtual TrainingDetailsModel? TrainingDetails { get; set; }
    }
}
