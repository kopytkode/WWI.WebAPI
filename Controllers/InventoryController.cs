using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private IInventoryService _inventoryService;
        private ILogger<InventoryController> _logger;

        public InventoryController(IInventoryService service, ILogger<InventoryController> logger)
        {
            _inventoryService = service;
            _logger = logger;
        }
    }
}
