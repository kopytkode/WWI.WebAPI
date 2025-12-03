using WWI.WebAPI.Repositories.Interfaces;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Services
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IOrderRepository _orderRepo;
        private readonly ILogger<DeliveryService> _logger;

        public DeliveryService(IOrderRepository repo, ILogger<DeliveryService> logger)
        {
            _orderRepo = repo;
            _logger = logger;

        }
    }
}
