using WebApi_TrainingCalendar_CodeFirst.Models;

namespace WebApi_TrainingCalendar_CodeFirst.Data
{
    public interface IApplicationDbcontext
    {
        IEnumerable<TrainingDetailsModel> GetAll();

        IEnumerable<TrainingDetailsModel> GetTrainingDetailsByCourseName(string CourseName);

        IEnumerable<TrainingDetailsModel> GetTrainingDetailsByTrainerId(int TrainerId);

        IEnumerable<TrainingDetailsModel> GetTrainingDetailsByDates(DateTime StartDate,DateTime EndDate);

    }
}



















/*

TrainingDetailsModel Get(long id);
void Add(TrainingDetailsModel entity);
void Update(TrainingDetailsModel dbEntity, TrainingDetailsModel entity);
void Delete(TrainingDetailsModel entity);

IEnumerable<EmployeeModel> GetAllEmployees();*/