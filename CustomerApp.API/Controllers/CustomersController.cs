using CustomerApp.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly InMemoryCustomerService _customerService;
        
        public CustomersController() {
            _customerService = new();

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            _customerService.Add(new());
            return Ok(_customerService);
        }

        
    }
}
