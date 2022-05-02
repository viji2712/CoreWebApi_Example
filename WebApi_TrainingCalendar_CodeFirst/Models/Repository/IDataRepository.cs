namespace WebApi_TrainingCalendar_CodeFirst.Models.Repository
{
    public interface IDataRepository<TrainingDetailsModel>
    {
        IEnumerable<TrainingDetailsModel> GetAll();

        IEnumerable<TrainingDetailsModel> GetTrainingDetailsByCourseName(string CourseName);

        IEnumerable<TrainingDetailsModel> GetTrainingDetailsByTrainerId(int TrainerId);

        IEnumerable<TrainingDetailsModel> GetTrainingDetailsByDates(DateTime StartDate, DateTime EndDate);

        int AddTrainingDetails(TrainingDetailsModel  trainingDetails);

        int UpdateTrainingDetails(TrainingDetailsModel trainingDetails);

        int CancelScheduledTrainingDetails(TrainingDetailsModel trainingDetails);

        IEnumerable<Employee> GetAllEmployees();

    }
}