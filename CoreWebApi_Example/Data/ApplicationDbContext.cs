using CoreWebApi_Example.Model;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApi_Example.Data
{
    public class ApplicationDbContext:DbContext
    {
      
            public ApplicationDbContext(DbContextOptions options) : base(options)
        {

            }
            DbSet<TrainingDetails> TrainingDetailsList { get; set; }
           DbSet<Employee> EmployeeList { get; set; }
    }
    }

