using Microsoft.EntityFrameworkCore;
using WebApi_TrainingCalendar_CodeFirst.Models;

namespace WebApi_TrainingCalendar_CodeFirst.Data
{
    public class ApplicationDbcontext : DbContext
    {
       
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options)
         : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TrainingDetailsModel> TrainingDetails { get; set; }
      
    }
}



















