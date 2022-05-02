using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_TrainingCalendar_CodeFirst.Models
{
    [Table("TrainingDetails")]
    public class TrainingDetailsModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? PreRequisite { get; set; }
        public int? Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Timings { get; set; }
        public string? TeamLink { get; set; }
        public int TrainerId { get; set; }

        public string? Status { get; set; }
    }
}
