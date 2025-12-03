using WWI.WebAPI.Data;
using WWI.WebAPI.Repositories.Interfaces;

namespace WWI.WebAPI.Repositories
{
    /// <summary>
    /// For managing StockItem data
    ///     Uses the Entity: StockItem
    /// Represents a product that the company buys or sells.
    /// </summary>

    public class StockItemRepository : IStockItemRepository
    {
        private readonly WideWorldContext _context;
        private readonly ILogger<StockItemRepository> _logger;

        public StockItemRepository(WideWorldContext context, ILogger<StockItemRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
    }
}
