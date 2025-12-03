using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WWI.WebAPI.Services;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private ISupplierService _supplierService;
        private ILogger<SupplierService> _logger;

        public SuppliersController(ISupplierService supplierService, ILogger<SupplierService> logger)
        {
            _supplierService = supplierService;
            _logger = logger;
        }
    }
}
