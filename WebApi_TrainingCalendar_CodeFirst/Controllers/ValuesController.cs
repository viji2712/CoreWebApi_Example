using Microsoft.AspNetCore.Mvc;
using WebApi_TrainingCalendar_CodeFirst.Data;
using WebApi_TrainingCalendar_CodeFirst.Models;
using WebApi_TrainingCalendar_CodeFirst.Models.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_TrainingCalendar_CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
     
        private readonly IDataRepository<TrainingDetailsModel, EmployeeModel> _dataRepository;

        public ValuesController(IDataRepository<TrainingDetailsModel, EmployeeModel> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // GET: api/<ValuesController>

        [Route("GetAllTrainingDetails")]

        // GET: api/TrainingDetails
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
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }




        [Route("GetTrainingDetailsByCourse")]

        // GET: api/TrainingDetails
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
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [Route("GetTrainingDetailsByTrainerId")]

        // GET: api/TrainingDetails
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

        [Route("GetTrainingDetailsByDates")]

        // GET: api/TrainingDetails
        [HttpGet]
        public IActionResult GetByDateRanges(DateTime SDate,DateTime  EDate)
        {
            try
            {
                var trainingDetails = _dataRepository.GetTrainingDetailsByDates(SDate, EDate);
                if (trainingDetails == null)
                    return NotFound();
                return Ok(trainingDetails);
            }
            catch(Exception e)
            { 
                return StatusCode(500, e.Message);
            }
        }

        [Route("AddTrainingDetails")]

        // POST: api/AddTrainingDetails
        [HttpPost]
        public IActionResult CreateTrainingSchedule(TrainingDetailsModel trainingModel)
        {
            
            var response=_dataRepository.AddTrainingDetails(trainingModel);
           
            return Ok(response);
        }

        [Route("UpdateTrainingDetails")]

        // PUT: api/UpdateTrainingDetails
        [HttpPut]
        public IActionResult UpdateTrainingSchedule(int Id,TrainingDetailsModel trainingModel)
        {
           
            try
            {
                var response = _dataRepository.UpdateTrainingDetails(Id, trainingModel);
                return Ok(response);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [Route("CancelTrainingDetails")]

        // PUT: api/CancelTrainingDetails
        [HttpPut]
        public IActionResult CancelTrainingSchedule(int Id, TrainingDetailsModel trainingModel)
        {

            try
            {
                var response = _dataRepository.CancelScheduledTrainingDetails(Id, trainingModel);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            return Ok();
        }
    }
}






















/*
  // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
 
 
 */