using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WWI.WebAPI.Services;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockItemsController : ControllerBase
    {
        private IStockItemService _stockItemService;
        private ILogger<StockItemsController> _logger;

        public StockItemsController(IStockItemService service, ILogger<StockItemsController> logger)
        {
            _stockItemService = service;
            _logger = logger;
        }
    }
}
