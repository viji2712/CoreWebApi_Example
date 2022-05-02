
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApi_TrainingCalendar_CodeFirst.Models;
using WebApi_TrainingCalendar_CodeFirst.Models.Repository;

namespace WebApi_TrainingCalendar_CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class TrainingCalendarController : ControllerBase
    {
        private readonly IDataRepository<TrainingDetailsModel> _dataRepository;

        public TrainingCalendarController(IDataRepository<TrainingDetailsModel> dataRepository)
        {
            _dataRepository = dataRepository;
        }



        // GET: api/TrainingDetails

        [Route("GetAllTrainingDetails")]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var trainingDetails = _dataRepository.GetAll();
                if (trainingDetails == null)
                {
                    return NotFound();
                }

                return Ok(trainingDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }



        // GET: api/TrainingDetailsByCourse

        [Route("GetTrainingDetailsByCourse")]

        [HttpGet]
        public IActionResult GetByCourse(string Course)
        {
            try
            {
                var trainingDetails = _dataRepository.GetTrainingDetailsByCourseName(Course);
                if (trainingDetails == null)
                    return NotFound();

                return Ok(trainingDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        // GET: api/TrainingDetailsByTrainerId

        [Route("GetTrainingDetailsByTrainerId")]
        [HttpGet]
        public IActionResult GetByTrainerId(int TrainerId)
        {
            try
            {
                var trainingDetails = _dataRepository.GetTrainingDetailsByTrainerId(TrainerId);
                if (trainingDetails == null)
                    return NotFound();
                return Ok(trainingDetails);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        // GET: api/TrainingDetailsByDates

        [Route("GetTrainingDetailsByDates")]
        [HttpGet]
        public IActionResult GetByDateRanges(DateTime SDate, DateTime EDate)
        {
            try
            {
                var trainingDetails = _dataRepository.GetTrainingDetailsByDates(SDate, EDate);
                if (trainingDetails == null)
                    return NotFound();
                return Ok(trainingDetails);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // POST: api/AddTrainingDetails

        [Route("AddTrainingDetails")]
        [HttpPost]
        public IActionResult CreateTrainingSchedule([FromBody]TrainingDetailsModel trainingModel)
        {
            var response = _dataRepository.AddTrainingDetails(trainingModel);
            return Ok(response);
        }


        // PUT: api/UpdateTrainingDetails

        [Route("UpdateTrainingDetails")]
        [HttpPut]
        public IActionResult UpdateTrainingSchedule( TrainingDetailsModel trainingModel)
        {
            try
            {
                var response = _dataRepository.UpdateTrainingDetails( trainingModel);
                return Ok(response);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }



        // PUT: api/CancelTrainingDetails

        [Route("CancelScheduledTrainingDetails")]
        [HttpPut]
        public IActionResult CancelTrainingSchedule(TrainingDetailsModel trainingModel)
        {
            try
            {
                var response = _dataRepository.CancelScheduledTrainingDetails(trainingModel);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            return Ok();
        }


        // GET: api/EmployeeDetails

        [Route("GetAllEmployees")]
        [HttpGet]
        public IActionResult GetEmployees()
        {
            try
            {
                var empDetails = _dataRepository.GetAllEmployees();
                if (empDetails == null)
                {
                    return NotFound();
                }

                return Ok(empDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
