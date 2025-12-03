using WWI.WebAPI.Repositories.Interfaces;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepo;
        private readonly IStockItemRepository _stockItemRepo;
        private readonly ILogger<OrderService> _logger;

        public OrderService(IOrderRepository repo, ILogger<OrderService> logger)
        {
            _orderRepo = repo;
            _logger = logger;

        }
    }
}
