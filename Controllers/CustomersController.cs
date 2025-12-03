using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerService _customerService;
        private ILogger<CustomersController> _logger;

        public CustomersController(ICustomerService service, ILogger<CustomersController> logger)
        {
            _customerService = service;
            _logger = logger;
        }
    }
}
