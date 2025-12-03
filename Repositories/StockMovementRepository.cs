using WWI.WebAPI.Data;
using WWI.WebAPI.Repositories.Interfaces;

namespace WWI.WebAPI.Repositories
{
    /// <summary>
    /// For managing StockItem transaction history
    ///     Uses the Entity: StockItemTransaction (referred to as Stock Movement in our code)
    /// Represents every change in stock quantity or location
    /// Records movement in or out of inventory
    /// 
    /// This repository is used by the InventoryService to calculate current stock levels and retreive movement history
    /// </summary>

    public class StockMovementRepository : IStockMovementRepository
    {
        private readonly WideWorldContext _context;
        private readonly ILogger<StockMovementRepository> _logger;

        public StockMovementRepository(WideWorldContext context, ILogger<StockMovementRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
    }
}
