using CoreWebApi_Example.Model;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApi_Example.Data
{
    public interface IApplicationDbContext
    {

    DbSet<TrainingDetails> TrainingDetailsList { get; set; }
    DbSet<Employee>? EmployeeList { get; set; }
    Task<int> SaveChanges();


     
    }
}

