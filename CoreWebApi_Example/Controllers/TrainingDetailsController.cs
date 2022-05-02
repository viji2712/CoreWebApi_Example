using CoreWebApi_Example.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingDetailsController : ControllerBase
    {
        private IApplicationDbContext _context;

        public TrainingDetailsController(IApplicationDbContext context)
        {
            _context = context;
           
        }
       
    }
}
