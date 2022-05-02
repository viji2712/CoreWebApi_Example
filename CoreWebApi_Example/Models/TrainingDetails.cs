using System.ComponentModel.DataAnnotations;

namespace CoreWebApi_Example.Model
{
    public class TrainingDetails 
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? PreRequisite { get; set; }
        public int? Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Timings { get; set; }
        public string? TeamsLink { get; set; }
        public int TrainerId { get; set; }

    }

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? Department { get; set; }
    }

    public class ResponseModel
    {
        public bool IsSuccess { get; set; }
        public string? Messsage { get; set; }
    }
}
