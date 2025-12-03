using WWI.WebAPI.Repositories.Interfaces;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Services
{
    //This services invoices the StockItem Repository which represents an item of stock, details like SKU, name, unit price, packaging, supplier, etc. 
    public class StockItemService : IStockItemService
    {
        private readonly IStockItemRepository _stockItemRepo;
        private readonly ILogger<SupplierService> _logger;

        public StockItemService(IStockItemRepository repo, ILogger<SupplierService> logger)
        {
            _stockItemRepo = repo;
            _logger = logger;

        }
    }
}
