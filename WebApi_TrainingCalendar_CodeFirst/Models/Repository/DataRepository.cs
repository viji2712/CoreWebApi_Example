using Microsoft.EntityFrameworkCore;
using WebApi_TrainingCalendar_CodeFirst.Data;

namespace WebApi_TrainingCalendar_CodeFirst.Models.Repository
{
    public class DataRepository : IDataRepository<TrainingDetailsModel>
    {

        readonly ApplicationDbcontext _applicationDbContext;

        public DataRepository(ApplicationDbcontext context)
        {
            _applicationDbContext = context;
        }

        
        public IEnumerable<TrainingDetailsModel> GetAll()
        {
            return _applicationDbContext.TrainingDetails.Where(x => x.Status == "ACTIVE").ToList();
        }

     
        public IEnumerable<TrainingDetailsModel> GetTrainingDetailsByCourseName(string Course)
        {
            var searchByCourse = _applicationDbContext.TrainingDetails.Where(x => x.CourseName == Course).ToList();
             return searchByCourse;
        }

      
        public IEnumerable<TrainingDetailsModel> GetTrainingDetailsByDates(DateTime StartDate, DateTime EndDate)
        {
           var searchByDates= _applicationDbContext.TrainingDetails.Where(x => x.StartDate == StartDate || x.EndDate== EndDate && x.Status == "ACTIVE").ToList();
            return searchByDates;
        }


        public IEnumerable<TrainingDetailsModel> GetTrainingDetailsByTrainerId(int TrainerId)
        {
            var searchByTrainerId = _applicationDbContext.TrainingDetails.Where(x => x.TrainerId == TrainerId &&  x.Status == "ACTIVE").ToList();
         
            return searchByTrainerId;
        }

        public int AddTrainingDetails(TrainingDetailsModel trainingDetails)
        {
            trainingDetails.Status = "ACTIVE";
            _applicationDbContext.TrainingDetails.Add(trainingDetails);         
             var result=_applicationDbContext.SaveChanges();
            return result;
        }

        public int UpdateTrainingDetails(TrainingDetailsModel trainingDetails)
        {
            trainingDetails.CourseId= trainingDetails.CourseId;
            trainingDetails.Status = "ACTIVE";
            _applicationDbContext.Entry(trainingDetails).State = EntityState.Modified;
            var result = _applicationDbContext.SaveChanges();
            return result;
        }
        
        public int CancelScheduledTrainingDetails(TrainingDetailsModel trainingDetails)
        {
            int result=0;
            trainingDetails.Status= "INACTIVE";
              trainingDetails.CourseId = trainingDetails.CourseId;
            trainingDetails.TrainerId = trainingDetails.TrainerId;

                _applicationDbContext.Entry(trainingDetails).State = EntityState.Modified;
            result = _applicationDbContext.SaveChanges();
            return result;
           
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return (IEnumerable<Employee>)_applicationDbContext.Employees.ToList();
        }

    }
}


