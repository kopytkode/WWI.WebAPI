using WWI.WebAPI.Repositories.Interfaces;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Services
{
    //this service invokes the StockMovement repository, which represents how stock changes over time, goods received, sold, and adjusted. 
    //transactions here affect the stock quantity

    public class InventoryService : IInventoryService
    {
        private readonly IStockMovementRepository _inventoryRepo;
        private readonly ILogger<InventoryService> _logger;

        public InventoryService(IStockMovementRepository repo, ILogger<InventoryService> logger)
        {
            _inventoryRepo = repo;
            _logger = logger;

        }
    }
}
