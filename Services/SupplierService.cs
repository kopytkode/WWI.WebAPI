using WWI.WebAPI.Repositories.Interfaces;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepo;
        private readonly IStockItemRepository _stockItemRepo;
        private readonly ILogger<SupplierService> _logger;

        public SupplierService(ISupplierRepository repo, IStockItemRepository stockItemRepo, ILogger<SupplierService> logger)
        {
            _supplierRepo = repo;
            _stockItemRepo = stockItemRepo;
            _logger = logger;
        }
    }
}
