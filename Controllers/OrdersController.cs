using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrderService _orderService;
        private ILogger<OrdersController> _logger;

        public OrdersController(IOrderService service, ILogger<OrdersController> logger)
        {
            _orderService = service;
            _logger = logger;
        }
    }
}
